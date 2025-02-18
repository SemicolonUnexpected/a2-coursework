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
        ValidateEmail();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    private void OnPhoneNumberChanged(object? sender, EventArgs e) {
        ValidatePhoneNumber();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    private void OnAddressChanged(object? sender, EventArgs e) => DetailsChanged?.Invoke(this, EventArgs.Empty);

    private void ValidateEmail() {
        bool valid = _Helpers.Validators.IsValidEmail(_view.Email);
        _view.SetEmailBorderError(!valid);
    }

    private void ValidatePhoneNumber() {
        bool valid = _Helpers.Validators.IsValidPhoneNumber(_view.PhoneNumber);
        _view.SetPhoneNumberBorderError(!valid);
    }

    public void SetEmail(string email) => _view.Email = email;

    public bool TryGetEmail(out string? email) {
        bool valid = _Helpers.Validators.IsValidEmail(_view.Email);

        email = valid ? _view.Email : null;

        return valid;
    }

    public void SetPhoneNumber(string phoneNumber) => _view.PhoneNumber = phoneNumber;

    public bool TryGetPhoneNumber(out string? phoneNumber) {
        bool valid = _Helpers.Validators.IsValidPhoneNumber(_view.PhoneNumber);

        phoneNumber = valid ? _view.PhoneNumber : null;

        return valid;
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
