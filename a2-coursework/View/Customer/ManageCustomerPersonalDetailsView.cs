using a2_coursework._Helpers;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Customer;
using a2_coursework.Theming;

namespace a2_coursework.View.Customer;
public partial class ManageCustomerPersonalDetailsView : Form, IThemeable, IManageCustomerPersonalDetailsView {
    public event EventHandler? ForenameChanged;
    public event EventHandler? SurnameChanged;
    public event EventHandler? ArchivedChanged;

    public ManageCustomerPersonalDetailsView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        tbForename.TextChanged += (s, e) => ForenameChanged?.Invoke(this, EventArgs.Empty);
        tbSurname.TextChanged += (s, e) => SurnameChanged?.Invoke(this, EventArgs.Empty);
        rbArchived.CheckChanged += (s, e) => ArchivedChanged?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblForenameTitle.ThemeTitle();
        tbForename.Theme();
        lblSurnameTitle.ThemeTitle();
        tbSurname.Theme();
        lblNameError.ThemeError();
        pnlArchived.Theme();
        lblArchived.ThemeTitle();
        rbArchived.Theme();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        tbForename.ToolTipsActive = showToolTips;
        tbSurname.ToolTipsActive = showToolTips;
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblForenameTitle.SetFontName(fontName);
        tbForename.SetFontName(fontName);
        lblSurnameTitle.SetFontName(fontName);
        tbSurname.SetFontName(fontName);
        lblNameError.SetFontName(fontName);
        lblArchived.SetFontName(fontName);
    }

    public string Forename {
        get => tbForename.Text;
        set => tbForename.Text = value;
    }

    public string Surname {
        get => tbSurname.Text;
        set => tbSurname.Text = value;
    }

    public string NameError {
        get => lblNameError.Text;
        set => lblNameError.Text = value;
    }

    public bool Archived {
        get => rbArchived.Checked;
        set => rbArchived.Checked = value;
    }

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
