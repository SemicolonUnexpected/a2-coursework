using a2_coursework.Model;
using a2_coursework.Presenter;
using a2_coursework.View;

namespace a2_coursework;
internal class ApplicationStartupManager {
    private SplashView? _splashView;
    private SplashPresenter? _splashPresenter;

    private LoginView? _loginView;
    private LoginPresenter? _loginPresenter;

    private MasterView? _masterView;
    private MasterPresenter? _masterPresenter;

    public async void StartApplicationAsync() {
        _splashView = new();
        _splashPresenter = new(_splashView);
        _splashPresenter.FormClosed += OnFormExit;

        _splashPresenter.Show();
        _splashPresenter.FinishedLoading += DisplayLogin;

        // Start the loading
        await _splashPresenter.ShowLoading();
    }

    private void DisplayLogin(object? sender, EventArgs e) {
        _loginView = new();
        _loginPresenter = new(_loginView);

        _loginPresenter.FormClosed += OnFormExit;
        _loginPresenter.LoginSuccessful += LoginSuccessful;

        _splashPresenter!.FormClosed -= OnFormExit;
        _splashPresenter.Close();

        _loginPresenter.Show();
    }

    // If the user closes any windows, ensure the application exits
    private void OnFormExit(object? sender, FormClosedEventArgs e) => Application.Exit();

    private void LoginSuccessful(object? sender, User user) {
        // Create the main page after a successful login
        _masterView = new();
        _masterPresenter = new(_masterView, user);

        // Clean up after a successful login
        _loginPresenter!.LoginSuccessful -= LoginSuccessful;
        _loginPresenter.FormClosed -= OnFormExit;
        _loginPresenter.Close();

        _masterPresenter.Show();
    }
}
