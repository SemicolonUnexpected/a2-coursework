using a2_coursework.View.Interfaces;
using System.Diagnostics;

namespace a2_coursework.View;
public partial class Splash : Form, ISplash {
    private const int FRAME_DELAY = 1;

    public Splash() {
        InitializeComponent();

        BackColor = ColourScheme.Current.PrimaryBackground;
        pnlProgress.BackColor = ColourScheme.Current.Primary;
    }


    // Load for the time in milliseconds
    public async Task StartLoading(int duration) {
        // Create the stopwatch and start it
        Stopwatch stopwatch = Stopwatch.StartNew();
        stopwatch.Start();

        // Update the progress bar asynchronously to prevent the application freezing until the time has elapsed
        while (stopwatch.ElapsedMilliseconds <= duration) {
            await Task.Delay(FRAME_DELAY);
            pnlProgress.Invoke(() => pnlProgress.Width = (int)stopwatch.ElapsedMilliseconds * Width / duration);
        }

        stopwatch.Stop();
    }
}
