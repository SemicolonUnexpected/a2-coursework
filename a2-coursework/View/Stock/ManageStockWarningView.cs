using a2_coursework._Helpers;
using a2_coursework.Theming;
using a2_coursework.View.Interfaces.Stock;

namespace a2_coursework.View.Stock; 
public partial class ManageStockWarningView : Form, IManageStockWarningView {
    public event EventHandler? Save;
    public event EventHandler? Cancel;

    public ManageStockWarningView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += (s, e) => SetFont();
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        lblInfo.ThemeSubtitle();
        lblLowQuantity.ThemeSubtitle();
    }

    private void SetFont() {
        string fontName = Theming.Theme.CurrentTheme.FontName;

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
}
