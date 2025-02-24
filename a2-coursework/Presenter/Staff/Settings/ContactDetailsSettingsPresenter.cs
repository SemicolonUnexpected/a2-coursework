using a2_coursework._Helpers;
using a2_coursework.Interfaces.Staff.Settings;
using a2_coursework.Model.Staff;

namespace a2_coursework.Presenter.Users.Settings;
public class ContactDetailsSettingsPresenter : SettingsPresenter<IContactDetailsSettings> {
    public ContactDetailsSettingsPresenter(IContactDetailsSettings view, StaffModel staff) : base(view, staff) {
        _view.EmailChanged += OnContactInformationChanged;
        _view.PhoneNumberChanged += OnContactInformationChanged;
        _view.AddressChanged += OnAddressChanged;
    }

    private void OnContactInformationChanged(object? sender, EventArgs e) => InputChanged();
    private void OnAddressChanged(object? sender, EventArgs e) => SetApproveChangesBarVisibility();

    protected override void PopulateDefaultValues() {
        _view.Email = _staff.Email;
        _view.PhoneNumber = _staff.PhoneNumber;
        _view.Address = _staff.Address;
    }

    protected override void UpdateStaff() {
        _staff.Email = _view.Email;
        _staff.PhoneNumber = _view.PhoneNumber;
        _staff.Address = _view.Address;
    }

    protected override bool AnyChanges() => _view.Email != _staff.Email || _view.PhoneNumber != _staff.PhoneNumber || _view.Address != _staff.Address;

    private void InputChanged() {
        ValidateInputs();
        SetApproveChangesBarVisibility();
    }

    protected override bool ValidateInputs() {
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

        return !(phoneNumberInvalid || emailInvalid);
    }

    protected override Task<bool> UpdateDatabase() => StaffDAL.UpdateStaffContactDetails(_staff.Id, _view.Email, _view.PhoneNumber, _view.Address);

    public override void CleanUp() {
        _view.EmailChanged -= OnContactInformationChanged;
        _view.PhoneNumberChanged -= OnContactInformationChanged;
        _view.AddressChanged -= OnAddressChanged;

        base.CleanUp();
    }
}
