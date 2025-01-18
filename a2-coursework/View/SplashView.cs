using a2_coursework.Theming;
using a2_coursework.View.Interfaces;

namespace a2_coursework.View;

public partial class SplashView : Form, ISplash {
    public SplashView() {
        InitializeComponent();

        // Initialise colours
        BackColor = ColorScheme.CurrentTheme.Background;
        pnlProgress.BackColor = ColorScheme.CurrentTheme.Foreground;
    }

    /// <summary>
    /// The current displayed progress as a value between 0 and 1
    /// </summary>
    public double Progress {
        get {
            return (double)pnlProgress.Width / Width;
        }
        set {
            if (value < 0 || value > 1) throw new ArgumentOutOfRangeException("Progress must be between 0 and 1", nameof(Progress));
            pnlProgress.Width = (int)(Width * value);
        }
    }
}
