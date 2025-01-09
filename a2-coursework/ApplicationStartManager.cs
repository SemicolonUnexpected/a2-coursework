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

    public void StartApplication() {
        _splashView = new();
        _splashPresenter = new(_splashView);
        _splashPresenter.FormClosed += OnFormExit;

        _splashPresenter.Show();
        Task.Run(async () => {
            // Show loading screen while initialising forms, and wait for all of them to be done
            await Task.WhenAll(
                _splashPresenter.ShowLoading(),
                Task.Run(InitialiseLogin),
                Task.Run(InitialiseMaster)
                );

            // Close the splash form and open the login form when loading is complete
            _splashView.Invoke(() => {
                _splashPresenter.FormClosed -= OnFormExit;
                _splashPresenter.Close();

                _loginPresenter.Show();
            });
        });
    }

    private void InitialiseLogin() {
        _loginView = new();
        _loginPresenter = new(_loginView);
        _loginPresenter.FormClosed += OnFormExit;
        _loginPresenter.LoginSuccessful += LoginSuccessful;
    }

    private void InitialiseMaster() {
        _masterView = new();
        _masterPresenter = new(_masterView);
    }

    private void OnFormExit(object? sender, FormClosedEventArgs e) => Application.Exit();

    private void LoginSuccessful(object? sender, string username) {
        _loginPresenter!.LoginSuccessful -= LoginSuccessful;
        _loginPresenter.FormClosed -= OnFormExit;
        _loginPresenter.Close();

        _masterPresenter!.Show();
    }
}
