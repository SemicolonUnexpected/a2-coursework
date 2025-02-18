using a2_coursework._Helpers;
using a2_coursework.Interfaces.Stock.StockQuantityChanges;
using a2_coursework.Theming;

namespace a2_coursework.View.Stock;
public partial class ViewStockQuantityChangeView : Form, IThemeable, IViewStockQuantityChangeView {
    public event EventHandler? Back;

    public ViewStockQuantityChangeView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        btnBack.Click += (s, e) => Back?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblStockName.ThemeTitle();
        lblQuantity.ThemeTitle();
        lblUsername.ThemeTitle();
        lblDateOfChange.ThemeTitle();
        lblReasonForQuantityChange.ThemeTitle();

        btnBack.ThemeWeak();
        diDateOfChange.Theme();

        tbStockName.Theme();
        tbQuantity.Theme();
        tbUsername.Theme();
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblStockName.SetFontName(fontName);
        lblQuantity.SetFontName(fontName);
        lblUsername.SetFontName(fontName);
        lblDateOfChange.SetFontName(fontName);
        lblReasonForQuantityChange.SetFontName(fontName);

        btnBack.SetFontName(fontName);
        diDateOfChange.SetFontName(fontName);

        tbStockName.SetFontName(fontName);
        tbQuantity.SetFontName(fontName);
        tbUsername.SetFontName(fontName);
    }

    public void SetToolTipVisibility() { }

    public string Username {
        set => tbUsername.Text = value;
    }

    public string StockName {
        set => tbStockName.Text = value;
    }

    public int Quantity {
        set => tbQuantity.Text = value.ToString();
    }

    public DateTime DateOfChange {
        set => diDateOfChange.Date = value;
    }

    public string ReasonForQuantityChange {
        set => tbReasonForQuantityChange.Text = value;
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.FontNameChanged -= SetFont;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
    }
}
