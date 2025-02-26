using a2_coursework.Interfaces.SignIn;
using a2_coursework.Model.LoginAttempt;
using a2_coursework.Model.Security;
using a2_coursework.Model.Staff;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace a2_coursework.Presenter.SignIn;
public class SignInPresenter : BasePresenter<ISignInView>
{
    public event EventHandler<StaffModel>? SignInSuccessful;
    public event EventHandler? FormClosed;

    public SignInPresenter(ISignInView view) : base(view)
    {
        _view.AttemptSignIn += OnAttemptSignIn;
        _view.UsernameChanged += OnUsernameChanged;
        _view.PasswordChanged += OnPasswordChanged;
        _view.FormClosed += OnFormClosed;
    }

    private void OnAttemptSignIn(object? sender, EventArgs e) => AttemptSignIn();
    private void OnUsernameChanged(object? sender, EventArgs e) => UsernameChanged();
    private void OnPasswordChanged(object? sender, EventArgs e) => PasswordChanged();
    private void OnFormClosed(object? sender, EventArgs e) => FormClosed?.Invoke(this, EventArgs.Empty);

    private async void AttemptSignIn()
    {
        string username = _view.Username;
        string password = _view.Password;

        bool isUsernameEmpty = username.IsNullOrEmpty();
        bool isPasswordEmpty = password.IsNullOrEmpty();

        if (isUsernameEmpty && isPasswordEmpty)
        {
            _view.ErrorText = "Please fill in a username and password";
            return;
        }

        if (isUsernameEmpty)
        {
            _view.Password = "";
            _view.ErrorText = "Please fill in a username and password";
            return;
        }

        if (isPasswordEmpty)
        {
            _view.ErrorText = "Please fill in a password";
            return;
        }

        _view.Loading = true;

        try
        {
            Task<(byte[]?, byte[]?)> getUserData = StaffDAL.GetStaffCredentials(username);
            await Task.WhenAll(getUserData, Task.Delay(1000));

            (byte[]? hash, byte[]? salt) = await getUserData;

            if (hash is null || salt is null)
            {
                SignInError();
                await LoginAttemptDAL.LogLoginAttempt(username, DateTime.UtcNow, false);
                return;
            }

            if (CryptographyManager.VerifyHashEquality(password, hash!, salt!))
            {
                SignInSuccessful?.Invoke(this, (await StaffDAL.GetStaffByUsername(username))!);
                await LoginAttemptDAL.LogLoginAttempt(username, DateTime.UtcNow, true);
            }
            else
            {
                SignInError();
                await LoginAttemptDAL.LogLoginAttempt(username, DateTime.UtcNow, false);
                return;
            }
        }
        catch (AggregateException ex)
        {
            foreach (Exception ex2 in ex.InnerExceptions)
            {
                if (ex2 is SqlException) MessageBox.Show($"Error connecting to database: {ex2.Message}");
            }
        }
        finally
        {
            _view.Loading = false;
        }
    }

    private void SignInError()
    {
        _view.Password = "";
        _view.ErrorText = "Username or password incorrect";
        _view.Loading = false;
    }

    // Update the username error text when the text changes
    private void UsernameChanged()
    {
        if (!_view.Username.IsNullOrEmpty() && _view.ErrorText == "Please fill in a username and password") _view.ErrorText = "Please fill in a password";
        if (!_view.Username.IsNullOrEmpty() && _view.ErrorText == "Please fill in a username") _view.ErrorText = "";
        if (_view.ErrorText == "Username or password incorrect") _view.ErrorText = "";
    }

    // Update the password error text when the text changes
    private void PasswordChanged()
    {
        if (!_view.Password.IsNullOrEmpty() && _view.ErrorText == "Please fill in a password") _view.ErrorText = "";
        if (!_view.Password.IsNullOrEmpty() && _view.ErrorText == "Please fill in a username and password") _view.ErrorText = "Please fill in a username";
        if (_view.ErrorText == "Username or password incorrect") _view.ErrorText = "";
    }

    public void Show() => _view.Show();
    public void Close() => _view.Close();

    public override void CleanUp()
    {
        _view.AttemptSignIn -= OnAttemptSignIn;
        _view.UsernameChanged -= OnUsernameChanged;
        _view.PasswordChanged -= OnPasswordChanged;
        _view.FormClosed -= OnFormClosed;

        base.CleanUp();
    }
}
