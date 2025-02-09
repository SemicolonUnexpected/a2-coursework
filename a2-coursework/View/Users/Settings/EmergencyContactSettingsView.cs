using a2_coursework._Helpers;
using a2_coursework.CustomControls;
using a2_coursework.Presenter.Settings;
using a2_coursework.Theming;
using a2_coursework.View.Interfaces.Users.Settings;

namespace a2_coursework.View.Settings;
public partial class EmergencyContactSettingsView : Form, IEmergencyContactSettings {
    private EmergencyContactSettingsPresenter? _presenter;
    
    public event EventHandler? ForenameChanged;
    public event EventHandler? SurnameChanged;
    public event EventHandler? PhoneNumberChanged;
    public event EventHandler? Save;
    public event EventHandler? Cancel;

    public EmergencyContactSettingsView() {
        InitializeComponent();

        tbEmergencyContactForename.TextChanged += (s, e) => ForenameChanged?.Invoke(this, EventArgs.Empty);
        tbEmergencyContactSurname.TextChanged += (s, e) => SurnameChanged?.Invoke(this, EventArgs.Empty);
        tbEmergencyContactPhoneNumber.TextChanged += (s, e) => PhoneNumberChanged?.Invoke(this, EventArgs.Empty);
        approveChangesBar.Save += (s, e) => Save?.Invoke(this, EventArgs.Empty);
        approveChangesBar.Cancel += (s, e) => Cancel?.Invoke(this, EventArgs.Empty);

        Theme();
        Theming.Theme.AppearanceThemeChanged += (s, e) => Theme();

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += (s, e) => SetToolTipVisibility();

        ControlHelpers.ExecuteRecursive(this, (ctrl) => ctrl.SetFontName(Theming.Theme.CurrentTheme.FontName));
        Theming.Theme.FontNameChanged += (s, e) => ControlHelpers.ExecuteRecursive(this, (ctrl) => ctrl.SetFontName(Theming.Theme.CurrentTheme.FontName));
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
        get => lblEmergencyContactPhoneNumberError.Text;
        set => lblEmergencyContactPhoneNumberError.Text = value;
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

    private bool _phoneNumberError;
    public void SetPhoneNumberBorderError(bool isError) {
        _phoneNumberError = isError;
        tbEmergencyContactPhoneNumber.BorderColor = _phoneNumberError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
    }

    public bool DockInParent => true;

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK) {
        return CustomMessageBox.Show(text, caption, buttons);
    }

    public bool CanExit() => _presenter?.CanExit() ?? true;
}
