using a2_coursework._Helpers;
using a2_coursework.Presenter;
using a2_coursework.Theming;
using a2_coursework.View.Interfaces;

namespace a2_coursework.View;
public partial class LoginView : Form, ILogin {
    private LoginPresenter? _presenter;

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

    public bool TextBoxesEnabled {
        get => tbUsername.Enabled;
        set {
            tbUsername.Enabled = value;
            tbPassword.Enabled = value;
        }
    }

    public LoginView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += (s, e) => Theme();

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += (s, e) => SetToolTipVisibility();

        ControlHelpers.ExecuteRecursive(this, (ctrl) => ctrl.SetFontName(Theming.Theme.CurrentTheme.FontName));
        Theming.Theme.FontNameChanged += (s, e) => ControlHelpers.ExecuteRecursive(this, (ctrl) => ctrl.SetFontName(Theming.Theme.CurrentTheme.FontName));
    }

    public void SetPresenter(LoginPresenter presenter) {
        _presenter = presenter;
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

    private void LoginView_Shown(object sender, EventArgs e) {
        pnlCover.Hide();
    }

    private void btnSignIn_Click(object sender, EventArgs e) {
        _presenter?.LoginAttempt();
    }

    private void tbUsername_TextChanged(object sender, EventArgs e) {
        _presenter?.UsernameTextChanged();
    }

    private void tbPassword_TextChanged(object sender, EventArgs e) {
        _presenter?.PasswordTextChanged();
    }

    private void btnSwitchTheme_MouseClick(object sender, MouseEventArgs e) {
        Theming.Theme.ToggleTheme();
    }

    private void ClearFocus(object sender, EventArgs e) {
        tbFocusHolder.Focus();
    }

    private void tbPassword_KeyPress(object sender, KeyPressEventArgs e) {
        // If enter is pressed in the password box, attempt to sign in
        if (e.KeyChar == (char)13) _presenter?.LoginAttempt();
    }

    private void pbShowPassword_Click(object sender, EventArgs e) {
        tbPassword.UsePasswordChar = !tbPassword.UsePasswordChar;
        pbShowPassword.Image = tbPassword.UsePasswordChar ? IconTheme.CurrentTheme.EyeCrossed : IconTheme.CurrentTheme.Eye;
        toolTip.SetToolTip(pbShowPassword, tbPassword.UsePasswordChar ? "Show your password" : "Hide your password");
    }

    private void tbUsername_MouseHover(object sender, EventArgs e) {
        toolTip.Show("Type in your username", this);
    }
}
