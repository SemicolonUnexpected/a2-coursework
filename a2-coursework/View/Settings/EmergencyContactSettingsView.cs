using a2_coursework.CustomControls;
using a2_coursework.Presenter.Settings;
using a2_coursework.Theming;
using a2_coursework.View.Interfaces.Settings;

namespace a2_coursework.View.Settings;
public partial class EmergencyContactSettingsView : Form, IEmergencyContactSettings {
    private EmergencyContactSettingsPresenter? _presenter;
    
    public event EventHandler? ForenameChanged;
    public event EventHandler? SurnameChanged;
    public event EventHandler? PhoneNumberChanged;
    public event EventHandler? SaveRequested;
    public event EventHandler? CancelRequested;

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

        tbEmergencyContactForename.TextChanged += (s, e) => ForenameChanged?.Invoke(this, EventArgs.Empty);
        tbEmergencyContactSurname.TextChanged += (s, e) => SurnameChanged?.Invoke(this, EventArgs.Empty);
        tbEmergencyContactPhoneNumber.TextChanged += (s, e) => PhoneNumberChanged?.Invoke(this, EventArgs.Empty);
        approveChangesBar.Save += (s, e) => SaveRequested?.Invoke(this, EventArgs.Empty);
        approveChangesBar.Cancel += (s, e) => CancelRequested?.Invoke(this, EventArgs.Empty);
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

        lblEmergencyPhoneNumberError.ThemeError();

        tbEmergencyContactForename.Theme();
        tbEmergencyContactSurname.Theme();
        tbEmergencyContactPhoneNumber.Theme();

        SetPhoneNumberBorderError(_phoneNumberError);
    }

    private bool _phoneNumberError;
    public void SetPhoneNumberBorderError(bool isError) {
        _phoneNumberError = isError;
        tbEmergencyContactPhoneNumber.BorderColor = _phoneNumberError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
    }

    public void ShowError(string message, string caption) {
        CustomMessageBox.Show(message, caption);
    }

    public void ShowSuccess(string message, string caption) {
        CustomMessageBox.Show(message, caption);
    }

    public bool CanExit() {
        if (IsLoading) return false;

        if (_presenter is not null && _presenter.AnyChanges()) {
            DialogResult result = CustomMessageBox.Show("All your changes will be lost. Click OK if you want to continue", "Are you sure you want to leave this page?", MessageBoxButtons.OKCancel);

            return result == DialogResult.OK;
        }

        return true;    
    }

    public bool DockInParent => true;
}
