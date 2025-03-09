using a2_coursework._Helpers;
using a2_coursework.Interfaces.Stock.StockManagement;
using a2_coursework.Theming;

namespace a2_coursework.View.Stock.StockManagement;
public partial class ManageStockUnitCostView : Form, IManageStockUnitCostView, IThemeable {
    public event EventHandler? UnitCostChanged;

    public ManageStockUnitCostView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        nudUnitCost.ValueChanged += (s, e) => UnitCostChanged?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        pnlUnitCost.Theme();
        lblUnitCost.ThemeTitle();

        nudUnitCost.BackColor = ColorScheme.Light.Background;
        nudUnitCost.ForeColor = ColorScheme.Light.Foreground;
    }

    public void SetToolTipVisibility() { }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        pnlUnitCost.SetFontName(fontName);
        lblUnitCost.SetFontName(fontName);
        nudUnitCost.SetFontName(fontName);
    }

    public decimal UnitCost {
        get => nudUnitCost.Value;
        set => nudUnitCost.Value = value;
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
