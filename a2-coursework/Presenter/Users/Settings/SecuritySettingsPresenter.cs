using a2_coursework.Model;
using a2_coursework.View.Interfaces.Users.Settings;
using AS_Coursework.Model.Security;

namespace a2_coursework.Presenter.Users.Settings;
public class SecuritySettingsPresenter : SettingsPresenter<ISecuritySettings> {
    private byte[]? _newHash;
    private byte[]? _newSalt;

    public SecuritySettingsPresenter(ISecuritySettings view, Staff staff) : base(view, staff) {
        _view.NewPasswordChanged += (s, e) => ValidatePassword();
    }

    private bool ValidatePassword() {
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

    protected override bool ValidateInputs() {
        bool currentPasswordEmpty = _view.CurrentPassword.Length == 0;
        bool newPasswordEmpty = _view.NewPassword.Length == 0;
        bool confirmPasswordEmpty = _view.ConfirmPassword.Length == 0;

        // Something is missing
        if (currentPasswordEmpty || newPasswordEmpty || confirmPasswordEmpty) {
            _view.PasswordError = (currentPasswordEmpty, newPasswordEmpty, confirmPasswordEmpty) switch {
                (true, true, true) => "All password fields are required",
                (true, false, false) => "Current password is required",
                (false, true, false) => "New password is required",
                (false, false, true) => "Confirm password is required",
                (true, true, false) => "Current and new password are required",
                (true, false, true) => "Current and confirm password are required",
                (false, true, true) => "New and confirm password are required",
                _ => throw new NotImplementedException(),
            };
            return false;
        }

        // The new password does not meet the requirements
        if (!ValidatePassword()) {
            _view.PasswordError = "Password does not satisfy the requirements";
            return false;
        }

        // The user has typed in their password incorrectly
        if (!CryptographyManager.VerifyHashEquality(_view.CurrentPassword, _staff.HashedPassword, _staff.Salt)) {
            _view.PasswordError = "Password incorrect";
            return false;
        }


        // The user put the same old password in
        if (CryptographyManager.VerifyHashEquality(_view.NewPassword, _staff.HashedPassword, _staff.Salt)) {
            _view.PasswordError = "Please pick a different password than the one you used last time";
            return false;
        }

        // Confirm password does not match
        if (_view.NewPassword != _view.ConfirmPassword) {
            _view.PasswordError = "Passwords did not match";
            return false;
        }

        _newHash = CryptographyManager.GetHash(_view.NewPassword, out _newSalt);

        _view.PasswordError = "";

        return true;
    }

    protected override bool AnyChanges() => _view.CurrentPassword.Length > 0 || _view.NewPassword.Length > 0 || _view.ConfirmPassword.Length > 0;

    protected override void PopulateDefaultValues() {
        _view.Username = _staff.Username;
        _view.PrivilegeLevel = _staff.PrivilegeLevel.ToString();
    }

    protected override Task<bool> UpdateDatabase() => StaffDAL.UpdatePassword(_staff.Id, Convert.ToHexString(_newHash!), Convert.ToHexString(_newSalt!));

    protected override void UpdateStaff() {
        _staff.HashedPassword = _newHash!;
        _staff.Salt = _newSalt!;

        _view.Reset();
    }
}
