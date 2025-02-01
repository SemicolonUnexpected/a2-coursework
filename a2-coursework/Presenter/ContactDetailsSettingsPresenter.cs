using a2_coursework._Helpers;
using a2_coursework.Model;
using a2_coursework.View.Interfaces;

namespace a2_coursework.Presenter; 
public class ContactDetailsSettingsPresenter {
    private readonly Staff _staff;
    private IContactDetailsSettings _view;

    public ContactDetailsSettingsPresenter(IContactDetailsSettings view, Staff staff) {
        _view = view;
        _staff = staff;

        _view.EmailChanged += (s, e) => InputChanged();
        _view.PhoneNumberChanged += (s, e) => InputChanged();
        _view.AddressChanged += (s, e) => SetApproveChangesBarVisibility();
        _view.SaveRequested += (s, e) => Save();
        _view.CancelRequested += (s, e) => Cancel();

        PopulateDefaultValues();
    }

    private void PopulateDefaultValues() {
        _view.Email = _staff.Email;
        _view.PhoneNumber = _staff.PhoneNumber;
        _view.Address = _staff.Address;
    }

    private void InputChanged() {
        ValidateInputs();
        SetApproveChangesBarVisibility();
    }

    private void ValidateInputs() {
        bool emailInvalid = !Validators.IsValidEmail(_view.Email);
        bool phoneNumberInvalid = !Validators.IsValidPhoneNumber(_view.PhoneNumber);

        if (emailInvalid) _view.SetEmailBorderError(true);
        else _view.SetEmailBorderError(false);

        if (phoneNumberInvalid) _view.SetPhoneNumberBorderError(true);
        else _view.SetPhoneNumberBorderError(false);

        if (emailInvalid && phoneNumberInvalid) _view.ContactErrorText = "Invalid email and phone number";
        else if (emailInvalid) _view.ContactErrorText = "Invalid email";
        else if (phoneNumberInvalid) _view.ContactErrorText = "Invalid phone number";
        else _view.ContactErrorText = "";
    }

    private void SetApproveChangesBarVisibility() {
        if (AnyChanges()) _view.SaveVisible = true;
        else _view.SaveVisible = false;
    }

    public bool AnyChanges() => _view.Email != _staff.Email || _view.PhoneNumber != _staff.PhoneNumber || _view.Address != _staff.Address;

    private async void Save() {
        ValidateInputs();

        bool emailInvalid = !Validators.IsValidEmail(_view.Email);
        bool phoneNumberInvalid = !Validators.IsValidPhoneNumber(_view.PhoneNumber);

        if (emailInvalid || phoneNumberInvalid) {
            string errorMessage = (emailInvalid, phoneNumberInvalid) switch {
                (true, true) => "Please ensure you fill in a valid email and phone number.",
                (true, false) => "Please ensure you fill in a valid email.",
                (false, true) => "Please ensure you fill in a valid phone number.",
                _ => throw new ArgumentException(),
            };

            _view.ShowError(errorMessage, "Invalid details");
            return;
        }

        try {
            _view.IsLoading = true;

            bool success = await StaffDAL.UpdateContactDetails(_staff.StaffID, _view.Email, _view.PhoneNumber, _view.Address);

            if (success) {
                UpdateStaff();
                _view.ShowSuccess("Your contact details have been successfully updated.", "Saved");
            }
            else _view.ShowError("Could not update your contact details", "Save failed");
        }
        catch {
            _view.ShowError("Could not update your contact details.", "Save failed");
        }
        finally {
            _view.IsLoading = false;
            SetApproveChangesBarVisibility();
        }
    }

    private void UpdateStaff() {
        _staff.Email = _view.Email;
        _staff.PhoneNumber = _view.PhoneNumber;
        _staff.Address = _view.Address;
    }

    private void Cancel() {
        PopulateDefaultValues();
        SetApproveChangesBarVisibility();
    }
}
