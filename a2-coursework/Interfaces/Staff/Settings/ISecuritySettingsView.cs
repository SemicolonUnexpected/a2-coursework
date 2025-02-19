namespace a2_coursework.Interfaces.Staff.Settings;
public interface ISecuritySettingsView : ISaveCancelView {
    public event EventHandler? NewPasswordChanged;

    public string Username { set; }
    public string PrivilegeLevel { set; }
    public string CurrentPassword { get; }
    public string NewPassword { get; }
    public string ConfirmPassword { get; }

    public void SetCurrentPasswordBorderError(bool isError);
    public void SetNewPasswordBorderError(bool isError);
    public void SetConfirmPasswordBorderError(bool isError);

    public bool EightLong { get; set; }
    public bool Number { get; set; }
    public bool SpecialCharacter { get; set; }
    public bool UppercaseLowercase { get; set; }

    public string PasswordError { set; }

    public void Reset();
}
