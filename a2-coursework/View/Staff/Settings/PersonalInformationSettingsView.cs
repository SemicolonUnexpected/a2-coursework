using a2_coursework._Helpers;
using a2_coursework.CustomControls;
using a2_coursework.Interfaces.Staff.Settings;
using a2_coursework.Theming;

namespace a2_coursework.View.Settings;
public partial class PersonalInformationSettingsView : Form, IPersonalInformationSettings, IThemeable {
    public event EventHandler? ForenameChanged;
    public event EventHandler? SurnameChanged;
    public event EventHandler? DateOfBirthChanged;
    public event EventHandler? Save;
    public event EventHandler? Cancel;

    public PersonalInformationSettingsView() {
        InitializeComponent();

        tbForename.TextChanged += (s, e) => ForenameChanged?.Invoke(this, EventArgs.Empty);
        tbSurname.TextChanged += (s, e) => SurnameChanged?.Invoke(this, EventArgs.Empty);
        diDateOfBirth.DateTextChanged += (s, e) => DateOfBirthChanged?.Invoke(this, EventArgs.Empty);
        approveChangesBar.Save += (s, e) => Save?.Invoke(this, EventArgs.Empty);
        approveChangesBar.Cancel += (s, e) => Cancel?.Invoke(this, EventArgs.Empty);

        diDateOfBirth.MaxDate = DateTime.Now;

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        tbForename.Theme();
        SetForenameBorderError(_forenameError);

        tbSurname.Theme();
        SetSurnameBorderError(_surnameError);

        diDateOfBirth.Theme();

        lblPersonalInfo.ThemeTitle();
        lblEditPromt.ThemeSubtitle();

        lblForenameTitle.ThemeTitle();
        lblSurnameTitle.ThemeTitle();
        lblDateOfBirthTitle.ThemeTitle();

        lblNameError.ThemeError();
        lblDateOfBirthError.ThemeError();

        approveChangesBar.Theme();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        toolTip.Active = showToolTips;
        tbForename.ToolTipsActive = showToolTips;
        tbSurname.ToolTipsActive = showToolTips;
        diDateOfBirth.ToolTipsActive = showToolTips;
        approveChangesBar.ToolTipsActive = showToolTips;
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblPersonalInfo.SetFontName(fontName);
        lblEditPromt.SetFontName(fontName);
        lblForenameTitle.SetFontName(fontName);
        tbForename.SetFontName(fontName);
        lblSurnameTitle.SetFontName(fontName);
        tbSurname.SetFontName(fontName);
        lblDateOfBirthTitle.SetFontName(fontName);
        lblNameError.SetFontName(fontName);
        lblDateOfBirthError.SetFontName(fontName);
        diDateOfBirth.SetFontName(fontName);
        lblDateOfBirthError.SetFontName(fontName);
        approveChangesBar.SetFontName(fontName);
    }

    public bool SaveCancelVisible {
        set => approveChangesBar.Visible = value;
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

    public string NameErrorText {
        set => lblNameError.Text = value;
    }

    public string DateOfBirthErrorText {
        set => lblDateOfBirthError.Text = value;
    }

    private bool _forenameError = false;
    public void SetForenameBorderError(bool isError) {
        _forenameError = isError;
        tbForename.BorderColor = _forenameError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    private bool _surnameError = false;
    public void SetSurnameBorderError(bool isError) {
        _surnameError = isError;
        tbSurname.BorderColor = _surnameError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    private bool _isLoading = false;
    public bool IsLoading {
        get => _isLoading;
        set {
            _isLoading = value;

            if (_isLoading) {
                tbForename.Enabled = false;
                tbSurname.Enabled = false;
                diDateOfBirth.Enabled = false;
                approveChangesBar.IsLoading = true;
            }
            else {
                tbForename.Enabled = true;
                tbSurname.Enabled = true;
                diDateOfBirth.Enabled = true;
                approveChangesBar.IsLoading = false;
            }
        }
    }

    public bool DateOfBirthValid => diDateOfBirth.DateValid;

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK) {
        return CustomMessageBox.Show(text, caption, buttons);
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
