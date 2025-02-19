using a2_coursework._Helpers;
using a2_coursework.CustomControls;
using a2_coursework.Interfaces.Staff.StaffManagement;
using a2_coursework.Theming;

namespace a2_coursework.View.StaffView;
public partial class ManageStaffAppearanceSettingsView : Form, IThemeable, IManageStaffAppearanceSettingsView {
    public event EventHandler? FontNameChanged;
    public event EventHandler? DarkModeCheckedChanged;
    public event EventHandler? ToolTipsCheckedChanged;

    public ManageStaffAppearanceSettingsView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        rbDarkMode.CheckChanged += (s, e) => DarkModeCheckedChanged?.Invoke(this, EventArgs.Empty);
        rbShowToolTips.CheckChanged += (s, e) => ToolTipsCheckedChanged?.Invoke(this, EventArgs.Empty);
    }

    private bool _updatingToggles = false;
    private void rbFontName_CheckChanged(object? sender, EventArgs e) {
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

        FontNameChanged?.Invoke(this, EventArgs.Empty);

        _updatingToggles = false;
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblDarkMode.ThemeTitle();
        pnlDarkMode.Theme();
        pnltoolTips.Theme();
        rbShowToolTips.Theme();
        rbDarkMode.Theme();
        lblToolTips.ThemeTitle();
        lblFont.ThemeTitle();
        pnlFont.Theme();
        lblBahnschrift.ThemeTitle();
        rbBahnschrift.Theme();
        lblCentury.ThemeTitle();
        rbCentury.Theme();
        lblComicSans.ThemeTitle();
        rbComicSans.Theme();
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblDarkMode.SetFontName(fontName);
        pnlDarkMode.SetFontName(fontName);
        rbDarkMode.SetFontName(fontName);
        lblToolTips.SetFontName(fontName);
        lblFont.SetFontName(fontName);
        pnlFont.SetFontName(fontName);
        lblBahnschrift.SetFontName(fontName);
        rbBahnschrift.SetFontName(fontName);
        lblCentury.SetFontName(fontName);
        rbCentury.SetFontName(fontName);
        lblComicSans.SetFontName(fontName);
        rbComicSans.SetFontName(fontName);
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;
    }

    public bool DarkModeChecked {
        get => rbDarkMode.Checked;
        set => rbDarkMode.Checked = value;
    }

    public bool ShowToolTipsChecked {
        get => rbShowToolTips.Checked;
        set => rbShowToolTips.Checked = value;
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

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
