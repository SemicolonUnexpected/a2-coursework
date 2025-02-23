using a2_coursework.Interfaces.Staff.StaffManagement;

namespace a2_coursework.Presenter.Staff.StaffManagement;
public class ManageStaffPasswordPresenter : BasePresenter<IManageStaffPasswordView> {
    private bool _passwordValid;

    public ManageStaffPasswordPresenter(IManageStaffPasswordView view) : base(view) {
        _view.PasswordChanged += OnPasswordChanged;
    }

    private void OnPasswordChanged(object? sender, EventArgs e) => ValidatePasswordRequirements();

    public string Password {
        get => _view.Password;
        set => _view.Password = value;
    }

    public string ConfirmPassword {
        get => _view.ConfirmPassword;
        set => _view.ConfirmPassword = value;
    }

    public bool PasswordValid {
        get {
            ValidatePasswordInputs();
            return _passwordValid;
        }
    }

    private bool ValidatePasswordRequirements() {
        _view.EightLong = _view.Password.Length >= 8;
        _view.UppercaseLowercase = _view.Password.Any(char.IsUpper) && _view.Password.Any(char.IsLower);
        _view.Number = _view.Password.Any(char.IsDigit);
        _view.SpecialCharacter = _view.Password.Any(c => !char.IsLetterOrDigit(c));

        if (_view.EightLong && _view.UppercaseLowercase && _view.Number && _view.SpecialCharacter) {
            _view.SetPasswordBorderError(false);
            return true;
        }

        _view.SetPasswordBorderError(true);
        return false;
    }

    private void ValidatePasswordInputs() {
        bool passwordEmpty = _view.Password.Length == 0;
        bool confirmPasswordEmpty = _view.ConfirmPassword.Length == 0;

        _view.SetPasswordBorderError(passwordEmpty);
        _view.SetConfirmPasswordBorderError(confirmPasswordEmpty);

        // Something is missing
        if (passwordEmpty || confirmPasswordEmpty) {
            _view.PasswordError = (passwordEmpty, confirmPasswordEmpty) switch {
                (true, true) => "New and confirm password are required",
                (true, false) => "New password is required",
                (false, true) => "Confirm the password",
                _ => throw new NotImplementedException(),
            };
            _passwordValid =  false;
            return;
        }

        // The new password does not meet the requirements
        if (!ValidatePasswordRequirements()) {
            _view.PasswordError = "Password does not satisfy the requirements";
            _passwordValid =  false;
            return;
        }

        // Confirm password does not match
        if (_view.Password != _view.ConfirmPassword) {
            _view.PasswordError = "Passwords did not match";
            _passwordValid =  false;
            return;
        }

        _view.PasswordError = "";

        _passwordValid =  true;
    }

    public override void CleanUp() {
        _view.PasswordChanged -= OnPasswordChanged;

        base.CleanUp();
    }
}
