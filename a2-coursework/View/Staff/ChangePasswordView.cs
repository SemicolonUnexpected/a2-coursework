using a2_coursework._Helpers;
using a2_coursework.CustomControls;
using a2_coursework.Interfaces.Users;
using a2_coursework.Presenter.Users;
using a2_coursework.Theming;

namespace a2_coursework.View.Users;
public partial class ChangePasswordView : Form, IChangePasswordView {
    private ChangePasswordPresenter? _presenter;

    public event EventHandler? UsernameChanged;
    public event EventHandler? NewPasswordChanged;
    public event EventHandler? ChangePassword;

    public ChangePasswordView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        tbUsername.TextChanged += (s, e) => UsernameChanged?.Invoke(this, EventArgs.Empty);
        tbNewPassword.TextChanged += (s, e) => NewPasswordChanged?.Invoke(this, EventArgs.Empty);
        btnChangePassword.Click += (s, e) => ChangePassword?.Invoke(this, EventArgs.Empty);
    }

    public void SetPresenter(ChangePasswordPresenter presenter) => _presenter = presenter;

    public void Theme() {
        pbShowNewPassword.Image = tbNewPassword.UsePasswordChar ? IconTheme.CurrentTheme.EyeCrossed : IconTheme.CurrentTheme.Eye;

        BackColor = ColorScheme.CurrentTheme.Background;

        lblChangePassword.ThemeTitle();
        lblEditPromt.ThemeSubtitle();

        lblUsername.ThemeTitle();
        tbUsername.Theme();

        pnlChangePassword.Theme();
        lblChangePassword.ThemeTitle();

        lblUsername.ThemeTitle();
        tbUsername.Theme();
        lblNewPassword.ThemeTitle();
        tbNewPassword.Theme();
        lblConfirmPassword.ThemeTitle();
        tbConfirmPassword.Theme();

        pnlPasswordValidation.Theme();
        lblEightLong.ThemeSubtitle();
        lblUppercaseLowercase.ThemeSubtitle();
        lblSpecialCharacter.ThemeSubtitle();
        lblNumber.ThemeSubtitle();

        pbEightLong.Image = EightLong ? IconTheme.CurrentTheme.Tick : IconTheme.CurrentTheme.Cross;
        pbNumber.Image = Number ? IconTheme.CurrentTheme.Tick : IconTheme.CurrentTheme.Cross;
        pbSpecialCharacter.Image = SpecialCharacter ? IconTheme.CurrentTheme.Tick : IconTheme.CurrentTheme.Cross;
        pbUppercaseLowercase.Image = UppercaseLowercase ? IconTheme.CurrentTheme.Tick : IconTheme.CurrentTheme.Cross;

        btnChangePassword.ThemeStrong();

        lblPasswordError.ThemeError();
        lblUsernameError.ThemeError();

        sb.Theme();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.CurrentTheme.ShowToolTips;

        toolTip.Active = showToolTips;
        tbUsername.ToolTipsActive = showToolTips;
        tbNewPassword.ToolTipsActive = showToolTips;
        tbUsername.ToolTipsActive = showToolTips;
        tbConfirmPassword.ToolTipsActive = showToolTips;
    }

    public void SetFont() {
        string fontName = Theming.Theme.CurrentTheme.FontName;

        lblChangePassword.SetFontName(fontName);
        lblEditPromt.SetFontName(fontName);
        lblUsername.SetFontName(fontName);
        tbUsername.SetFontName(fontName);
        lblUsernameError.SetFontName(fontName);
        lblNewPassword.SetFontName(fontName);
        tbNewPassword.SetFontName(fontName);
        lblEightLong.SetFontName(fontName);
        lblUppercaseLowercase.SetFontName(fontName);
        lblNumber.SetFontName(fontName);
        lblSpecialCharacter.SetFontName(fontName);
        lblConfirmPassword.SetFontName(fontName);
        tbConfirmPassword.SetFontName(fontName);
        lblPasswordError.SetFontName(fontName);
        btnChangePassword.SetFontName(fontName);
    }

    private bool _isLoading = false;
    public bool IsLoading {
        get => _isLoading;
        set {
            _isLoading = value;

            tbUsername.Enabled = !_isLoading;
            tbNewPassword.Enabled = !_isLoading;
            tbConfirmPassword.Enabled = !_isLoading;
            btnChangePassword.Text = _isLoading ? "Changing password..." : "Change password";
            btnChangePassword.Enabled = !_isLoading;
        }
    }

    public string Username => tbUsername.Text;

    public string NewPassword => tbNewPassword.Text;

    public string ConfirmPassword => tbConfirmPassword.Text;

    public void Reset() {
        tbUsername.Text = "";
        tbNewPassword.Text = "";
        tbConfirmPassword.Text = "";
    }

    private bool _eightLong;
    public bool EightLong {
        get => _eightLong;
        set {
            _eightLong = value;
            pbEightLong.Image = value ? IconTheme.CurrentTheme.Tick : IconTheme.CurrentTheme.Cross;
        }
    }

    private bool _number;
    public bool Number {
        get => _number;
        set {
            _number = value;
            pbNumber.Image = value ? IconTheme.CurrentTheme.Tick : IconTheme.CurrentTheme.Cross;
        }
    }

    private bool _specialCharacter;
    public bool SpecialCharacter {
        get => _specialCharacter;
        set {
            _specialCharacter = value;
            pbSpecialCharacter.Image = value ? IconTheme.CurrentTheme.Tick : IconTheme.CurrentTheme.Cross;
        }
    }

    private bool _uppercaseLowercase;
    public bool UppercaseLowercase {
        get => _uppercaseLowercase;
        set {
            _uppercaseLowercase = value;
            pbUppercaseLowercase.Image = value ? IconTheme.CurrentTheme.Tick : IconTheme.CurrentTheme.Cross;
        }
    }

    public string PasswordError {
        set => lblPasswordError.Text = value;
    }

    public string UsernameError {
        set => lblUsernameError.Text = value;
    }

    private bool _usernameError = false;
    public void SetUsernameBorderError(bool isError) {
        _usernameError = isError;
        tbUsername.BorderColor = _usernameError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
    }

    private bool _newPasswordError = false;
    public void SetNewPasswordBorderError(bool isError) {
        _newPasswordError = isError;
        tbNewPassword.BorderColor = _newPasswordError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
    }

    private bool _confirmPasswordError = false;
    public void SetConfirmPasswordBorderError(bool isError) {
        _confirmPasswordError = isError;
        tbConfirmPassword.BorderColor = _confirmPasswordError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
    }

    #region Scrolling

    private void SetScrollOptions() {
        if (pnlHolder is null) return;

        if (Height < pnlHolder.Height) {
            sb.Visible = true;
            sb.LargeChange = Height;
            sb.Maximum = pnlHolder.Height - Height;
        }
        else {
            sb.Visible = false;
            sb.Value = 0;
        }
    }

    protected override void OnMouseWheel(MouseEventArgs e) {
        base.OnMouseWheel(e);

        if (Height < pnlHolder.Height) sb.Value -= e.Delta;
        Update();
    }

    private void sb_ValueChanged(object sender, EventArgs e) {
        if (pnlHolder is null) return;

        if (Height < pnlHolder.Height) pnlHolder.Location = new Point(pnlHolder.Location.X, -sb.Value);
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);
        SetScrollOptions();

        if (Height < pnlHolder.Height) {
            pnlHolder.Location = new Point(pnlHolder.Location.X, -sb.Value);
        }
        else {
            pnlHolder.Location = new(pnlHolder.Location.X, (Height - pnlHolder.Height) / 2);
        }
    }

    #endregion

    public bool DockInParent => true;

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK) {
        return CustomMessageBox.Show(text, caption, buttons);
    }

    public bool CanExit() => _presenter?.CanExit() ?? true;

    private void pbShowNewPassword_Click(object sender, EventArgs e) {
        tbNewPassword.UsePasswordChar = !tbNewPassword.UsePasswordChar;
        pbShowNewPassword.Image = tbNewPassword.UsePasswordChar ? IconTheme.CurrentTheme.EyeCrossed : IconTheme.CurrentTheme.Eye;
        toolTip.SetToolTip(pbShowNewPassword, tbNewPassword.UsePasswordChar ? "Show the password" : "Hide the password");
    }

    public void CleanUp() {
        throw new NotImplementedException();
    }
}
