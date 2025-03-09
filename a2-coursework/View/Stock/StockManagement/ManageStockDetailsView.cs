using a2_coursework._Helpers;
using a2_coursework.Interfaces.Stock.StockManagement;
using a2_coursework.Theming;

namespace a2_coursework.View.Stock.StockManagement;
public partial class ManageStockDetailsView : Form, IManageStockDetailsView, IThemeable {
    public event EventHandler? DescriptionChanged;
    public event EventHandler? NameChanged;
    public event EventHandler? SkuChanged;
    public event EventHandler? ArchivedChanged;

    public ManageStockDetailsView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        tbStockDescription.TextChanged += (s, e) => DescriptionChanged?.Invoke(this, EventArgs.Empty);
        tbSku.TextChanged += (s, e) => SkuChanged?.Invoke(this, EventArgs.Empty);
        tbStockName.TextChanged += (s, e) => NameChanged?.Invoke(this, EventArgs.Empty);
        rbArchived.CheckChanged += (s, e) => ArchivedChanged?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblStockName.ThemeTitle();
        tbStockName.Theme();

        lblSku.ThemeTitle();
        tbSku.Theme();
        tbSku.BorderColor = _skuError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
        lblNameSkuError.ThemeError();

        lblStockDescription.ThemeTitle();
        tbStockDescription.Theme();
        tbStockName.BorderColor = _nameError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
        lblCharacterLimit.ThemeSubtitle();

        pnlArchived.Theme();
        lblArchived.ThemeTitle();
        rbArchived.Theme();
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblStockName.SetFontName(fontName);
        tbStockName.SetFontName(fontName);
        lblSku.SetFontName(fontName);
        tbSku.SetFontName(fontName);
        lblNameSkuError.SetFontName(fontName);
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

    public string Sku {
        get => tbSku.Text;
        set => tbSku.Text = value;
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
            tbSku.Enabled = !_isLoading;
            tbStockDescription.Enabled = !_isLoading;
            rbArchived.Enabled = !_isLoading;
        }
    }

    public string NameSkuError {
        set => lblNameSkuError.Text = value;
    }

    public void SetCharacterCount(int number) => lblCharacterLimit.Text = $"{number}/{tbStockDescription.MaxLength}";

    private bool _nameError = false;
    public void SetNameBorderError(bool isError) {
        _nameError = isError;
        tbStockName.BorderColor = _nameError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    private bool _skuError = false;
    public void SetSKUBorderError(bool isError) {
        _skuError = isError;
        tbSku.BorderColor = _skuError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    private void ClearFocus() => tbFocusHolder.Focus();

    private void ClearFocusOnClick(object? sender, EventArgs e) => ClearFocus();

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
