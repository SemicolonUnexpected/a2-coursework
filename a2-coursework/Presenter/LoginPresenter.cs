using a2_coursework.Model;
using a2_coursework.View.Interfaces;
using AS_Coursework.Model.Security;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace a2_coursework.Presenter;
public class LoginPresenter {
    private ILogin _view;

    public event EventHandler<Staff>? LoginSuccessful;

    public LoginPresenter(ILogin view) {
        _view = view;
    }

    public async void LoginAttempt() {
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
            Task<(byte[]?, byte[]?)> getUserData = StaffDAL.GetStaffCredentials(username);
            await Task.WhenAll(getUserData, Task.Delay(1500));

            (hash, salt) = await getUserData;

            if (hash is null || salt is null) {
                _view.Password = "";
                _view.ErrorText = "Username or password incorrect";
                _view.ButtonSignInEnabled = true;
                _view.TextBoxesEnabled = true;
                _view.ButtonSignInText = "Sign in";
                await StaffDAL.LogLoginAttempt(username, DateTime.UtcNow, false);
                return;
            }

            if (CryptographyManager.VerifyHashEquality(password, hash!, salt!)) {
                LoginSuccessful?.Invoke(this, (await StaffDAL.GetStaff(username))!);
                await StaffDAL.LogLoginAttempt(username, DateTime.UtcNow, true);
            }
            else {
                _view.Password = "";
                _view.ErrorText = "Username or password incorrect";
                _view.ButtonSignInEnabled = true;
                _view.TextBoxesEnabled = true;
                _view.ButtonSignInText = "Sign in";
                await StaffDAL.LogLoginAttempt(username, DateTime.UtcNow, false);
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

    // Update the username error text when the text changes
    public void UsernameTextChanged() {
        if (!_view.Username.IsNullOrEmpty() && _view.ErrorText == "Please fill in a username and password") _view.ErrorText = "Please fill in a password";
        if (!_view.Username.IsNullOrEmpty() && _view.ErrorText == "Please fill in a username") _view.ErrorText = "";
        if (_view.ErrorText == "Username or password incorrect") _view.ErrorText = "";
    }

    // Update the password error text when the text changes
    public void PasswordTextChanged() {
        if (!_view.Password.IsNullOrEmpty() && _view.ErrorText == "Please fill in a password") _view.ErrorText = "";
        if (!_view.Password.IsNullOrEmpty() && _view.ErrorText == "Please fill in a username and password") _view.ErrorText = "Please fill in a username";
        if (_view.ErrorText == "Username or password incorrect") _view.ErrorText = "";
    }
}
