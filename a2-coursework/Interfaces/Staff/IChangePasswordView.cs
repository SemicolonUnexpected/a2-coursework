using a2_coursework.Theming;

namespace a2_coursework.Interfaces.Staff;
public interface IChangePasswordView : IThemeable, IChildView {
    public event EventHandler? NewPasswordChanged;
    public event EventHandler? UsernameChanged;
    public event EventHandler? ChangePassword;

    public string Username { get; }
    public string NewPassword { get; }
    public string ConfirmPassword { get; }
    public void Reset();

    public void SetUsernameBorderError(bool isError);
    public void SetNewPasswordBorderError(bool isError);
    public void SetConfirmPasswordBorderError(bool isError);

    public bool EightLong { get; set; }
    public bool Number { get; set; }
    public bool SpecialCharacter { get; set; }
    public bool UppercaseLowercase { get; set; }

    public bool IsLoading { get; set; }

    public string PasswordError { set; }
    public string UsernameError { set; }

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK);
}
