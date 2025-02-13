using a2_coursework.Model;
using a2_coursework.Presenter;
using a2_coursework.View;

namespace a2_coursework;
internal class ApplicationStartupManager {
    private SplashPresenter? _splashPresenter;

    private SignInPresenter? _signInPresenter;

    private MasterPresenter? _masterPresenter;

    public async void StartApplicationAsync() {
        _splashPresenter = ViewFactory.CreateSplash().presenter;
        _splashPresenter.FormClosed += OnFormExit;
        _splashPresenter.Show();
        _splashPresenter.FinishedLoading += DisplaySignIn;

        // Start the loading
        await _splashPresenter.ShowLoading();
    }

    private void DisplaySignIn(object? sender, EventArgs e) {
        _signInPresenter = ViewFactory.CreateSignIn().presenter;

        _signInPresenter.FormClosed += OnFormExit;
        _signInPresenter.SignInSuccessful += SignInSuccessful;

        _splashPresenter!.FormClosed -= OnFormExit;
        _splashPresenter.Close();
        _splashPresenter.CleanUp();
        _splashPresenter = null; // Clear the splash from memory

        _signInPresenter.Show();
    }

    private void SignInSuccessful(object? sender, Staff staff) {
        // Create the main page after a successful login
        _masterPresenter = ViewFactory.CreateMaster(staff).presenter;

        //_masterView.FormClosed += OnFormExit;

        // Clean up after a successful login
        _signInPresenter!.SignInSuccessful -= SignInSuccessful;
        _signInPresenter.FormClosed -= OnFormExit;
        _signInPresenter.Close();
        _signInPresenter.CleanUp();
        _signInPresenter = null;

        _masterPresenter.Show();
    }

    // If the user closes any windows, ensure the application exits
    private void OnFormExit() => Application.Exit();
}
