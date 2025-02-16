using a2_coursework._Helpers;
using a2_coursework.Theming;
using a2_coursework.View.Interfaces.Stock;

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
        BackColor = ColorScheme.CurrentTheme.Background;

        lblQuantity.ThemeTitle();
        lblBulkAdd.ThemeTitle();
        lblBulkRemove.ThemeTitle();
        lblReasonForChange.ThemeTitle();
        lblCharacterLimit.ThemeSubtitle();
        lblStaffLink.ThemeSubtitle();

        nudBulkAdd.Theme();
        nudBulkRemove.Theme();
        tbReasonForQuantityChange.Theme();

        btnAdd.ThemeStrong();
        btnRemove.ThemeStrong();
    }

    public void SetFont() {
        string fontName = Theming.Theme.CurrentTheme.FontName;

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

    public int BulkAddQuantity => nudBulkAdd.Value;

    public int BulkRemoveQuantity => nudBulkRemove.Value;

    public string ReasonForQuantityChange {
        get => tbReasonForQuantityChange.Text;
        set => tbReasonForQuantityChange.Text = value;
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
