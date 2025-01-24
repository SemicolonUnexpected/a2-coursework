using a2_coursework.View.Interfaces;
using System.Diagnostics;

namespace a2_coursework.Presenter;
public class SplashPresenter {
    private const int FRAME_DELAY = 1;
    private const int PROGRESS_PAUSE = 200;
    private ISplash _view;

    public event EventHandler? FinishedLoading;

    public SplashPresenter(ISplash view) {
        _view = view;
    }

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

        _view.Invoke(() => FinishedLoading?.Invoke(this , EventArgs.Empty));
    }
}
