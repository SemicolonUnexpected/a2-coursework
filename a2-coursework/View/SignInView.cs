using a2_coursework._Helpers;
using a2_coursework.Interfaces.SignIn;
using a2_coursework.Theming;

namespace a2_coursework.View;
public partial class SignInView : Form, ISignInView, IThemeable {
    public event EventHandler? AttemptSignIn;
    public event EventHandler? UsernameChanged;
    public event EventHandler? PasswordChanged;

    public SignInView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.FontNameChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        btnSignIn.Click += (s, e) => AttemptSignIn?.Invoke(this, EventArgs.Empty);
        tbUsername.TextChanged += (s, e) => UsernameChanged?.Invoke(this, EventArgs.Empty);
        tbPassword.TextChanged += (s, e) => PasswordChanged?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        pnlCover.BackColor = ColorScheme.Current.Background;

        BackColor = ColorScheme.Current.Background;

        pbShowPassword.Image = tbPassword.UsePasswordChar ? IconTheme.Current.EyeCrossed : IconTheme.Current.Eye;
        toolTip.SetToolTip(pbShowPassword, tbPassword.UsePasswordChar ? "Show your password" : "Hide your password");

        pnl.Theme();

        tbUsername.Theme();
        tbPassword.Theme();

        lblWelcome.ThemeTitle();
        lblSignIn.ThemeSubtitle();
        lblError.ThemeError();

        btnSignIn.ThemeStrong();
        btnSwitchTheme.ThemeWeak();

        if (ColorScheme.Current == ColorScheme.Dark) btnSwitchTheme.Image = IconTheme.Brightness;
        else btnSwitchTheme.Image = IconTheme.Moon;
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        toolTip.Active = showToolTips;
        tbUsername.ToolTipsActive = showToolTips;
        tbPassword.ToolTipsActive = showToolTips;
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblWelcome.SetFontName(fontName);
        lblSignIn.SetFontName(fontName);
        tbUsername.SetFontName(fontName);
        tbPassword.SetFontName(fontName);
        lblError.SetFontName(fontName);
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
        if (e.KeyChar == (char)13) AttemptSignIn?.Invoke(this, EventArgs.Empty);
    }

    private void pbShowPassword_Click(object sender, EventArgs e) {
        tbPassword.UsePasswordChar = !tbPassword.UsePasswordChar;
        pbShowPassword.Image = tbPassword.UsePasswordChar ? IconTheme.Current.EyeCrossed : IconTheme.Current.Eye;
        toolTip.SetToolTip(pbShowPassword, tbPassword.UsePasswordChar ? "Show your password" : "Hide your password");
    }

    private void tbUsername_MouseHover(object sender, EventArgs e) {
        toolTip.Show("Type in your username", this);
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.FontNameChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
