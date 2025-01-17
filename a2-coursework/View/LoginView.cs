using a2_coursework.Theming;
using a2_coursework.View.Interfaces;

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

    public string ButtonSignInText {
        get => btnSignIn.Text;
        set => btnSignIn.Text = value;
    }

    public bool ButtonSignInEnabled {
        get => btnSignIn.Enabled;
        set => btnSignIn.Enabled = value;
    }

    public LoginView() {
        InitializeComponent();
        pnlCover.BackColor = ColorScheme.CurrentTheme.Background;
        Theme();
    }

    private void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        pbShowPassword.Image = tbPassword.UsePasswordChar ? IconTheme.CurrentTheme.EyeCrossed : IconTheme.CurrentTheme.Eye;

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
        btnSignIn.DisabledColor = ColorScheme.CurrentTheme.SecondaryForeground;

        btnSwitchTheme.BackColor = ColorScheme.CurrentTheme.Background;
        btnSwitchTheme.HoverColor = ColorScheme.CurrentTheme.Primary;
        btnSwitchTheme.BorderColor = ColorScheme.CurrentTheme.Primary;
        btnSwitchTheme.ClickedColor = ColorScheme.CurrentTheme.Primary;

        if (ColorScheme.CurrentTheme == ColorScheme.Dark) btnSwitchTheme.Image = IconTheme.Brightness;
        else btnSwitchTheme.Image = IconTheme.Moon;
    }

    public event EventHandler? LoginAttempt;
    public event EventHandler? UsernameTextChanged;
    public event EventHandler? PasswordTextChanged;

    private void btnSignIn_Click(object sender, EventArgs e) => LoginAttempt?.Invoke(sender, e);
    private void tbUsername_TextChanged(object sender, EventArgs e) => UsernameTextChanged?.Invoke(sender, e);
    private void tbPassword_TextChanged(object sender, EventArgs e) => PasswordTextChanged?.Invoke(sender, e);

    protected override void OnMouseMove(MouseEventArgs e) {
        base.OnMouseMove(e);
    }

    protected override void OnShown(EventArgs e) {
        base.OnShown(e);
        pnlCover.Hide();
    }

    private void btnSwitchTheme_MouseClick(object sender, MouseEventArgs e) {
        ColorScheme.ToggleColourScheme();
        Theme();
        Invalidate();
    }

    private void ClearFocus(object sender, EventArgs e) {
        tbFocusHolder.Focus();
    }

    private void tbPassword_KeyPress(object sender, KeyPressEventArgs e) {
        // If enter is pressed in the password box, attempt to sign in
        if (e.KeyChar == (char)13) LoginAttempt?.Invoke(sender, e);
    }

    private void pbShowPassword_Click(object sender, EventArgs e) {
        tbPassword.UsePasswordChar = !tbPassword.UsePasswordChar;
        pbShowPassword.Image = tbPassword.UsePasswordChar ? IconTheme.CurrentTheme.EyeCrossed : IconTheme.CurrentTheme.Eye;
    }
}
