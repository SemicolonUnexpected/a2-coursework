using a2_coursework._Helpers;
using a2_coursework.CustomControls;
using a2_coursework.Presenter.Users.Settings;
using a2_coursework.Theming;
using a2_coursework.View.Interfaces.Users.Settings;

namespace a2_coursework.View.Settings;
public partial class SecuritySettingsView : Form, ISecuritySettings {
    public SecuritySettingsPresenter? _presenter;

    public event EventHandler? Save;
    public event EventHandler? Cancel;
    public event EventHandler? NewPasswordChanged;

    public SecuritySettingsView() {
        InitializeComponent();

        tbNewPassword.TextChanged += (s, e) => NewPasswordChanged?.Invoke(this, EventArgs.Empty);
        btnChangePassword.Click += (s, e) => Save?.Invoke(this, EventArgs.Empty);

        Theme();
        Theming.Theme.AppearanceThemeChanged += (s, e) => Theme();

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += (s, e) => SetToolTipVisibility();

        ControlHelpers.ExecuteRecursive(this, (ctrl) => ctrl.SetFontName(Theming.Theme.CurrentTheme.FontName));
        Theming.Theme.FontNameChanged += (s, e) => ControlHelpers.ExecuteRecursive(this, (ctrl) => ctrl.SetFontName(Theming.Theme.CurrentTheme.FontName));
    }

    public void SetPresenter(SecuritySettingsPresenter presenter) {
        _presenter = presenter;
    }

    public void Theme() {
        pbShowCurrentPassword.Image = tbCurrentPassword.UsePasswordChar ? IconTheme.CurrentTheme.EyeCrossed : IconTheme.CurrentTheme.Eye;
        pbShowNewPassword.Image = tbNewPassword.UsePasswordChar ? IconTheme.CurrentTheme.EyeCrossed : IconTheme.CurrentTheme.Eye;

        BackColor = ColorScheme.CurrentTheme.Background;

        lblSecurity.ThemeTitle();
        lblEditPromt.ThemeSubtitle();

        lblUsername.ThemeTitle();
        tbUsername.Theme();

        lblPrivilegeLevel.ThemeTitle();
        tbPrivilegeLevel.Theme();

        pnlChangePassword.Theme();
        lblChangePassword.ThemeTitle();

        lblCurrentPassword.ThemeTitle();
        tbCurrentPassword.Theme();
        lblNewPassword.ThemeTitle();
        tbNewPassword.Theme();
        lblConfirmPassword.ThemeTitle();
        tbConfirmPassword.Theme();

        pnlPasswordValidation.Theme();
        lblEightLong.ThemeSubtitle();
        lblUppercaseLowercase.ThemeSubtitle();
        lblSpecialCharacter.ThemeSubtitle();
        lblNumber.ThemeSubtitle();

        lblPasswordError.ThemeError();

        pbEightLong.Image = EightLong ? IconTheme.CurrentTheme.Tick : IconTheme.CurrentTheme.Cross;
        pbNumber.Image = Number ? IconTheme.CurrentTheme.Tick : IconTheme.CurrentTheme.Cross;
        pbSpecialCharacter.Image = SpecialCharacter ? IconTheme.CurrentTheme.Tick : IconTheme.CurrentTheme.Cross;
        pbUppercaseLowercase.Image = UppercaseLowercase ? IconTheme.CurrentTheme.Tick : IconTheme.CurrentTheme.Cross;

        btnChangePassword.ThemeStrong();

        sb.Theme();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.CurrentTheme.ShowToolTips;

        toolTip.Active = showToolTips;
        tbUsername.ToolTipsActive = showToolTips;
        tbPrivilegeLevel.ToolTipsActive = showToolTips;
        tbNewPassword.ToolTipsActive = showToolTips;
        tbCurrentPassword.ToolTipsActive = showToolTips;
        tbConfirmPassword.ToolTipsActive = showToolTips;
    }

    public bool SaveVisible { set { } }

    private bool _isLoading = false;
    public bool IsLoading {
        get => _isLoading;
        set {
            _isLoading = value;

            tbCurrentPassword.Enabled = !_isLoading;
            tbNewPassword.Enabled = !_isLoading;
            tbConfirmPassword.Enabled = !_isLoading;
            btnChangePassword.Text = _isLoading ? "Changing password..." : "Change password";
            btnChangePassword.Enabled = !_isLoading;
        }
    }

    public string Username {
        set => tbUsername.Text = value;
    }

    public string PrivilegeLevel {
        set => tbPrivilegeLevel.Text = value;
    }

    public string CurrentPassword => tbCurrentPassword.Text;

    public string NewPassword => tbNewPassword.Text;

    public string ConfirmPassword => tbConfirmPassword.Text;

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

    public void Reset() {
        tbCurrentPassword.Text = "";
        tbNewPassword.Text = "";
        tbConfirmPassword.Text = "";
    }

    private bool _currentPasswordError = false;
    public void SetCurrentPasswordBorderError(bool isError) {
        _currentPasswordError = isError;
        tbCurrentPassword.BorderColor = _currentPasswordError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
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

    private void pbShowCurrentPassword_Click(object sender, EventArgs e) {
        tbCurrentPassword.UsePasswordChar = !tbCurrentPassword.UsePasswordChar;
        pbShowCurrentPassword.Image = tbCurrentPassword.UsePasswordChar ? IconTheme.CurrentTheme.EyeCrossed : IconTheme.CurrentTheme.Eye;
        toolTip.SetToolTip(pbShowCurrentPassword, tbCurrentPassword.UsePasswordChar ? "Show your password" : "Hide your password");
    }

    private void pbShowNewPassword_Click(object sender, EventArgs e) {
        tbNewPassword.UsePasswordChar = !tbNewPassword.UsePasswordChar;
        pbShowNewPassword.Image = tbNewPassword.UsePasswordChar ? IconTheme.CurrentTheme.EyeCrossed : IconTheme.CurrentTheme.Eye;
        toolTip.SetToolTip(pbShowNewPassword, tbNewPassword.UsePasswordChar ? "Show your password" : "Hide your password");
    }
}
