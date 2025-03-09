using a2_coursework._Helpers;
using a2_coursework.Interfaces.Customer;
using a2_coursework.Theming;

namespace a2_coursework.View.Order;
public partial class ManageCustomerContactDetails : Form, IManageCustomerContactDetailsView, IThemeable {
    public event EventHandler? EmailChanged;
    public event EventHandler? PhoneNumberChanged;
    public event EventHandler? AddressChanged;

    public ManageCustomerContactDetails() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        tbEmail.TextChanged += (s, e) => EmailChanged?.Invoke(this, EventArgs.Empty);
        tbPhoneNumber.TextChanged += (s, e) => PhoneNumberChanged?.Invoke(this, EventArgs.Empty);
        tbAddress.TextChanged += (s, e) => AddressChanged?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblEmailTitle.ThemeTitle();
        tbEmail.Theme();
        lblPhoneNumber.ThemeTitle();
        tbPhoneNumber.Theme();
        lblAddressTitle.ThemeTitle();
        tbAddress.Theme();
        lblContactError.ThemeError();

        tbEmail.BorderColor = _emailBorderError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
        tbPhoneNumber.BorderColor = _phoneNumberBorderError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    public void SetToolTipVisibility() { }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblEmailTitle.SetFontName(fontName);
        tbEmail.SetFontName(fontName);
        lblPhoneNumber.SetFontName(fontName);
        tbPhoneNumber.SetFontName(fontName);
        lblAddressTitle.SetFontName(fontName);
        tbAddress.SetFontName(fontName);
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

    public string ContactError {
        get => lblContactError.Text;
        set => lblContactError.Text = value;
    }

    private bool _emailBorderError = false;
    public void SetEmailBorderError(bool isError) {
        _emailBorderError = isError;

        tbEmail.BorderColor = _emailBorderError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    private bool _phoneNumberBorderError = false;
    public void SetPhoneNumberBorderError(bool isError) {
        _phoneNumberBorderError = isError;

        tbPhoneNumber.BorderColor = _phoneNumberBorderError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    public void SetCharacterCount(int number) => lblCharacterLimit.Text = $"{number}/{tbAddress.MaxLength}";

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
