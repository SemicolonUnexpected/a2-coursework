namespace a2_coursework.View.Interfaces;

internal interface ILogin {
    public void Show();
    public void Close();

    public event EventHandler? LoginAttempt;

    public string Username { get; set; }
    public string Password { get; set; }

    public event EventHandler? UsernameTextChanged;
    public event EventHandler? PasswordTextChanged;

    public event FormClosedEventHandler? FormClosed;
    public string ErrorText { get; set; }
    public string ButtonSignInText { get; set; }
    public bool ButtonSignInEnabled { get; set; }
    public bool TextBoxesEnabled { get; set; }
}
