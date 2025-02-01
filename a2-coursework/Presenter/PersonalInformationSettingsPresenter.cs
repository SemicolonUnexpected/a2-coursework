using a2_coursework.Model;
using a2_coursework.View.Interfaces;

namespace a2_coursework.Presenter;
public class PersonalInformationSettingsPresenter {
    private readonly IPersonalInformationSettings _view;
    private readonly Staff _staff;

    public PersonalInformationSettingsPresenter(IPersonalInformationSettings view, Staff staff) {
        _view = view;
        _staff = staff;

        _view.SurnameChanged += (s, e) => InputChanged();
        _view.ForenameChanged += (s, e) => InputChanged();
        _view.DateOfBirthChanged += (s, e) => InputChanged();
        _view.SaveRequested += (s, e) => Save();
        _view.CancelRequested += (s, e) => Cancel();

        PopulateDefaultValues();
    }

    private void PopulateDefaultValues() {
        _view.Forename = _staff.Forename;
        _view.Surname = _staff.Surname;
        _view.DateOfBirth = _staff.DateOfBirth;
    }

    private void UpdateStaff() {
        _staff.Forename = _view.Forename;
        _staff.Surname = _view.Surname;
        _staff.DateOfBirth = _view.DateOfBirth;
    }

    private void InputChanged() {
        ValidateInputs();
        SetApproveChangesBarVisibility();
    }

    private void ValidateInputs() {
        bool forenameEmpty = string.IsNullOrWhiteSpace(_view.Forename);
        bool surnameEmpty = string.IsNullOrWhiteSpace(_view.Surname);

        if (forenameEmpty) _view.SetForenameBorderError(true);
        else _view.SetForenameBorderError(false);

        if (surnameEmpty) _view.SetSurnameBorderError(true);
        else _view.SetSurnameBorderError(false);

        if (forenameEmpty && surnameEmpty) _view.NameErrorText = "Invalid forename and surname";
        else if (forenameEmpty) _view.NameErrorText = "Invalid forename";
        else if (surnameEmpty) _view.NameErrorText = "Invalid surname";
        else _view.NameErrorText = "";

        bool dateOfBirthInvalid = !_view.DateOfBirthValid;

        if (dateOfBirthInvalid) _view.DateOfBirthErrorText = "Invalid date of birth";
        else _view.DateOfBirthErrorText = "";
    }

    private void SetApproveChangesBarVisibility() {
        if (AnyChanges()) _view.SaveVisible = true;
        else _view.SaveVisible = false;
    }

    public bool AnyChanges() => _view.Forename != _staff.Forename || _view.Surname != _staff.Surname || _view.DateOfBirth != _staff.DateOfBirth;

    private async void Save() {
        ValidateInputs();

        bool forenameError = string.IsNullOrWhiteSpace(_view.Forename);
        bool surnameError = string.IsNullOrWhiteSpace(_view.Surname);
        bool dateOfBirthError = !_view.DateOfBirthValid;

        if (forenameError || surnameError || dateOfBirthError) {
            string nameError = (forenameError, surnameError) switch {
                (true, true) => "Please ensure you fill in a valid forename and surname.",
                (true, false) => "Please ensure you fill in a valid forename.",
                (false, true) => "Please ensure you fill in a valid surname.",
                (false, false) => "",
                };

            string finalMessage = "";
            if (dateOfBirthError && nameError.Length > 0) finalMessage = nameError + " .Your date of birth must be after 1900 or empty.";
            else if (dateOfBirthError) finalMessage = "Your date of birth must be after 1900 or empty.";

            _view.ShowError(finalMessage, "Invalid details");
            return;
        }

        try {
            _view.IsLoading = true;

            bool success = await StaffDAL.UpdatePersonalDetails(_staff.StaffID, _view.Forename, _view.Surname, _view.DateOfBirth);

            if (success) {
                UpdateStaff();
                _view.ShowSuccess("Your personal details have been successfully updated.", "Saved");
            }
            else _view.ShowError("Could not update your personal details.", "Save failed");
        }
        catch {
            _view.ShowError("Save failed", "Could not update your personal details.");
        }
        finally {
            _view.IsLoading = false;
            SetApproveChangesBarVisibility();
        }
    }

    private void Cancel() {
        PopulateDefaultValues();
        SetApproveChangesBarVisibility();
    }
}
