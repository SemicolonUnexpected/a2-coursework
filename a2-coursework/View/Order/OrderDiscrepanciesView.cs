using a2_coursework._Helpers;
using a2_coursework.Interfaces.Order;
using a2_coursework.Theming;

namespace a2_coursework.View.Order;
public partial class ManageOrderDiscrepanciesView : Form, IOrderDiscrepanciesView, IThemeable {
    public event EventHandler? DescriptionChanged;

    public ManageOrderDiscrepanciesView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        tbDescription.TextChanged += (s, e) => DescriptionChanged?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblDescription.ThemeTitle();
        tbDescription.Theme();
    }

    public void SetToolTipVisibility() { }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblDescription.SetFontName(fontName);
        tbDescription.SetFontName(fontName);
    }

    public string Description {
        get => tbDescription.Text;
        set => tbDescription.Text = value;
    }

    public bool ReadOnly {
        get => tbDescription.ReadOnly;
        set => tbDescription.ReadOnly = value;
    }

    public void SetCharacterCount(int number) => lblCharacterLimit.Text = $"{number}/{tbDescription.MaxLength}";

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
