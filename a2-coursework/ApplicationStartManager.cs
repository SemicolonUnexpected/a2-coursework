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
        (_splashView, _splashPresenter) = ViewFactory.CreateSplash();
        _splashView.FormClosed += OnFormExit;
        _splashView.Show();
        _splashPresenter.FinishedLoading += DisplayLogin;

        // Start the loading
        await _splashPresenter.ShowLoading();
    }

    private void DisplayLogin(object? sender, EventArgs e) {
        (_loginView, _loginPresenter) = ViewFactory.CreateLogin();

        _loginView.FormClosed += OnFormExit;
        _loginPresenter.LoginSuccessful += LoginSuccessful;

        _splashView!.FormClosed -= OnFormExit;
        _splashView.Close();

        _loginView.Show();
    }

    private void LoginSuccessful(object? sender, Staff staff) {
        // Create the main page after a successful login
        (_masterView, _masterPresenter) = ViewFactory.CreateMaster(staff);

        _masterView.FormClosed += OnFormExit;

        // Clean up after a successful login
        _loginPresenter!.LoginSuccessful -= LoginSuccessful;
        _loginView!.FormClosed -= OnFormExit;
        _loginView.Close();

        _masterView.Show();
    }

    // If the user closes any windows, ensure the application exits
    private void OnFormExit(object? sender, FormClosedEventArgs e) => Application.Exit();
}
