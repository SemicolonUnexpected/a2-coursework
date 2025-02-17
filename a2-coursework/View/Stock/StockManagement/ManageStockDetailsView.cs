using a2_coursework._Helpers;
using a2_coursework.Interfaces.Stock.StockManagement;
using a2_coursework.Theming;

namespace a2_coursework.View.Stock;
public partial class ManageStockDetailsView : Form, IManageStockDetailsView, IThemeable {
    public event EventHandler? DescriptionChanged;
    public event EventHandler? NameChanged;
    public event EventHandler? SKUChanged;
    public event EventHandler? ArchivedChanged;

    public ManageStockDetailsView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        tbStockDescription.TextChanged += (s, e) => DescriptionChanged?.Invoke(this, EventArgs.Empty);
        tbSKU.TextChanged += (s, e) => SKUChanged?.Invoke(this, EventArgs.Empty);
        tbStockName.TextChanged += (s, e) => NameChanged?.Invoke(this, EventArgs.Empty);
        rbArchived.CheckChanged += (s, e) => ArchivedChanged?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        lblStockName.ThemeTitle();
        tbStockName.Theme();

        lblSKU.ThemeTitle();
        tbSKU.Theme();
        tbSKU.BorderColor = _skuError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
        lblNameSKUError.ThemeError();

        lblStockDescription.ThemeTitle();
        tbStockDescription.Theme();
        tbStockName.BorderColor = _nameError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
        lblCharacterLimit.ThemeSubtitle();

        pnlArchived.Theme();
        lblArchived.ThemeTitle();
        rbArchived.Theme();
    }

    public void SetFont() {
        string fontName = Theming.Theme.CurrentTheme.FontName;

        lblStockName.SetFontName(fontName);
        tbStockName.SetFontName(fontName);
        lblSKU.SetFontName(fontName);
        tbSKU.SetFontName(fontName);
        lblNameSKUError.SetFontName(fontName);
        lblStockDescription.SetFontName(fontName);
        tbStockDescription.SetFontName(fontName);
        lblCharacterLimit.SetFontName(fontName);
        lblArchived.SetFontName(fontName);
    }

    public void SetToolTipVisibility() { }

    public string StockName {
        get => tbStockName.Text;
        set => tbStockName.Text = value;
    }

    public string Description {
        get => tbStockDescription.Text;
        set => tbStockDescription.Text = value;
    }

    public string SKU {
        get => tbSKU.Text;
        set => tbSKU.Text = value;
    }

    public bool Archived {
        get => rbArchived.Checked;
        set => rbArchived.Checked = value;
    }

    private bool _isLoading = false;
    public bool IsLoading {
        get => _isLoading;
        set {
            _isLoading = value;

            tbStockName.Enabled = !_isLoading;
            tbSKU.Enabled = !_isLoading;
            tbStockDescription.Enabled = !_isLoading;
            rbArchived.Enabled = !_isLoading;
        }
    }

    public string NameSKUError {
        set => lblNameSKUError.Text = value;
    }

    public void SetCharacterCount(int number) => lblCharacterLimit.Text = $"{number}/{tbStockDescription.MaxLength}";

    private bool _nameError = false;
    public void SetNameBorderError(bool isError) {
        _nameError = isError;
        tbStockName.BorderColor = _nameError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
    }

    private bool _skuError = false;
    public void SetSKUBorderError(bool isError) {
        _skuError = isError;
        tbSKU.BorderColor = _skuError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
    }

    private void ClearFocus() => tbFocusHolder.Focus();

    private void ClearFocusOnClick(object? sender, EventArgs e) => ClearFocus();

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
