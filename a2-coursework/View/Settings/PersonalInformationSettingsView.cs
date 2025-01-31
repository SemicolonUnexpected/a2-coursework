using a2_coursework.CustomControls;
using a2_coursework.Presenter;
using a2_coursework.Theming;
using a2_coursework.View.Interfaces;

namespace a2_coursework.View.Settings;
public partial class PersonalInformationSettingsView : Form, IPersonalInformationSettings, IChildView {
    private PersonalInformationSettingsPresenter? _presenter;

    public event EventHandler? ForenameChanged;
    public event EventHandler? SurnameChanged;
    public event EventHandler? DateOfBirthChanged;
    public event EventHandler? SaveRequested;
    public event EventHandler? CancelRequested;

    public PersonalInformationSettingsView() {
        InitializeComponent();

        diDateOfBirth.MaxDate = DateTime.Now;

        Theme();
        Theming.Theme.AppearanceThemeChanged += (s, e) => Theme();

        tbForename.TextChanged += (s, e) => ForenameChanged?.Invoke(this, EventArgs.Empty);
        tbSurname.TextChanged += (s, e) => SurnameChanged?.Invoke(this, EventArgs.Empty);
        diDateOfBirth.DateTextChanged += (s, e) => DateOfBirthChanged?.Invoke(this, EventArgs.Empty);
        approveChangesBar.Save += (s, e) => SaveRequested?.Invoke(this, EventArgs.Empty);
        approveChangesBar.Cancel += (s, e) => CancelRequested?.Invoke(this, EventArgs.Empty);
    }

    public void SetPresenter(PersonalInformationSettingsPresenter presenter) {
        _presenter = presenter;
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        tbForename.Theme();
        SetForenameBorderError(_forenameError);

        tbSurname.Theme();
        SetSurnameBorderError(_surnameError);

        diDateOfBirth.Theme();

        lblPersonalInfo.ThemeTitle();

        lblNameError.ForeColor = ColorScheme.CurrentTheme.Danger;
        lblDateOfBirthError.ForeColor = ColorScheme.CurrentTheme.Danger;
    }

    public bool SaveVisible {
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
        tbForename.BorderColor = _forenameError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
    }

    private bool _surnameError = false;
    public void SetSurnameBorderError(bool isError) {
        _surnameError = isError;
        tbSurname.BorderColor = _surnameError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
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

    public bool DockInParent => true;
}
