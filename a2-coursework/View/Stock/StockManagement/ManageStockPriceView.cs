using a2_coursework._Helpers;
using a2_coursework.Interfaces.Stock.StockManagement;
using a2_coursework.Theming;

namespace a2_coursework.View.Stock;
public partial class ManageStockPriceView : Form, IThemeable {
    public event EventHandler? PriceChanged;

    public ManageStockPriceView () {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblInfo.ThemeSubtitle();
        lblLowQuantity.ThemeTitle();
        lblHighQuantity.ThemeTitle();

        nudHighQuantity.Theme();
        nudLowQuantity.Theme();
    }

    public void SetToolTipVisibility() {
        nudLowQuantity.SetToolTipVisibility();
        nudHighQuantity.SetToolTipVisibility();
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblInfo.SetFontName(fontName);
        lblHighQuantity.SetFontName(fontName);
        nudHighQuantity.SetFontName(fontName);
        lblLowQuantity.SetFontName(fontName);
        nudLowQuantity.SetFontName(fontName);
    }

    public int LowQuantity {
        get => nudLowQuantity.Value;
        set => nudLowQuantity.Value = value;
    }

    public int HighQuantity {
        get => nudHighQuantity.Value;
        set => nudHighQuantity.Value = value;
    }

    public void CleanUp() {
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
