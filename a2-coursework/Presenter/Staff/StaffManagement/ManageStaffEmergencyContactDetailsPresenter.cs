using a2_coursework._Helpers;
using a2_coursework.Interfaces.Staff.StaffManagement;

namespace a2_coursework.Presenter.Staff.StaffManagement;
public class ManageStaffEmergencyContactDetailsPresenter : BasePresenter<IManageStaffEmergencyContactDetailsView>, IChildPresenter, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public ManageStaffEmergencyContactDetailsPresenter(IManageStaffEmergencyContactDetailsView view) : base(view) {
        _view.EmergencyContactForenameChanged += OnEmergencyContactForenameChanged;
        _view.EmergencyContactSurnameChanged += OnEmergencyContactSurnameChanged;
        _view.EmergencyContactPhoneNumberChanged += OnEmergencyContactPhoneNumberChanged;
    }

    private void OnEmergencyContactSurnameChanged(object? sender, EventArgs e) => DetailsChanged?.Invoke(this, EventArgs.Empty);
    private void OnEmergencyContactForenameChanged(object? sender, EventArgs e) => DetailsChanged?.Invoke(this, EventArgs.Empty);
    private void OnEmergencyContactPhoneNumberChanged(object? sender, EventArgs e) {
        ValidateEmergencyContactPhoneNumber();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    private readonly bool _emergencyContactPhoneNumberValid = true;
    private void ValidateEmergencyContactPhoneNumber() {
        bool _emergencyContactPhoneNumberValid = Validators.IsValidPhoneNumber(_view.EmergencyContactPhoneNumber) || _view.EmergencyContactPhoneNumber == "";

        _view.SetEmergencyContactPhoneNumberBorderError(_emergencyContactPhoneNumberValid);
        _view.EmergencyContactPhoneNumberError = _emergencyContactPhoneNumberValid ? "" : "Invalid phone number";
    }

    public void SetEmergencyContactPhoneNumber(string emergencyContactPhoneNumber) => _view.EmergencyContactPhoneNumber = emergencyContactPhoneNumber;

    public bool TryGetEmergencyContactPhoneNumber(out string? emergencyContactPhoneNumber) {
        emergencyContactPhoneNumber = _emergencyContactPhoneNumberValid ? _view.EmergencyContactPhoneNumber : null;
        return _emergencyContactPhoneNumberValid;
    }

    public string EmergencyContactForename {
        get => _view.EmergencyContactForename;
        set => _view.EmergencyContactForename = value;
    }

    public string EmergencyContactSurname {
        get => _view.EmergencyContactSurname;
        set => _view.EmergencyContactSurname = value;
    }

    public bool CanExit() => true;

    public override void CleanUp() {
        base.CleanUp();
    }
}
