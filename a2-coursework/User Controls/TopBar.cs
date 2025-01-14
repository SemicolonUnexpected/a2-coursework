
using a2_coursework.Theming;

namespace a2_coursework.UserControls;
public partial class TopBar : UserControl {

    private int _height = 40;

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        pbLogo.BackColor = ColorScheme.CurrentTheme.Background;

        btnBack.BackColor = ColorScheme.CurrentTheme.Background;
        btnBack.ForeColor = ColorScheme.CurrentTheme.Foreground;
        btnBack.HoverColor = ColorScheme.CurrentTheme.Primary;
        btnBack.BackgroundImage = IconTheme.CurrentTheme.BackArrow;

        btnSettings.BackColor = ColorScheme.CurrentTheme.Background;
        btnSettings.ForeColor = ColorScheme.CurrentTheme.Foreground;
        btnSettings.HoverColor = ColorScheme.CurrentTheme.Primary;
        btnSettings.BackgroundImage = IconTheme.CurrentTheme.Settings;
    }

    public string UsernameText {
        get => lblUsername.Text;
        set {
            lblUsername.Width = TextRenderer.MeasureText(value, lblUsername.Font).Width;
            lblUsername.Text = value;
        }
    }

    public void HideBackButton() {
        btnBack.Hide();
    }

    public void ShowBackButton() {
        btnBack.Show();
    }

    public bool BackButtonVisible {
        get => btnBack.Visible;
        set => btnBack.Visible = value;
    }

    public void HideSettingsButton() {
        btnSettings.Hide();
    }

    public void ShowSettingsButton() {
        btnSettings.Show();
    }

    public bool SettingsButtonVisible {
        get => btnSettings.Visible;
        set => btnSettings.Visible = value;
    }

    private int _gap;
    public int Gap {
        get => _gap;
        set {
            _gap = value;
            OnResize(EventArgs.Empty);
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
