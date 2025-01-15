
using a2_coursework.Theming;

namespace a2_coursework.UserControls;
public partial class TopBar : UserControl {

    private int _height = 40;

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        pbLogo.BackColor = ColorScheme.CurrentTheme.Background;

    }

    public string UsernameText {
        get => lblUsername.Text;
        set {
            lblUsername.Width = TextRenderer.MeasureText(value, lblUsername.Font).Width;
            lblUsername.Text = value;
        }
    }


    protected override void OnResize(EventArgs e) {
        Height = _height;
        base.OnResize(e);
    }

    public TopBar() {
        InitializeComponent();

        _height = (int)(_height * (DeviceDpi / 96f));
    }

    private void lblUsername_Click(object sender, EventArgs e) {

    }
}
