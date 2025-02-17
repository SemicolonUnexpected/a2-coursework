using a2_coursework._Helpers;
using a2_coursework.CustomControls;
using a2_coursework.Interfaces.Users.Settings;
using a2_coursework.Theming;

namespace a2_coursework.View.Settings;
public partial class EmergencyContactSettingsView : Form, IEmergencyContactSettings, IThemeable {
    public event EventHandler? EmergencyContactForenameChanged;
    public event EventHandler? EmergencyContactSurnameChanged;
    public event EventHandler? EmergencyContactPhoneNumberChanged;
    public event EventHandler? Save;
    public event EventHandler? Cancel;

    public EmergencyContactSettingsView() {
        InitializeComponent();

        tbEmergencyContactForename.TextChanged += (s, e) => EmergencyContactForenameChanged?.Invoke(this, EventArgs.Empty);
        tbEmergencyContactSurname.TextChanged += (s, e) => EmergencyContactSurnameChanged?.Invoke(this, EventArgs.Empty);
        tbEmergencyContactPhoneNumber.TextChanged += (s, e) => EmergencyContactPhoneNumberChanged?.Invoke(this, EventArgs.Empty);
        approveChangesBar.Save += (s, e) => Save?.Invoke(this, EventArgs.Empty);
        approveChangesBar.Cancel += (s, e) => Cancel?.Invoke(this, EventArgs.Empty);

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        lblEmergencyContactTitle.ThemeTitle();
        lblEditPromt.ThemeSubtitle();

        lblEmergencyContactForenameTitle.ThemeTitle();
        lblEmergencyContactSurnameTitle.ThemeTitle();
        lblEmergencyContactPhoneNumberTitle.ThemeTitle();

        lblEmergencyContactPhoneNumberError.ThemeError();

        tbEmergencyContactForename.Theme();
        tbEmergencyContactSurname.Theme();
        tbEmergencyContactPhoneNumber.Theme();

        SetPhoneNumberBorderError(_phoneNumberError);

        approveChangesBar.Theme();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.CurrentTheme.ShowToolTips;

        tbEmergencyContactPhoneNumber.ToolTipsActive = showToolTips;
        approveChangesBar.ToolTipsActive = showToolTips;
    }

    public void SetFont() {
        string fontName = Theming.Theme.CurrentTheme.FontName;

        lblEmergencyContactTitle.SetFontName(fontName);
        lblEditPromt.SetFontName(fontName);
        lblEmergencyContactForenameTitle.SetFontName(fontName);
        tbEmergencyContactForename.SetFontName(fontName);
        lblEmergencyContactSurnameTitle.SetFontName(fontName);
        tbEmergencyContactSurname.SetFontName(fontName);
        lblEmergencyContactPhoneNumberTitle.SetFontName(fontName);
        lblEmergencyContactPhoneNumberError.SetFontName(fontName);
        approveChangesBar.SetFontName(fontName);
    }

    public string EmergencyContactForename {
        get => tbEmergencyContactForename.Text;
        set => tbEmergencyContactForename.Text = value;
    }

    public string EmergencyContactSurname {
        get => tbEmergencyContactSurname.Text;
        set => tbEmergencyContactSurname.Text = value;
    }

    public string EmergencyContactPhoneNumber {
        get => tbEmergencyContactPhoneNumber.Text;
        set => tbEmergencyContactPhoneNumber.Text = value;
    }

    public string PhoneNumberErrorText {
        get => lblEmergencyContactPhoneNumberError.Text;
        set => lblEmergencyContactPhoneNumberError.Text = value;
    }

    public bool SaveCancelVisible {
        get => approveChangesBar.Visible;
        set => approveChangesBar.Visible = value;
    }

    private bool _isLoading;
    public bool IsLoading {
        get => _isLoading;
        set {
            _isLoading = value;

            tbEmergencyContactForename.Enabled = !_isLoading;
            tbEmergencyContactSurname.Enabled = !_isLoading;
            tbEmergencyContactPhoneNumber.Enabled = !_isLoading;
            approveChangesBar.IsLoading = _isLoading;
        }
    }

    private bool _phoneNumberError;
    public void SetPhoneNumberBorderError(bool isError) {
        _phoneNumberError = isError;
        tbEmergencyContactPhoneNumber.BorderColor = _phoneNumberError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
    }

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK) {
        return CustomMessageBox.Show(text, caption, buttons);
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
