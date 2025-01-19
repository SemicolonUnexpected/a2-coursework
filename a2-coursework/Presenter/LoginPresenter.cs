using a2_coursework.Model;
using a2_coursework.View.Interfaces;
using AS_Coursework.Model.Security;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace a2_coursework.Presenter;
internal class LoginPresenter {
    private ILoginView _view;

    public void Show() => _view.Show();
    public void Close() => _view.Close();

    public event EventHandler<string>? LoginSuccessful;
    public event FormClosedEventHandler? FormClosed;

    public LoginPresenter(ILoginView view) {
        _view = view;

        _view.LoginAttempt += LoginAttempt;
        _view.UsernameTextChanged += UsernameTextChanged;
        _view.PasswordTextChanged += PasswordTextChanged;

        _view.FormClosed += (s, e) => FormClosed?.Invoke(s, e);
    }

    private async void LoginAttempt(object? sender, EventArgs e) {
        _view.ButtonSignInEnabled = false;
        _view.TextBoxesEnabled = false;
        _view.ButtonSignInText = "Signing you in...";

        string username = _view.Username;
        string password = _view.Password;

        bool isUsernameEmpty = username.IsNullOrEmpty();
        bool isPasswordEmpty = password.IsNullOrEmpty();

        if (isUsernameEmpty && isPasswordEmpty) {
            _view.ErrorText = "Please fill in a username and password";
            _view.ButtonSignInEnabled = true;
            _view.TextBoxesEnabled = true;
            _view.ButtonSignInText = "Sign in";
            return;
        }

        if (isUsernameEmpty) {
            _view.Password = "";
            _view.ErrorText = "Please fill in a username and password";
            _view.ButtonSignInEnabled = true;
            _view.TextBoxesEnabled = true;
            _view.ButtonSignInText = "Sign in";
            return;
        }

        if (isPasswordEmpty) {
            _view.ErrorText = "Please fill in a password";
            _view.ButtonSignInEnabled = true;
            _view.TextBoxesEnabled = true;
            _view.ButtonSignInText = "Sign in";
            return;
        }

        byte[]? hash;
        byte[]? salt;

        try {
            Task<(byte[]?, byte[]?)> getUserData = DAL.GetUserCredentialsAsync(username);
            await Task.WhenAll(getUserData, Task.Delay(1500));

            (hash, salt) = await getUserData;

            if (hash is null || salt is null) {
                _view.Password = "";
                _view.ErrorText = "Username or password incorrect";
                _view.ButtonSignInEnabled = true;
                _view.TextBoxesEnabled = true;
                _view.ButtonSignInText = "Sign in";
                await DAL.LoginAttempt(username, DateTime.UtcNow, false);
                return;
            }

            if (CryptographyManager.VerifyHashEquality(password, hash!, salt!)) {
                LoginSuccessful?.Invoke(this, username);
                await DAL.LoginAttempt(username, DateTime.UtcNow, true);
            }
            else {
                _view.Password = "";
                _view.ErrorText = "Username or password incorrect";
                _view.ButtonSignInEnabled = true;
                _view.TextBoxesEnabled = true;
                _view.ButtonSignInText = "Sign in";
                await DAL.LoginAttempt(username, DateTime.UtcNow, false);
                return;
            }
        }
        catch (AggregateException ex) {
            foreach (Exception ex2 in ex.InnerExceptions) {
                if (ex2 is SqlException) MessageBox.Show($"Error connecting to database: {ex2.Message}");
            }

            _view.ButtonSignInEnabled = true;
            _view.TextBoxesEnabled = true;
            _view.ButtonSignInText = "Sign in";
        }
    }

    private void UsernameTextChanged(object? sender, EventArgs e) {
        if (!_view.Username.IsNullOrEmpty() && _view.ErrorText == "Please fill in a username and password") _view.ErrorText = "Please fill in a password";
        if (!_view.Username.IsNullOrEmpty() && _view.ErrorText == "Please fill in a username") _view.ErrorText = "";
        if (_view.ErrorText == "Username or password incorrect") _view.ErrorText = "";
    }

    private void PasswordTextChanged(object? sender, EventArgs e) {
        if (!_view.Password.IsNullOrEmpty() && _view.ErrorText == "Please fill in a password") _view.ErrorText = "";
        if (!_view.Password.IsNullOrEmpty() && _view.ErrorText == "Please fill in a username and password") _view.ErrorText = "Please fill in a username";
        if (_view.ErrorText == "Username or password incorrect") _view.ErrorText = "";
    }
}
