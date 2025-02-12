using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces.Users; 
public interface IChangePasswordView : IThemeable, IChildView {
    public string Username { get; }
    public string NewPassword { get; }
    public string ConfirmPassword { get; }

    public void SetUsernameBorderError(bool isError);
    public void SetNewPasswordBorderError(bool isError);
    public void SetConfirmPasswordBorderError(bool isError);

    public bool EightLong { get; set; }
    public bool Number { get; set; }
    public bool SpecialCharacter { get; set; }
    public bool UppercaseLowercase { get; set; }

    public bool IsLoading { get; set; }

    public string PasswordError { set; }

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK);
}
