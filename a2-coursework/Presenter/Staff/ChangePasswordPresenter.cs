using a2_coursework.Interfaces.Users;
using a2_coursework.Model.StaffModel;
using AS_Coursework.Model.Security;

namespace a2_coursework.Presenter.Users;
public class ChangePasswordPresenter : BasePresenter<IChangePasswordView>, IChildPresenter {
    private readonly Staff _staff;

    public ChangePasswordPresenter(IChangePasswordView view, Staff staff) : base(view) {
        _staff = staff;

        _view.UsernameChanged += OnUsernameChanged;
        _view.NewPasswordChanged += OnNewPasswordChanged;
        _view.ChangePassword += OnChangePassword;
    }

    private void OnUsernameChanged(object? sender, EventArgs e) => ValidateUsername();
    private void OnNewPasswordChanged(object? sender, EventArgs e) => ValidatePasswordRequirements();
    private void OnChangePassword(object? sender, EventArgs e) => ChangePassword();

    private bool ValidatePasswordRequirements() {
        _view.EightLong = _view.NewPassword.Length >= 8;
        _view.UppercaseLowercase = _view.NewPassword.Any(char.IsUpper) && _view.NewPassword.Any(char.IsLower);
        _view.Number = _view.NewPassword.Any(char.IsDigit);
        _view.SpecialCharacter = _view.NewPassword.Any(c => !char.IsLetterOrDigit(c));

        if (_view.EightLong && _view.UppercaseLowercase && _view.Number && _view.SpecialCharacter) {
            _view.SetNewPasswordBorderError(false);
            return true;
        }

        _view.SetNewPasswordBorderError(true);
        return false;
    }

    private bool ValidatePasswordInputs() {
        bool newPasswordEmpty = _view.NewPassword.Length == 0;
        bool confirmPasswordEmpty = _view.ConfirmPassword.Length == 0;

        // Something is missing
        if (newPasswordEmpty || confirmPasswordEmpty) {
            _view.PasswordError = (newPasswordEmpty, confirmPasswordEmpty) switch {
                (true, true) => "New and confirm password are required",
                (true, false) => "New password is required",
                (false, true) => "Confirm password is required",
                _ => throw new NotImplementedException(),
            };
            return false;
        }

        // The new password does not meet the requirements
        if (!ValidatePasswordRequirements()) {
            _view.PasswordError = "Password does not satisfy the requirements";
            return false;
        }

        // Confirm password does not match
        if (_view.NewPassword != _view.ConfirmPassword) {
            _view.PasswordError = "Passwords did not match";
            return false;
        }

        _view.PasswordError = "";

        return true;
    }

    private async Task<bool> ValidateUsername() {
        bool usernameValid = _view.Username.Length != 0;

        _view.SetUsernameBorderError(!usernameValid);
        _view.UsernameError = usernameValid ? "" : "Fill in a username";

        if (!usernameValid) return false;

        Staff? staff = await StaffDAL.GetStaffByUsername(_view.Username);
        usernameValid = staff is not null;
        _view.SetUsernameBorderError(!usernameValid);
        _view.UsernameError = usernameValid ? "" : "The username does not exist";

        if (!usernameValid) return false;

        return true;
    }

    private async void ChangePassword() {
        if (!await ValidateUsername() || ValidatePasswordInputs()) {
            _view.ShowMessageBox("Invalid information. Could not save your changes.", "Save failed");
            return;
        }

        _view.IsLoading = true;

        try {

            Staff staff = (await StaffDAL.GetStaffByUsername(_view.Username))!;
            byte[] hash = CryptographyManager.GetHash(_view.NewPassword, out byte[] salt);

            if (await StaffDAL.UpdatePassword(staff.Id, Convert.ToHexString(hash), Convert.ToHexString(salt))) {
                if (staff.Id == _staff.Id) {
                    _staff.HashedPassword = hash;
                    _staff.Salt = salt;
                }

                _view.Reset();
                _view.IsLoading = false;
                _view.ShowMessageBox("Your changes have been successfully saved.", "Saved");
            }
            else {
                _view.IsLoading = false;
                _view.ShowMessageBox("Could not save your changes.", "Save failed");
            }
        }
        catch {
            _view.IsLoading = false;
            _view.ShowMessageBox("Could not save your changes.", "Save failed");
        }
    }

    public bool CanExit() => true;

    public override void CleanUp() {
        _view.UsernameChanged -= OnUsernameChanged;
        _view.NewPasswordChanged -= OnNewPasswordChanged;
        _view.ChangePassword -= OnChangePassword;

        base.CleanUp();
    }
}
