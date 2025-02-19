using a2_coursework._Helpers;
using a2_coursework.Interfaces.Staff.StaffManagement;
using a2_coursework.Theming;

namespace a2_coursework.View.StaffView;
public partial class ManageStaffPersonalInformationView : Form, IManageStaffPersonalInformationView, IThemeable {
    public event EventHandler? ForenameChanged;
    public event EventHandler? SurnameChanged;
    public event EventHandler? DateOfBirthChanged;

    public ManageStaffPersonalInformationView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        tbForename.TextChanged += (s, e) => ForenameChanged?.Invoke(this, EventArgs.Empty);
        tbSurname.TextChanged += (s, e) => SurnameChanged?.Invoke(this, EventArgs.Empty);
        diDateOfBirth.TextChanged += (s, e) => DateOfBirthChanged?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblForenameTitle.ThemeTitle();
        tbForename.Theme();
        lblSurnameTitle.ThemeTitle();
        tbSurname.Theme();
        lblDateOfBirthTitle.ThemeTitle();
        diDateOfBirth.Theme();
        lblNameError.ThemeError();
        lblDateOfBirthError.ThemeError();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        diDateOfBirth.ToolTipsActive = showToolTips;
        tbForename.ToolTipsActive = showToolTips;
        tbSurname.ToolTipsActive = showToolTips;
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblForenameTitle.SetFontName(fontName);
        tbForename.SetFontName(fontName);
        lblSurnameTitle.SetFontName(fontName);
        tbSurname.SetFontName(fontName);
        lblDateOfBirthTitle.SetFontName(fontName);
        diDateOfBirth.SetFontName(fontName);
        lblNameError.SetFontName(fontName);
        lblDateOfBirthError.SetFontName(fontName);
    }

    public string Forename {
        get => tbForename.Text;
        set => tbForename.Text = value;
    }

    public string Surname {
        get => tbSurname.Text;
        set => tbSurname.Text = value;
    }

    public DateTime? DateOfBirth {
        get => diDateOfBirth.Date;
        set => diDateOfBirth.Date = value;
    }

    public string NameError {
        get => lblNameError.Text;
        set => lblNameError.Text = value;
    }

    public string DateOfBirthError {
        get => lblDateOfBirthError.Text;
        set => lblDateOfBirthError.Text = value;
    }

    public bool DateOfBirthValid => diDateOfBirth.DateValid;

    private bool _forenameBorderError = false;
    public void SetForenameBorderError(bool isError) {
        _forenameBorderError = isError;
        tbForename.BorderColor = _forenameBorderError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    private bool _surnameBorderError = false;
    public void SetSurnameBorderError(bool isError) {
        _surnameBorderError = isError;
        tbSurname.BorderColor = _surnameBorderError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
