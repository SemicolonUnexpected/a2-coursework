using a2_coursework._Helpers;
using a2_coursework.Interfaces.Stock.StockManagement;
using a2_coursework.Theming;

namespace a2_coursework.View.Stock;
public partial class ManageStockQuantityView : Form, IManageStockQuantityView, IThemeable {
    public event EventHandler? BulkAdd;
    public event EventHandler? BulkRemove;
    public event EventHandler? ReasonForQuantityChangeChanged;
    public event EventHandler? QuantityChanged;

    public ManageStockQuantityView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        btnAdd.Click += (s, e) => BulkAdd?.Invoke(this, EventArgs.Empty);
        btnRemove.Click += (s, e) => BulkRemove?.Invoke(this, EventArgs.Empty);
        tbReasonForQuantityChange.TextChanged += (s, e) => ReasonForQuantityChangeChanged?.Invoke(this, EventArgs.Empty);
        nudQuantity.ValueChanged += (s, e) => QuantityChanged?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblQuantity.ThemeTitle();
        lblBulkAdd.ThemeTitle();
        lblBulkRemove.ThemeTitle();
        lblReasonForChange.ThemeTitle();
        lblCharacterLimit.ThemeSubtitle();
        lblStaffLink.ThemeSubtitle();

        nudQuantity.Theme();
        nudBulkAdd.Theme();
        nudBulkRemove.Theme();
        tbReasonForQuantityChange.Theme();

        btnAdd.ThemeStrong();
        btnRemove.ThemeStrong();
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblQuantity.SetFontName(fontName);
        nudQuantity.SetFontName(fontName);
        lblBulkAdd.SetFontName(fontName);
        nudBulkAdd.SetFontName(fontName);
        btnAdd.SetFontName(fontName);
        lblBulkRemove.SetFontName(fontName);
        nudBulkRemove.SetFontName(fontName);
        btnRemove.SetFontName(fontName);
        lblReasonForChange.SetFontName(fontName);
        lblCharacterLimit.SetFontName(fontName);
        lblStaffLink.SetFontName(fontName);
    }

    public void SetToolTipVisibility() {
        nudQuantity.SetToolTipVisibility();
        nudBulkAdd.SetToolTipVisibility();
        nudBulkRemove.SetToolTipVisibility();
    }

    public int Quantity {
        get => nudQuantity.Value;
        set => nudQuantity.Value = value;
    }

    public int BulkAddQuantity {
        get => nudBulkAdd.Value;
        set => nudBulkAdd.Value = value;
    }

    public int BulkRemoveQuantity {
        get => nudBulkRemove.Value;
        set => nudBulkRemove.Value = value;
    }

    public string ReasonForQuantityChange {
        get => tbReasonForQuantityChange.Text;
        set => tbReasonForQuantityChange.Text = value;
    }

    public bool ReasonForChangedReadOnly {
        get => tbReasonForQuantityChange.ReadOnly;
        set => tbReasonForQuantityChange.ReadOnly = value;
    }

    public void SetCharacterCount(int number) => lblCharacterLimit.Text = $"{number}/{tbReasonForQuantityChange.MaxLength}";

    private void ClearFocus() => tbFocusHolder.Focus();

    private void ClearFocusOnClick(object sender, EventArgs e) => ClearFocus();

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
