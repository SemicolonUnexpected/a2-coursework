using a2_coursework.Model;
using a2_coursework.View.Interfaces;
using AS_Coursework.Model.Security;
using Microsoft.IdentityModel.Tokens;
using System.Security;

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
        bool isUsernameEmpty = _view.Username.IsNullOrEmpty();
        bool isPasswordEmpty = _view.Username.IsNullOrEmpty();

        if (isUsernameEmpty && isPasswordEmpty) {
            _view.ErrorText = "Please fill in a username and password";
            return;
        }

        if (isUsernameEmpty) {
            _view.ErrorText = "Please fill in a username and password";
            _view.Password = "";
        }

        if (isPasswordEmpty) {
            _view.ErrorText = "Please fill in a password";
            return;
        }

        //bool userExits = DAL.GetUserCredentials(_view.Username, out byte[] hash, out byte[] salt);

        //CryptographyManager.VerifyHashEquality(_view.Password, hash, salt);
    }

    private void UsernameTextChanged(object? sender, EventArgs e) {
        if (!_view.Username.IsNullOrEmpty() && _view.ErrorText ==  "Please fill in a username and password") _view.ErrorText = "Please fill in a password";
        if (!_view.Username.IsNullOrEmpty() && _view.ErrorText == "Please fill in a username") _view.ErrorText = "";
    }

    private void PasswordTextChanged(object? sender, EventArgs e) {
        if (!_view.Password.IsNullOrEmpty() && _view.ErrorText == "Please fill in a password") _view.ErrorText = "";
        if (!_view.Password.IsNullOrEmpty() && _view.ErrorText == "Please fill in a username and password") _view.ErrorText = "Please fill in a username";
    }

}
