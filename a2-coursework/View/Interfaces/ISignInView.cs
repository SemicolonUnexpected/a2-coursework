using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces;

public interface ISignInView : IThemeable, IView {
    public event Action? AttemptSignIn;
    public event Action? UsernameChanged;
    public event Action? PasswordChanged;
    public event FormClosedEventHandler? FormClosed;

    public string Username { get; set; }
    public string Password { get; set; }
    public string ErrorText { get; set; }

    public bool Loading { set; }

    public void Show();
    public void Close();
}
