using a2_coursework.CustomControls;
using a2_coursework.Presenter.Settings;
using a2_coursework.Theming;
using a2_coursework.View.Interfaces.Settings;

namespace a2_coursework.View;
public partial class ContactDetailsSettingsView : Form, IContactDetailsSettings {
    private ContactDetailsSettingsPresenter? _presenter;

    public event EventHandler? EmailChanged;
    public event EventHandler? PhoneNumberChanged;
    public event EventHandler? AddressChanged;
    public event EventHandler? SaveRequested;
    public event EventHandler? CancelRequested;

    public ContactDetailsSettingsView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += (s, e) => Theme();

        tbEmail.TextChanged += (s, e) => EmailChanged?.Invoke(this, EventArgs.Empty);
        tbPhoneNumber.TextChanged += (s, e) => PhoneNumberChanged?.Invoke(this, EventArgs.Empty);
        tbAddress.TextChanged += (s, e) => AddressChanged?.Invoke(this, EventArgs.Empty);
        approveChangesBar.Save += (s, e) => SaveRequested?.Invoke(this, EventArgs.Empty);
        approveChangesBar.Cancel += (s, e) => CancelRequested?.Invoke(this, EventArgs.Empty);
    }

    public void SetPresenter(ContactDetailsSettingsPresenter presenter) {
        _presenter = presenter;
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        lblContactInformation.ThemeTitle();
        lblEditPromt.ThemeSubtitle();

        lblEmailTitle.ThemeTitle();
        lblPhoneNumber.ThemeTitle();
        lblAddressTitle.ThemeTitle();

        lblContactError.ThemeError();

        tbEmail.Theme();
        tbPhoneNumber.Theme();
        tbAddress.Theme();
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

    public bool SaveVisible {
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

    public bool DockInParent => true;

    bool _emailError = false;
    public void SetEmailBorderError(bool isError) {
        _emailError = isError;

        tbEmail.BorderColor = _emailError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
    }

    bool _phoneNumberError = false;
    public void SetPhoneNumberBorderError(bool isError) {
        _phoneNumberError = isError;

        tbPhoneNumber.BorderColor = _phoneNumberError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
    }

    public void ShowError(string message, string caption) {
        CustomMessageBox.Show(message, caption, MessageBoxButtons.OK);
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
}
