using a2_coursework.Theming;
using a2_coursework.View.Interfaces;

namespace a2_coursework.View;
public partial class SignInView : Form, ISignInView {
    public event Action? AttemptSignIn;
    public event Action? UsernameChanged;
    public event Action? PasswordChanged;

    public SignInView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;
        SetToolTipVisibility();

        btnSignIn.Click += (s, e) => AttemptSignIn?.Invoke();
        tbUsername.TextChanged += (s, e) => UsernameChanged?.Invoke();
        tbPassword.TextChanged += (s, e) => PasswordChanged?.Invoke();
    }

    public void Theme() {
        pnlCover.BackColor = ColorScheme.CurrentTheme.Background;

        BackColor = ColorScheme.CurrentTheme.Background;

        pbShowPassword.Image = tbPassword.UsePasswordChar ? IconTheme.CurrentTheme.EyeCrossed : IconTheme.CurrentTheme.Eye;
        toolTip.SetToolTip(pbShowPassword, tbPassword.UsePasswordChar ? "Show your password" : "Hide your password");

        pnl.Theme();

        tbUsername.Theme();
        tbPassword.Theme();

        lblWelcome.ThemeTitle();
        lblSignIn.ThemeSubtitle();
        lblError.ThemeError();

        btnSignIn.ThemeStrong();
        btnSwitchTheme.ThemeWeak();

        if (ColorScheme.CurrentTheme == ColorScheme.Dark) btnSwitchTheme.Image = IconTheme.Brightness;
        else btnSwitchTheme.Image = IconTheme.Moon;
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.CurrentTheme.ShowToolTips;

        toolTip.Active = showToolTips;
        tbUsername.ToolTipsActive = showToolTips;
        tbPassword.ToolTipsActive = showToolTips;
    }

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

    public bool Loading {
        set {
            bool _isLoading = value;

            btnSignIn.Text = _isLoading ? "Signing you in..." : "Sign in";
            btnSignIn.Enabled = !_isLoading;
            tbUsername.Enabled = !_isLoading;
            tbPassword.Enabled = !_isLoading;
        }
    }

    private void LoginView_Shown(object sender, EventArgs e) {
        pnlCover.Hide();
    }

    private void btnSwitchTheme_MouseClick(object sender, MouseEventArgs e) {
        Theming.Theme.ToggleTheme();
    }

    private void ClearFocus(object sender, EventArgs e) {
        tbFocusHolder.Focus();
    }

    private void tbPassword_KeyPress(object sender, KeyPressEventArgs e) {
        // If enter is pressed in the password box, attempt to sign in
        if (e.KeyChar == (char)13) AttemptSignIn?.Invoke();
    }

    private void pbShowPassword_Click(object sender, EventArgs e) {
        tbPassword.UsePasswordChar = !tbPassword.UsePasswordChar;
        pbShowPassword.Image = tbPassword.UsePasswordChar ? IconTheme.CurrentTheme.EyeCrossed : IconTheme.CurrentTheme.Eye;
        toolTip.SetToolTip(pbShowPassword, tbPassword.UsePasswordChar ? "Show your password" : "Hide your password");
    }

    private void tbUsername_MouseHover(object sender, EventArgs e) {
        toolTip.Show("Type in your username", this);
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
    }
}
