using a2_coursework._Helpers;
using a2_coursework.Model;
using a2_coursework.View.Interfaces.Users.Settings;

namespace a2_coursework.Presenter.Users.Settings;
public partial class EmergencyContactSettingsPresenter : SettingsPresenter<IEmergencyContactSettings>
{
    public EmergencyContactSettingsPresenter(IEmergencyContactSettings view, Staff staff) : base(view, staff)
    {
        _view.SurnameChanged += (s, e) => SetApproveChangesBarVisibility();
        _view.ForenameChanged += (s, e) => SetApproveChangesBarVisibility();
        _view.PhoneNumberChanged += (s, e) => InputChanged();
    }

    protected override void PopulateDefaultValues()
    {
        _view.Forename = _staff.EmergencyContactForename;
        _view.Surname = _staff.EmergencyContactSurname;
        _view.PhoneNumber = _staff.EmergencyContactPhoneNumber;
    }

    protected override void UpdateStaff()
    {
        _staff.EmergencyContactForename = _view.Forename;
        _staff.EmergencyContactSurname = _view.Surname;
        _staff.EmergencyContactPhoneNumber = _view.PhoneNumber;
    }

    private void InputChanged()
    {
        ValidateInputs();
        SetApproveChangesBarVisibility();
    }

    protected override bool AnyChanges() => _view.Forename != _staff.EmergencyContactForename || _view.Surname != _staff.EmergencyContactSurname || _view.PhoneNumber != _staff.EmergencyContactPhoneNumber;

    protected override bool ValidateInputs()
    {
        if (_view.PhoneNumber != "" && !Validators.IsValidPhoneNumber(_view.PhoneNumber))
        {
            _view.PhoneNumberErrorText = "Invalid phone number";
            _view.SetPhoneNumberBorderError(true);
            return false;
        }

        _view.PhoneNumberErrorText = "";
        _view.SetPhoneNumberBorderError(false);
        return true;
    }

    protected override Task<bool> UpdateDatabase() => StaffDAL.UpdateEmergencyContact(_staff.Id, _view.Forename, _view.Surname, _view.PhoneNumber);
}
