namespace a2_coursework.View.Interfaces; 

internal interface ILoginView {
    public void Show();
    public void Close();

    public event EventHandler? LoginAttempt;

    public string Username;
    public string Password;

    public event EventHandler? UsernameTextChanged;
    public event EventHandler? PasswordTextChanged;
    public string ErrorText;
}
