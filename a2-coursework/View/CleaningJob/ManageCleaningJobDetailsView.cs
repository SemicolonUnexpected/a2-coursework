using a2_coursework._Helpers;
using a2_coursework.Interfaces.CleaningJob;
using a2_coursework.Theming;

namespace a2_coursework.View.CleaningJob;
public partial class ManageCleaningJobDetailsView: Form, IManageCleaningJobOptionDetails, IThemeable {
    public event EventHandler? AddressChanged;
    public event EventHandler? ExtraInformationChanged;

    public ManageCleaningJobDetailsView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        tbAddress.TextChanged += (s, e) => AddressChanged?.Invoke(this, EventArgs.Empty);
        tbExtraInformation.TextChanged += (s, e) => ExtraInformationChanged?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblAddress.ThemeTitle();
        tbAddress.Theme();
        tbAddress.BorderColor = _addressBorderError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
        lblAddressError.ThemeError();

        lblExtraInformation.ThemeTitle();
        tbExtraInformation.Theme();
    }

    public void SetToolTipVisibility() { }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblAddress.SetFontName(fontName);
        tbExtraInformation.SetFontName(fontName);
        lblAddressError.SetFontName(fontName);

        lblExtraInformation.SetFontName(fontName);
        tbAddress.SetFontName(fontName);
    }

    public string ExtraInformation {
        get => tbExtraInformation.Text;
        set => tbExtraInformation.Text = value;
    }

    public string Address {
        get => tbAddress.Text;
        set => tbAddress.Text = value;
    }

    private bool _readOnly;
    public bool ReadOnly {
        get => _readOnly;
        set {
            _readOnly = value;

            tbAddress.ReadOnly = _readOnly;
            tbExtraInformation.ReadOnly = _readOnly;
        }
    }

    public void SetExtraInformationCharacterCount(int number) => lblExtraInformationCharacterLimit.Text = $"{number}/{tbExtraInformation.MaxLength}";
    public void SetAddressCharacterCount(int number) => lblAddressCharacterLimit.Text = $"{number}/{tbAddress.MaxLength}";

    private bool _addressBorderError;
    public void SetAddressBorderError(bool isError) {
        _addressBorderError = isError;
        tbAddress.BorderColor = _addressBorderError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
