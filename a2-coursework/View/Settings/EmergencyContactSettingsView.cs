using a2_coursework.CustomControls;
using a2_coursework.Presenter;
using a2_coursework.Theming;
using a2_coursework.View.Interfaces;

namespace a2_coursework.View.Settings; 
public partial class EmergencyContactSettingsView : Form, IEmergencyContactSettingsView {
    private EmergencyContactSettingsPresenter? _presenter;

    public string Forename {
        get => tbEmergencyContactForename.Text;
        set => tbEmergencyContactForename.Text = value;
    }

    public string Surname {
        get => tbEmergencyContactSurname.Text;
        set => tbEmergencyContactSurname.Text = value;
    }

    public string PhoneNumber {
        get => tbEmergencyContactPhoneNumber.Text;
        set => tbEmergencyContactPhoneNumber.Text = value;
    }
    
    public string NameErrorText {
        get => lblEmergencyContactNameError.Text;
        set => lblEmergencyContactNameError.Text = value;
    }

    public string PhoneNumberErrorText {
        get => lblEmergencyPhoneNumberError.Text;
        set => lblEmergencyPhoneNumberError.Text = value;
    }

    public bool SaveVisible {
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

    public EmergencyContactSettingsView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += (s, e) => Theme();
    }

    public void SetPresenter(EmergencyContactSettingsPresenter presenter) {
        _presenter = presenter;
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        lblEmergencyContactTitle.ThemeTitle();
        lblEditPromt.ThemeSubtitle();

        lblEmergencyContactForenameTitle.ThemeTitle();
        lblEmergencyContactSurnameTitle.ThemeTitle();

        lblEmergencyContactNameError.ThemeError();
        lblEmergencyPhoneNumberError.ThemeError();

        tbEmergencyContactForename.Theme();
        tbEmergencyContactSurname.Theme();
        tbEmergencyContactPhoneNumber.Theme();
    }

    public event EventHandler? SurnameChanged;
    public event EventHandler? ForenameChanged;
    public event EventHandler? PhoneNumberChanged;

    private bool _forenameError;
    public void SetForenameBorderError(bool isError) {
        _forenameError = isError;
        tbEmergencyContactForename.BorderColor = _forenameError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
    }

    private bool _surnameError;
    public void SetSurnameBorderError(bool isError) {
        _surnameError = isError;
        tbEmergencyContactSurname.BorderColor = _surnameError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
    }

    private bool _phoneNumberError;
    public void SetPhoneNumberBorderError(bool isError) {
        _phoneNumberError = isError;
        tbEmergencyContactPhoneNumber.BorderColor = _surnameError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
    }

    public void ShowError(string message, string caption) {
        CustomMessageBox.Show(message, caption);
    }

    public void ShowSuccess(string message, string caption) {
        CustomMessageBox.Show(message, caption);
    }
}
