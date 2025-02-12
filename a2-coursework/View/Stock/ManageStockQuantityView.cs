using a2_coursework._Helpers;
using a2_coursework.Theming;
using a2_coursework.View.Interfaces.Stock;

namespace a2_coursework.View.Stock;
public partial class ManageStockQuantityView : Form, IManageStockQuantityView {
    public event EventHandler? BulkAdd;
    public event EventHandler? BulkRemove;
    public event EventHandler? ReasonForQuantityChangeChanged;

    public ManageStockQuantityView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += (s, e) => Theme();

        SetFont();
        Theming.Theme.FontNameChanged += (s, e) => SetFont();

        btnAdd.Click += (s, e) => BulkAdd?.Invoke(this, EventArgs.Empty);
        btnRemove.Click += (s, e) => BulkRemove?.Invoke(this, EventArgs.Empty);
        tbReasonForQuantityChange.TextChanged += (s, e) => ReasonForQuantityChangeChanged?.Invoke(this, EventArgs.Empty);

        MessageBox.Show(tbReasonForQuantityChange.Height.ToString());
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

    private void SetFont() {
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
}
