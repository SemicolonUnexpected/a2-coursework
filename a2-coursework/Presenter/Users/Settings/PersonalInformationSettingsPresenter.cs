using a2_coursework.Model;
using a2_coursework.View.Interfaces.Users.Settings;

namespace a2_coursework.Presenter.Users.Settings;
public class PersonalInformationSettingsPresenter : SettingsPresenter<IPersonalInformationSettings>, IChildPresenter {
    public PersonalInformationSettingsPresenter(IPersonalInformationSettings view, Staff staff) : base(view, staff) {
        _view.SurnameChanged += InputChanged;
        _view.ForenameChanged += InputChanged;
        _view.DateOfBirthChanged += InputChanged;
    }

    private void InputChanged(object? sender, EventArgs e) => InputChanged();

    protected override void PopulateDefaultValues() {
        _view.Forename = _staff.Forename;
        _view.Surname = _staff.Surname;
        _view.DateOfBirth = _staff.DateOfBirth;
    }

    protected override void UpdateStaff() {
        _staff.Forename = _view.Forename;
        _staff.Surname = _view.Surname;
        _staff.DateOfBirth = _view.DateOfBirth;
    }

    private void InputChanged() {
        ValidateInputs();
        SetApproveChangesBarVisibility();
    }

    protected override bool ValidateInputs() {
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

        return !(forenameEmpty || surnameEmpty || !_view.DateOfBirthValid);
    }

    protected override bool AnyChanges() => _view.Forename != _staff.Forename || _view.Surname != _staff.Surname || _view.DateOfBirth != _staff.DateOfBirth;

    protected override Task<bool> UpdateDatabase() => StaffDAL.UpdatePersonalDetails(_staff.Id, _view.Forename, _view.Surname, _view.DateOfBirth);

    public override void CleanUp() {
        _view.SurnameChanged -= InputChanged;
        _view.ForenameChanged -= InputChanged;
        _view.DateOfBirthChanged -= InputChanged;

        base.CleanUp();
    }
}
