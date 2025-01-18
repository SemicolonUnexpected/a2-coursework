using a2_coursework.Theming;
using System.ComponentModel;

namespace a2_coursework.UserControls;
public partial class TopBar : UserControl {
    private readonly int _height;

    public TopBar() {
        InitializeComponent();

        // Set the height for the top bar - it is made a fixed height in the OnResize event
        _height = (int)(40 * DeviceDpi / 96f);
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        pbLogo.BackColor = ColorScheme.CurrentTheme.Background;

    }

    [DefaultValue("")]
    public string UsernameText {
        get => lblUsername.Text;
        set {
            lblUsername.Text = value;

            PositionUsernameText();
        }
    }

    protected override void OnResize(EventArgs e) {
        Height = _height;
        PositionUsernameText();

        base.OnResize(e);
    }

    private void PositionUsernameText() => lblUsername.Location = new Point(Width - (lblUsername.Width + pnlRight.Width), lblUsername.Location.Y);
}
