using a2_coursework._Helpers;
using a2_coursework.Theming;
using System.ComponentModel;

namespace a2_coursework.UserControls;
public partial class TopBar : UserControl {
    private readonly int _height;

    public event EventHandler? SignOut;

    public TopBar() {
        InitializeComponent();

        // Set the height for the top bar - it is made a fixed height in the OnResize event
        _height = (int)(40 * DeviceDpi / 96f);
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;
        lblUsername.ForeColor = ColorScheme.CurrentTheme.Foreground;
        pnlDecor.BackColor = ColorScheme.CurrentTheme.Primary;

        btnSignOut.ThemeStrong();
    }

    [DefaultValue("")]
    public string UsernameText {
        get => lblUsername.Text;
        set {
            lblUsername.Text = value;
        }
    }

    protected override void OnResize(EventArgs e) {
        Height = _height;

        base.OnResize(e);
    }

    protected override void OnFontChanged(EventArgs e) {
        base.OnFontChanged(e);

        lblUsername.SetFontName(Font.Name);
    }

    private void btnLogOut_Click(object sender, EventArgs e) {
        SignOut?.Invoke(this, EventArgs.Empty);
    }
}
