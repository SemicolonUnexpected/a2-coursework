using a2_coursework._Helpers;
using a2_coursework.Interfaces.Staff.StaffManagement;
using a2_coursework.Theming;

namespace a2_coursework.View.Stock;
public partial class ManageStaffCredentialsView : Form, IThemeable, IManageStaffCredentialsView {
    public event EventHandler? UsernameChanged;
    public event EventHandler? PrivilegeLevelChanged;

    public ManageStaffCredentialsView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        tbUsername.TextChanged += (s, e) => UsernameChanged?.Invoke(this, EventArgs.Empty);
        cbPrivilegeLevel.SelectedIndexChanged += (s, e) => PrivilegeLevelChanged?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblPrivilegeLevel.ThemeTitle();
        lblSuggestedUsername.ThemeSubtitle();
        lblUsername.ThemeTitle();
        tbUsername.Theme();
        lblUsernameError.ThemeError();

        tbUsername.BorderColor = _usernameBorderError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        tbUsername.ToolTipsActive = showToolTips;
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblPrivilegeLevel.SetFontName(fontName);
        lblUsername.SetFontName(fontName);
        lblSuggestedUsername.SetFontName(fontName);
        tbUsername.SetFontName(fontName);
        lblUsernameError.SetFontName(fontName);
        cbPrivilegeLevel.SetFontName(fontName);
    }

    public string Username {
        get => tbUsername.Text;
        set => tbUsername.Text = value;
    }

    public string SuggestedUsername {
        set => lblSuggestedUsername.Text = $"Suggested username: {value}";
    }

    public string[] PrivilegeLevels {
        get => cbPrivilegeLevel.Items.Cast<string>().ToArray();
        set => cbPrivilegeLevel.Items.AddRange(value);
    }

    public string SelectedPrivilegeLevel {
        get => (string)cbPrivilegeLevel.SelectedItem!;
        set => cbPrivilegeLevel.SelectedItem = value;
    }

    public string UsernameError {
        set => lblUsernameError.Text = value;
    }

    private bool _usernameBorderError = false;
    public void SetUsernameBorderError(bool isError) {
        _usernameBorderError = isError;
        tbUsername.BorderColor = _usernameBorderError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
