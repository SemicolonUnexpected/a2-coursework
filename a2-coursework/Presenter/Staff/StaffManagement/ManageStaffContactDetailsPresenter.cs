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

    private void OnAddressChanged(object? sender, EventArgs e) {
        SetCharacterCount();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    private void SetCharacterCount() => _view.SetCharacterCount(_view.Address.Length);

    private bool _emailValid = true;
    private bool _phoneNumberValid = true;
    private void ValidateContactInformation() {
        _emailValid = _Helpers.Validators.IsValidEmail(_view.Email);
        _view.SetEmailBorderError(!_emailValid);

        _phoneNumberValid = _Helpers.Validators.IsValidPhoneNumber(_view.PhoneNumber);
        _view.SetPhoneNumberBorderError(!_phoneNumberValid);

        _view.ContactError = (_emailValid, _phoneNumberValid) switch {
            (true, true) => "",
            (true, false) => "Invalid phone number",
            (false, true) => "Invalid email",
            (false, false) => "Invalid email and phone number",
        };
    }

    public string Email {
        get => _view.Email;
        set => _view.Email = value;
    }

    public bool EmailValid {
        get {
            ValidateContactInformation();
            return _emailValid;
        }
    }

    public string PhoneNumber {
        get => _view.PhoneNumber;
        set => _view.PhoneNumber = value;
    }

    public bool PhoneNumberValid {
        get {
            ValidateContactInformation();
            return _phoneNumberValid;
        }
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
