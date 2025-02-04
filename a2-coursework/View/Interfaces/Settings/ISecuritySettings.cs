namespace a2_coursework.View.Interfaces.Settings; 
public interface ISecuritySettings : ISettingsView {
    public event EventHandler? NewPasswordChanged;

    public string Username { set; }
    public string JobTitle { set; }
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
}
