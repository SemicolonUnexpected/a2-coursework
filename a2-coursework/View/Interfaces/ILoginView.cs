namespace a2_coursework.View.Interfaces; 
internal interface ILoginView {
    public event FormClosedEventHandler? FormClosed;
    public void Show();
    public event EventHandler? AttemptSignIn;
    public event EventHandler? UsernameUpdated;
    public event EventHandler? PasswordUpdated;
    public string ErrorText { get; set; }
}