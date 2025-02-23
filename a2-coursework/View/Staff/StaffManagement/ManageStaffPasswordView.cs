using a2_coursework._Helpers;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Staff.StaffManagement;
using a2_coursework.Theming;

namespace a2_coursework.View.Staff.StaffManagement;
public partial class ManageStaffPasswordView : Form, IManageStaffPasswordView, IChildView, IThemeable {
    public event EventHandler? PasswordChanged;
    public event EventHandler? ConfirmPasswordChanged;

    public ManageStaffPasswordView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        tbPassword.TextChanged += (s, e) => PasswordChanged?.Invoke(this, EventArgs.Empty);
        tbConfirmPassword.TextChanged += (s, e) => PasswordChanged?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblPassword.ThemeTitle();
        tbPassword.Theme();
        pbShowPassword.Image = tbPassword.UsePasswordChar ? IconTheme.Current.EyeCrossed : IconTheme.Current.Eye;
        pnlPasswordValidation.Theme();
        pbEightLong.Image = EightLong ? IconTheme.Current.Tick : IconTheme.Current.Cross;
        pbNumber.Image = Number ? IconTheme.Current.Tick : IconTheme.Current.Cross;
        pbSpecialCharacter.Image = SpecialCharacter ? IconTheme.Current.Tick : IconTheme.Current.Cross;
        pbUppercaseLowercase.Image = UppercaseLowercase ? IconTheme.Current.Tick : IconTheme.Current.Cross;
        lblEightLong.ThemeSubtitle();
        lblUppercaseLowercase.ThemeSubtitle();
        lblSpecialCharacter.ThemeSubtitle();
        lblNumber.ThemeSubtitle();
        lblConfirmPassword.ThemeTitle();
        tbConfirmPassword.Theme();
        lblPasswordError.ThemeError();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        toolTip.Active = showToolTips;
        tbPassword.ToolTipsActive = showToolTips;
        tbConfirmPassword.ToolTipsActive = showToolTips;
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblPassword.SetFontName(fontName);
        tbPassword.SetFontName(fontName);
        pnlPasswordValidation.SetFontName(fontName);
        lblEightLong.SetFontName(fontName);
        lblUppercaseLowercase.SetFontName(fontName);
        lblSpecialCharacter.SetFontName(fontName);
        lblNumber.SetFontName(fontName);
        lblConfirmPassword.SetFontName(fontName);
        tbConfirmPassword.SetFontName(fontName);
        lblPasswordError.SetFontName(fontName);
    }

    public string Password {
        get => tbPassword.Text;
        set => tbPassword.Text = value;
    }

    public string ConfirmPassword {
        get => tbConfirmPassword.Text;
        set => tbConfirmPassword.Text = value;
    }

    private bool _eightLong;
    public bool EightLong {
        get => _eightLong;
        set {
            _eightLong = value;
            pbEightLong.Image = value ? IconTheme.Current.Tick : IconTheme.Current.Cross;
        }
    }

    private bool _number;
    public bool Number {
        get => _number;
        set {
            _number = value;
            pbNumber.Image = value ? IconTheme.Current.Tick : IconTheme.Current.Cross;
        }
    }

    private bool _specialCharacter;
    public bool SpecialCharacter {
        get => _specialCharacter;
        set {
            _specialCharacter = value;
            pbSpecialCharacter.Image = value ? IconTheme.Current.Tick : IconTheme.Current.Cross;
        }
    }

    private bool _uppercaseLowercase;
    public bool UppercaseLowercase {
        get => _uppercaseLowercase;
        set {
            _uppercaseLowercase = value;
            pbUppercaseLowercase.Image = value ? IconTheme.Current.Tick : IconTheme.Current.Cross;
        }
    }

    public string PasswordError {
        set => lblPasswordError.Text = value;
    }

    private bool _passwordError = false;
    public void SetPasswordBorderError(bool isError) {
        _passwordError = isError;
        tbPassword.BorderColor = _passwordError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    private bool _confirmPasswordError = false;
    public void SetConfirmPasswordBorderError(bool isError) {
        _confirmPasswordError = isError;
        tbConfirmPassword.BorderColor = _confirmPasswordError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    private void pbShowPassword_Click(object sender, EventArgs e) {
        tbPassword.UsePasswordChar = !tbPassword.UsePasswordChar;
        pbShowPassword.Image = tbPassword.UsePasswordChar ? IconTheme.Current.EyeCrossed : IconTheme.Current.Eye;
        toolTip.SetToolTip(pbShowPassword, tbPassword.UsePasswordChar ? "Show your password" : "Hide your password");
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
