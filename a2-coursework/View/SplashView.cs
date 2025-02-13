using a2_coursework.Theming;
using a2_coursework.View.Interfaces;

namespace a2_coursework.View;

public partial class SplashView : Form, ISplashView, IThemeable {
    public SplashView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        pnlProgress.BackColor = ColorScheme.CurrentTheme.Foreground;
    }

    public void SetToolTipVisibility() { }

    public void SetFont() { }

    /// <summary>
    /// The current displayed progress as a value between 0 and 1
    /// </summary>
    public double Progress {
        get {
            return (double)pnlProgress.Width / Width;
        }
        set {
            if (value < 0 || value > 1) throw new ArgumentOutOfRangeException(nameof(Progress), "Progress must be between 0 and 1");
            pnlProgress.Width = (int)(Width * value);
        }
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
    }
}
