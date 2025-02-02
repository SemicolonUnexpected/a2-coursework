using a2_coursework.CustomControls;
using a2_coursework.Theming;
using a2_coursework.Presenter.Settings;
using a2_coursework.View.Interfaces.Settings;

namespace a2_coursework.View.Settings;
public partial class AppearanceSettingsView : Form, IAppearanceSettings {
    private AppearanceSettingsPresenter? _presenter;

    public event EventHandler? DarkModeCheckedChanged;
    public event EventHandler? ToolTipsCheckedChanged;
    public event EventHandler? FontNameChanged;
    public event EventHandler? Save;
    public event EventHandler? Cancel;

    public AppearanceSettingsView() {
        InitializeComponent();

        rbDarkMode.CheckChanged += (s, e) => DarkModeCheckedChanged?.Invoke(this, EventArgs.Empty);
        rbToolTips.CheckChanged += (s, e) => ToolTipsCheckedChanged?.Invoke(this, EventArgs.Empty);
        approveChangesBar.Save += (s, e) => Save?.Invoke(this, EventArgs.Empty);
        approveChangesBar.Cancel += (s, e) => Cancel?.Invoke(this, EventArgs.Empty);

        Theme();
        Theming.Theme.AppearanceThemeChanged += (s, e) => Theme();
    }

    public void SetPresenter(AppearanceSettingsPresenter presenter) {
        _presenter = presenter;
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;
    }

    public bool DarkModeChecked {
        get => rbDarkMode.Checked;
        set => rbDarkMode.Checked = value;
    }

    public bool ToolTipsChecked {
        get => rbToolTips.Checked;
        set => rbToolTips.Checked = value;
    }

    public string FontName {
        get {
            if (rbBahnschrift.Checked) return "Bahnschrift";
            else if (rbCentury.Checked) return "Century";
            else if (rbComicSans.Checked) return "Comic Sans MS";
            else return "Bahnschrift";
        }
        set {
            if (value == "Bahnschrift") rbBahnschrift.Checked = true;
            else if (value == "Century") rbCentury.Checked = true;
            else if (value == "Comic Sans MS") rbComicSans.Checked = true;
        }
    }

    public bool SaveVisible {
        get => approveChangesBar.Visible;
        set => approveChangesBar.Visible = value;
    }

    private bool _isLoading = false;
    public bool IsLoading {
        get => _isLoading;
        set {
            _isLoading = value;

            rbDarkMode.Enabled = !_isLoading;
            rbToolTips.Enabled = !_isLoading;
            rbBahnschrift.Enabled = !_isLoading;
            rbCentury.Enabled = !_isLoading;
            rbComicSans.Enabled = !_isLoading;

            approveChangesBar.IsLoading = _isLoading;
        }
    }

    public bool DockInParent => true;

    public void ShowMessageBox(string text, string caption) {
        CustomMessageBox.Show(text, caption);
    }

    public bool CanExit() {
        if (IsLoading) return false;

        if (_presenter is not null && _presenter.AnyChanges()) {
            DialogResult result = CustomMessageBox.Show("All your changes will be lost. Click OK if you want to continue", "Are you sure you want to leave this page?", MessageBoxButtons.OKCancel);

            return result == DialogResult.OK;
        }

        return true;
    }

    bool _updatingToggles = false;
    private void rbFontName_CheckChanged(object? sender, EventArgs e) {
        FontNameChanged?.Invoke(this, EventArgs.Empty);

        if (_updatingToggles) return;

        _updatingToggles = true;
        CustomRadioButton rb = (CustomRadioButton)sender!;

        if (!rb.Checked) {
            rb.Checked = true;
            _updatingToggles = false;
            return;
        }

        if (rb != rbBahnschrift) rbBahnschrift.Checked = false;
        if (rb != rbCentury) rbCentury.Checked = false;
        if (rb != rbComicSans) rbComicSans.Checked = false;

        _updatingToggles = false;
    }

    private void lblBahnschrift_Click(object sender, EventArgs e) {
        rbBahnschrift.Checked = !rbBahnschrift.Checked;
    }

    private void lblCentury_Click(object sender, EventArgs e) {
        rbCentury.Checked = !rbCentury.Checked;
    }

    private void lblComicSans_Click(object sender, EventArgs e) {
        rbComicSans.Checked = !rbComicSans.Checked;
    }
}
