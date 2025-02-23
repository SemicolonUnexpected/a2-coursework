using a2_coursework.Interfaces.SignIn;
using System.Diagnostics;

namespace a2_coursework.Presenter;
public class SplashPresenter : BasePresenter<ISplashView> {
    private const int FRAME_DELAY = 1;
    private const int PROGRESS_PAUSE = 200;

    public event EventHandler? FinishedLoading;
    public event EventHandler? FormClosed;

    public SplashPresenter(ISplashView view) : base(view) {
        _view.FormClosed += OnFormClosed;
    }

    private void OnFormClosed(object? sender, EventArgs e) => FormClosed?.Invoke(this, EventArgs.Empty);

    public async Task ShowLoading(int duration = 1000) {
        // Create the stopwatch and start it
        Stopwatch stopwatch = Stopwatch.StartNew();

        // Update the progress bar asynchronously to prevent the application freezing until the time has elapsed
        while (stopwatch.ElapsedMilliseconds <= duration) {
            await Task.Delay(FRAME_DELAY);

            // Clamp the value as the stopwatch continues ticking while this call is executed
            _view.Invoke(() => _view.Progress = Math.Min(1, (double)stopwatch.ElapsedMilliseconds / duration));
        }

        stopwatch.Stop();

        // Pause with the loading bar full
        await Task.Delay(PROGRESS_PAUSE);

        FinishedLoading?.Invoke(this, EventArgs.Empty);
    }

    public void Show() => _view.Show();
    public void Close() => _view.Close();

    public override void CleanUp() {
        _view.FormClosed -= OnFormClosed;

        base.CleanUp();
    }
}
