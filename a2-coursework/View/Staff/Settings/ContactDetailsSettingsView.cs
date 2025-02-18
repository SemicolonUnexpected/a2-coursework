using a2_coursework._Helpers;
using a2_coursework.CustomControls;
using a2_coursework.Interfaces.Staff.Settings;
using a2_coursework.Theming;

namespace a2_coursework.View;
public partial class ContactDetailsSettingsView : Form, IContactDetailsSettings, IThemeable {
    public event EventHandler? EmailChanged;
    public event EventHandler? PhoneNumberChanged;
    public event EventHandler? AddressChanged;
    public event EventHandler? Save;
    public event EventHandler? Cancel;

    public ContactDetailsSettingsView() {
        InitializeComponent();

        tbEmail.TextChanged += (s, e) => EmailChanged?.Invoke(this, EventArgs.Empty);
        tbPhoneNumber.TextChanged += (s, e) => PhoneNumberChanged?.Invoke(this, EventArgs.Empty);
        tbAddress.TextChanged += (s, e) => AddressChanged?.Invoke(this, EventArgs.Empty);
        approveChangesBar.Save += (s, e) => Save?.Invoke(this, EventArgs.Empty);
        approveChangesBar.Cancel += (s, e) => Cancel?.Invoke(this, EventArgs.Empty);

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        lblCharacterLimit.Text = $"{tbAddress.Text.Length} / {tbAddress.MaxLength}";
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblContactInformation.ThemeTitle();
        lblEditPromt.ThemeSubtitle();

        lblEmailTitle.ThemeTitle();
        lblPhoneNumber.ThemeTitle();
        lblAddressTitle.ThemeTitle();

        lblContactError.ThemeError();

        tbEmail.Theme();
        tbPhoneNumber.Theme();
        tbAddress.Theme();

        approveChangesBar.Theme();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        tbEmail.ToolTipsActive = showToolTips;
        tbPhoneNumber.ToolTipsActive = showToolTips;
        tbAddress.ToolTipsActive = showToolTips;
        approveChangesBar.ToolTipsActive = showToolTips;
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblContactInformation.SetFontName(fontName);
        lblContactError.SetFontName(fontName);
        lblEmailTitle.SetFontName(fontName);
        lblPhoneNumber.SetFontName(fontName);
        lblAddressTitle.SetFontName(fontName);
        lblCharacterLimit.SetFontName(fontName);
        tbAddress.SetFontName(fontName);
        tbEmail.SetFontName(fontName);
        tbPhoneNumber.SetFontName(fontName);
        lblEditPromt.SetFontName(fontName);
        approveChangesBar.SetFontName(fontName);
    }

    public string Email {
        get => tbEmail.Text;
        set => tbEmail.Text = value;
    }

    public string PhoneNumber {
        get => tbPhoneNumber.Text;
        set => tbPhoneNumber.Text = value;
    }

    public string Address {
        get => tbAddress.Text;
        set => tbAddress.Text = value;
    }

    public string ContactErrorText {
        get => lblContactError.Text;
        set => lblContactError.Text = value;
    }

    public bool SaveCancelVisible {
        set => approveChangesBar.Visible = value;
    }

    private bool _isLoading = false;
    public bool IsLoading {
        get => _isLoading;
        set {
            _isLoading = value;

            tbEmail.Enabled = !_isLoading;
            tbPhoneNumber.Enabled = !_isLoading;
            tbAddress.Enabled = !_isLoading;

            approveChangesBar.IsLoading = _isLoading;
        }
    }

    private bool _emailError = false;
    public void SetEmailBorderError(bool isError) {
        _emailError = isError;

        tbEmail.BorderColor = _emailError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    private bool _phoneNumberError = false;
    public void SetPhoneNumberBorderError(bool isError) {
        _phoneNumberError = isError;

        tbPhoneNumber.BorderColor = _phoneNumberError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK) {
        return CustomMessageBox.Show(text, caption, buttons);
    }

    private void tbAddress_TextChanged(object sender, EventArgs e) {
        lblCharacterLimit.Text = $"{tbAddress.Text.Length} / {tbAddress.MaxLength}";
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
