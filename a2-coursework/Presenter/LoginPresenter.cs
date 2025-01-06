using a2_coursework.View.Interfaces;

namespace a2_coursework.Presenter; 
internal class LoginPresenter {
    private ILoginView _view;
 
    public void Show() => _view.Show();
    public void Close() => _view.Close();

    public event EventHandler? LoginSuccessful;
    public event FormClosedEventHandler? FormClosed;

    public LoginPresenter(ILoginView view) {
        _view = view;

        _view.LoginAttempt += LoginAttempt;
        _view.UsernameTextChanged += UsernameTextChanged;
        _view.PasswordTextChanged += PasswordTextChanged;

        _view.FormClosed += (s, e) => FormClosed?.Invoke(s, e);
    }

    private void LoginAttempt(object? sender, EventArgs e) {
         
    }

    private void UsernameTextChanged(object? sender, EventArgs e) {

    }

    private void PasswordTextChanged(object? sender, EventArgs e) {

    }

}
