using a2_coursework._Helpers;
using a2_coursework.Model;
using a2_coursework.View.Interfaces;

namespace a2_coursework.Presenter;
public partial class EmergencyContactSettingsPresenter {
    private readonly Staff _staff;
    private readonly IEmergencyContactSettingsView _view;

    public EmergencyContactSettingsPresenter(IEmergencyContactSettingsView view, Staff staff) {
        _staff = staff;
        _view = view;

        _view.SurnameChanged += (s, e) => SetApproveChangesBarVisibility();
        _view.ForenameChanged += (s, e) => SetApproveChangesBarVisibility();
        _view.PhoneNumberChanged += (s, e) => InputChanged();
        _view.SaveRequested += (s, e) => Save();
        _view.CancelRequested += (s, e) => Cancel();

        PopulateDefaultValues();
    }

    private void PopulateDefaultValues() {
        _view.Forename = _staff.EmergencyContactForename;
        _view.Surname = _staff.EmergencyContactSurname;
        _view.PhoneNumber = _staff.EmergencyContactPhoneNumber;
    }

    private void InputChanged() {
        ValidateInputs();
        SetApproveChangesBarVisibility();
    }

    private void ValidateInputs() {
        if (_view.PhoneNumber != "" && !Validators.IsValidPhoneNumber(_view.PhoneNumber)) {
            _view.PhoneNumberErrorText = "Invalid phone number";
            _view.SetPhoneNumberBorderError(true);
        }
        else {
            _view.PhoneNumberErrorText = "";
            _view.SetPhoneNumberBorderError(false);
        }
    }

    private void SetApproveChangesBarVisibility() {
        if (AnyChanges()) _view.SaveVisible = true;
        else _view.SaveVisible = false;
    }

    public bool AnyChanges() => _view.Forename != _staff.EmergencyContactForename || _view.Surname != _staff.EmergencyContactSurname || _view.PhoneNumber != _staff.EmergencyContactPhoneNumber;

    private async void Save() {
        ValidateInputs();

        if (!Validators.IsValidPhoneNumber(_view.PhoneNumber)) {
            _view.ShowError("Please ensure you fill in a valid phone number.", "Invalid details");
            return;
        }

        try {
            _view.IsLoading = true;

            bool success = await StaffDAL.UpdateEmergencyContact(_staff.StaffID, _view.Forename, _view.Surname, _view.PhoneNumber);

            if (success) {
                UpdateStaff();
                _view.ShowSuccess("Your emergency contact has been successfully updated.", "Saved");
            }
            else _view.ShowError("Could not update your emergency contact", "Save failed");
        }
        catch {
            _view.ShowError("Save failed", "Could not update your emergency contact.");
        }
        finally {
            _view.IsLoading = false;
            SetApproveChangesBarVisibility();
        }
    }

    private void UpdateStaff() {
        _staff.EmergencyContactForename = _view.Forename;
        _staff.EmergencyContactSurname = _view.Surname;
        _staff.EmergencyContactPhoneNumber = _view.PhoneNumber;
    }

    private void Cancel() {
        PopulateDefaultValues();
        SetApproveChangesBarVisibility();
    }
}
