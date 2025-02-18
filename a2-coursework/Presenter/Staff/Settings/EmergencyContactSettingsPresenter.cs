using a2_coursework._Helpers;
using a2_coursework.Interfaces.Staff.Settings;
using a2_coursework.Model.Staff;

namespace a2_coursework.Presenter.Users.Settings;
public partial class EmergencyContactSettingsPresenter : SettingsPresenter<IEmergencyContactSettings> {
    public EmergencyContactSettingsPresenter(IEmergencyContactSettings view, StaffModel staff) : base(view, staff) {
        _view.EmergencyContactSurnameChanged += OnEmergencyContactNameChanged;
        _view.EmergencyContactForenameChanged += OnEmergencyContactNameChanged;
        _view.EmergencyContactPhoneNumberChanged += OnEmergencyContactPhoneNumberChanged;
    }

    private void OnEmergencyContactNameChanged(object? sender, EventArgs e) => SetApproveChangesBarVisibility();
    private void OnEmergencyContactPhoneNumberChanged(object? sender, EventArgs e) => InputChanged();

    protected override void PopulateDefaultValues() {
        _view.EmergencyContactForename = _staff.EmergencyContactForename;
        _view.EmergencyContactSurname = _staff.EmergencyContactSurname;
        _view.EmergencyContactPhoneNumber = _staff.EmergencyContactPhoneNumber;
    }

    protected override void UpdateStaff() {
        _staff.EmergencyContactForename = _view.EmergencyContactForename;
        _staff.EmergencyContactSurname = _view.EmergencyContactSurname;
        _staff.EmergencyContactPhoneNumber = _view.EmergencyContactPhoneNumber;
    }

    private void InputChanged() {
        ValidateInputs();
        SetApproveChangesBarVisibility();
    }

    protected override bool AnyChanges() => _view.EmergencyContactForename != _staff.EmergencyContactForename || _view.EmergencyContactSurname != _staff.EmergencyContactSurname || _view.EmergencyContactPhoneNumber != _staff.EmergencyContactPhoneNumber;

    protected override bool ValidateInputs() {
        if (_view.EmergencyContactPhoneNumber != "" && !Validators.IsValidPhoneNumber(_view.EmergencyContactPhoneNumber)) {
            _view.PhoneNumberErrorText = "Invalid phone number";
            _view.SetPhoneNumberBorderError(true);
            return false;
        }

        _view.PhoneNumberErrorText = "";
        _view.SetPhoneNumberBorderError(false);
        return true;
    }

    protected override Task<bool> UpdateDatabase() => StaffDAL.UpdateEmergencyContact(_staff.Id, _view.EmergencyContactForename, _view.EmergencyContactSurname, _view.EmergencyContactPhoneNumber);

    public override void CleanUp() {
        _view.EmergencyContactSurnameChanged -= OnEmergencyContactNameChanged;
        _view.EmergencyContactForenameChanged -= OnEmergencyContactNameChanged;
        _view.EmergencyContactPhoneNumberChanged -= OnEmergencyContactPhoneNumberChanged;

        base.CleanUp();
    }
}
