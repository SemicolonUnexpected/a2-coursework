using a2_coursework._Helpers;
using a2_coursework.Interfaces.SignIn;
using a2_coursework.Theming;

namespace a2_coursework.View;
public partial class DashboardView : Form, IThemeable, IDashboardView {
    public event EventHandler? ChangePasswordClicked;

    public DashboardView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.FontNameChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        btnChangePassword.Click += (sender, e) => ChangePasswordClicked?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;
        pbLogoTitle.BackColor = ColorScheme.Current.Background;

        lblWelcome.ThemeTitle();
        pnlLastPasswordChange.Theme();
        lblLastPasswordChange.ThemeTitle();
        lblChangePasswordPrompt.ThemeWarning();
        diLastPasswordChange.Theme();
        btnChangePassword.ThemeStrong();
    }

    public void SetToolTipVisibility() { }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblWelcome.SetFontName(fontName);
        pnlLastPasswordChange.SetFontName(fontName);
        lblLastPasswordChange.SetFontName(fontName);
        lblChangePasswordPrompt.SetFontName(fontName);
        diLastPasswordChange.SetFontName(fontName);
        btnChangePassword.SetFontName(fontName);
    }

    public string Welcome {
        get => lblWelcome.Text;
        set => lblWelcome.Text = value;
    }

    public DateTime? LastPasswordChange {
        get => diLastPasswordChange.Date;
        set => diLastPasswordChange.Date = value;
    }

    private bool _showChangePassword = false;
    public bool ShowChangePassword {
        get => _showChangePassword;
        set {
            _showChangePassword = value;

            lblChangePasswordPrompt.Visible = _showChangePassword;
            btnChangePassword.Visible = _showChangePassword;
        }
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.FontNameChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
