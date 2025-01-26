using a2_coursework.Model;
using a2_coursework.View.Interfaces; 

namespace a2_coursework.Presenter; 
public class PersonalInformationSettingsPresenter {
    private IPersonalInformationSettings _view;
    private Staff _staff;

    public PersonalInformationSettingsPresenter(IPersonalInformationSettings view, Staff staff) {
        _view = view;
        _staff = staff;

        PopulateDefaultValues();
    }

    private void PopulateDefaultValues() {
        _view.ForenameInput = _staff.Forename;
        _view.SurnameInput = _staff.Surname;
        _view.DateOfBirthInput = _staff.DateOfBirth;
    }

    /// <summary>
    /// Check to see which error message to display based on the name input
    /// </summary>
    /// <returns></returns>
    public void NameInputError() {
        bool forenameBlank = string.IsNullOrWhiteSpace(_view.ForenameInput);
        bool surnameBlank = string.IsNullOrWhiteSpace(_view.SurnameInput);

        if (forenameBlank && surnameBlank) {
            _view.NameErrorText = "Please fill in your names";
            _view.SetForenameBorderError(true);
            _view.SetSurnameBorderError(true);
        }
        else if (forenameBlank) {
            _view.NameErrorText = "Please fill in a valid forename";
            _view.SetForenameBorderError(true);
        }
        else if (surnameBlank) {
            _view.NameErrorText = "Please fill in a valid surname";
            _view.SetSurnameBorderError(true);
        }
        else {
            _view.NameErrorText = "";
            _view.SetForenameBorderError(false);
            _view.SetSurnameBorderError(false);
        }
    }

    /// <summary>
    /// Check to see which error message to display based on the date of birth input
    /// </summary>
    /// <returns></returns>
    public void DateOfBirthInputError() {
        if (_view.DateOfBirthInput is null) _view.DateOfBirthErrorText = "Invalid date";
        else _view.DateOfBirthErrorText = "";
    }

    public void SetApproveChangesBarVisibility() {
        if (_view.ForenameInput != _staff.Forename || _view.SurnameInput != _staff.Surname || _view.DateOfBirthInput != _staff.DateOfBirth) _view.ApproveChangesBarVisible = true;
        else _view.ApproveChangesBarVisible = false;
    }

    public void TrySaveChanges() {
    }

    public void Cancel() {
        PopulateDefaultValues();
    }
}
