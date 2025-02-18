namespace a2_coursework.Interfaces;

public interface ISignInView : IView {
    public event EventHandler? AttemptSignIn;
    public event EventHandler? UsernameChanged;
    public event EventHandler? PasswordChanged;
    public event FormClosedEventHandler? FormClosed;

    public string Username { get; set; }
    public string Password { get; set; }
    public string ErrorText { get; set; }

    public bool Loading { set; }

    public void Show();
    public void Close();
}
