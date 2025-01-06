using a2_coursework.View.Interfaces;
using a2_coursework.Theming;

namespace a2_coursework.View;
public partial class LoginView : Form, ILoginView {
    const int PANEL_GRAPHICS_MARGIN = 10;

    public string Username {
        get => tbUsername.Text;
        set => tbUsername.Text = value;
    }

    public string Password {
        get => tbPassword.Text;
        set => tbPassword.Text = value;
    }
    public string ErrorText {
        get => lblError.Text;
        set => lblError.Text = value;
    }

    public LoginView() {
        InitializeComponent();

        Theme();
    }

    protected override void OnShown(EventArgs e) {
        // Have a cover to avoid the initial flicker
        pnlCover.BackColor = ColorScheme.CurrentTheme.Background;
        pnlCover.Hide();

        base.OnShown(e);
    }

    private void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        pnl.BackColor = ColorScheme.CurrentTheme.Background;
        pnl.BorderColor = ColorScheme.CurrentTheme.Primary;

        tbUsername.BackColor = ColorScheme.CurrentTheme.Background;
        tbUsername.ForeColor = ColorScheme.CurrentTheme.Foreground;
        tbUsername.BorderColor = ColorScheme.CurrentTheme.Primary;
        tbUsername.PlaceholderTextColor = ColorScheme.CurrentTheme.PrimaryForeground;

        tbPassword.BackColor = ColorScheme.CurrentTheme.Background;
        tbPassword.ForeColor = ColorScheme.CurrentTheme.Foreground;
        tbPassword.BorderColor = ColorScheme.CurrentTheme.Primary;
        tbPassword.PlaceholderTextColor = ColorScheme.CurrentTheme.PrimaryForeground;

        lblWelcome.BackColor = ColorScheme.CurrentTheme.Background;
        lblWelcome.ForeColor = ColorScheme.CurrentTheme.Foreground;

        lblSignIn.BackColor = ColorScheme.CurrentTheme.Background;
        lblSignIn.ForeColor = ColorScheme.CurrentTheme.PrimaryForeground;

        lblError.BackColor = ColorScheme.CurrentTheme.Background;
        lblError.ForeColor = ColorScheme.Red;

        btnSignIn.BackColor = ColorScheme.CurrentTheme.Foreground;
        btnSignIn.ForeColor = ColorScheme.CurrentTheme.Background;
        btnSignIn.HoverColor = ColorScheme.CurrentTheme.SecondaryForeground;

        btnSwitchTheme.BackColor = ColorScheme.CurrentTheme.Background;
        btnSwitchTheme.HoverColor = ColorScheme.CurrentTheme.Primary;
        btnSwitchTheme.BorderColor = ColorScheme.CurrentTheme.Primary;
        btnSwitchTheme.ClickedColor = ColorScheme.CurrentTheme.Primary;

        if (ColorScheme.CurrentTheme == ColorScheme.Dark) btnSwitchTheme.BackgroundImage = IconTheme.Brightness;
        else btnSwitchTheme.BackgroundImage = IconTheme.Moon;
    }

    public event EventHandler? AttemptSignIn;
    public event EventHandler? UsernameUpdated;
    public event EventHandler? PasswordUpdated;
    public event EventHandler? LoginAttempt;
    public event EventHandler? UsernameTextChanged;
    public event EventHandler? PasswordTextChanged;

    private void btnSignIn_Click(object sender, EventArgs e) => AttemptSignIn?.Invoke(sender, e);
    private void tbUsername_TextChanged(object sender, EventArgs e) => UsernameUpdated?.Invoke(sender, e);
    private void tbPassword_TextChanged(object sender, EventArgs e) => PasswordUpdated?.Invoke(sender, e);

    private void ClearFocus(object sender, EventArgs e) {
        tbFocusHolder.Focus();
    }

    protected override void OnMouseMove(MouseEventArgs e) {
        //lblWelcome.Text = tbUsername.Focused.ToString();
        base.OnMouseMove(e);
    }

    private void btnSwitchTheme_MouseDown(object sender, MouseEventArgs e) {
        ColorScheme.ToggleColourScheme();
        Theme();
        Invalidate();
    }
}
