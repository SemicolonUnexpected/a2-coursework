using a2_coursework.Interfaces.Staff.StaffManagement;

namespace a2_coursework.Presenter.Staff.StaffManagement;
public class ManageStaffContactDetailsPresenter : BasePresenter<IManageStaffContactDetailsView>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public ManageStaffContactDetailsPresenter(IManageStaffContactDetailsView view) : base(view) {
        _view.EmailChanged += OnEmailChanged;
        _view.PhoneNumberChanged += OnPhoneNumberChanged;
        _view.AddressChanged += OnAddressChanged;
    }

    private void OnEmailChanged(object? sender, EventArgs e) {
        ValidateContactInformation();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    private void OnPhoneNumberChanged(object? sender, EventArgs e) {
        ValidateContactInformation();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    private void OnAddressChanged(object? sender, EventArgs e) => DetailsChanged?.Invoke(this, EventArgs.Empty);

    private bool _emailValid = true;
    private bool _phoneNumberValid = true;
    private void ValidateContactInformation() {
        bool _emailValid = _Helpers.Validators.IsValidEmail(_view.Email);
        _view.SetEmailBorderError(!_emailValid);

        bool _phoneNumberValid = _Helpers.Validators.IsValidPhoneNumber(_view.PhoneNumber);
        _view.SetPhoneNumberBorderError(!_phoneNumberValid);

        _view.ContactError = (_emailValid, _phoneNumberValid) switch {
            (true, true) => "",
            (true, false) => "Invalid phone number",
            (false, true) => "Invalid email",
            (false, false) => "Invalid email and phone number",
        };
    }

    public void SetEmail(string email) => _view.Email = email;

    public bool TryGetEmail(out string? email) {
        email = _emailValid ? _view.Email : null;
        return _emailValid;
    }

    public void SetPhoneNumber(string phoneNumber) => _view.PhoneNumber = phoneNumber;

    public bool TryGetPhoneNumber(out string? phoneNumber) {
        phoneNumber = _emailValid ? _view.PhoneNumber : null;
        return _phoneNumberValid;
    }

    public string Address {
        get => _view.Address;
        set => _view.Address = value;
    }

    public bool CanExit() => true;

    public override void CleanUp() {
        _view.EmailChanged -= OnEmailChanged;
        _view.PhoneNumberChanged -= OnPhoneNumberChanged;
        _view.AddressChanged -= OnAddressChanged;

        base.CleanUp();
    }
}
