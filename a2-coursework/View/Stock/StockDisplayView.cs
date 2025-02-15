using a2_coursework._Helpers;
using a2_coursework.Theming;
using a2_coursework.View.Interfaces.Stock;
using a2_coursework.View.Stock;
using System.ComponentModel;

namespace a2_coursework.View;
public partial class StockDisplayView : Form, IStockDisplay, IThemeable {
    private readonly BindingSource _bindingSource = [];

    public event EventHandler? Add;
    public event EventHandler? Edit;
    public event EventHandler? ArchiveToggled;
    public event EventHandler? ShowArchivedChanged;
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;

    public StockDisplayView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        topBar.Add += (s, e) => Add?.Invoke(this, EventArgs.Empty);
        topBar.Edit += (s, e) => Edit?.Invoke(this, EventArgs.Empty);
        topBar.ArchiveToggled += (s, e) => ArchiveToggled?.Invoke(this, EventArgs.Empty);
        topBar.ShowArchivedToggled += (s, e) => ShowArchivedChanged?.Invoke(this, EventArgs.Empty);
        topBar.Search += (s, e) => Search?.Invoke(this, EventArgs.Empty);
        topBar.SearchTextChanged += (s, e) => Search?.Invoke(this, EventArgs.Empty);
        dataGridView.SelectionChanged += (s, e) => SelectionChanged?.Invoke(this, EventArgs.Empty);

        SetupDataGrid();
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        lblStock.ThemeTitle();
        lblError.ThemeSubtitle();

        topBar.Theme();
        pnlData.Theme();
        dataGridView.Theme();
        sb.Theme();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.CurrentTheme.ShowToolTips;

        topBar.SetToolTipVisibility();
    }

    public void SetFont() {
        string fontName = Theming.Theme.CurrentTheme.FontName;

        topBar.SetFontName(fontName);
        dataGridView.SetFontName(fontName);
        lblStock.SetFontName(fontName);
        lblError.SetFontName(fontName);
    }

    private void SetupDataGrid() {
        dataGridView.AutoGenerateColumns = false;
        columnID.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        columnQuantity.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        columnArchived.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        columnQuantityLevel.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        float scalingFactor = DeviceDpi / 96f;
        dataGridView.ColumnHeadersHeight = (int)(40 * scalingFactor);
        dataGridView.RowTemplate.Height = (int)(30 * scalingFactor);

        dataGridView.MouseWheel += (s, e) => {
            sb.Value -= Math.Sign(e.Delta);
            sb.Refresh();
        };

        SetupDataBindings();
    }

    private void SetupDataBindings() {
        dataGridView.DataSource = _bindingSource;

        _bindingSource.ListChanged += (s, e) => {
            if (e.ListChangedType is ListChangedType.Reset or ListChangedType.ItemAdded or ListChangedType.ItemDeleted) {
                SetScrollOptions();
            }
        };

        columnID.DataPropertyName = nameof(DisplayStockItem.Id);
        columnName.DataPropertyName = nameof(DisplayStockItem.Name);
        columnSKU.DataPropertyName = nameof(DisplayStockItem.SKU);
        columnQuantity.DataPropertyName = nameof(DisplayStockItem.Quantity);
        columnQuantityLevel.DataPropertyName = nameof(DisplayStockItem.QuantityLevel);
        columnArchived.DataPropertyName = nameof(DisplayStockItem.IsArchived);
        throw new NotImplementedException("pls format me");
    }

    public string SearchText {
        get => topBar.SearchText;
        set => topBar.SearchText = value;
    }

    public DisplayStockItem? SelectedItem {
        get {
            try {
                return ((BindingList<DisplayStockItem>)_bindingSource.DataSource)[dataGridView.SelectedRows[0].Index];
            }
            catch (ArgumentOutOfRangeException) {
                return null;
            }
        }
    }

    public bool ShowArchivedItems {
        get => topBar.ShowArchived;
    }

    public string DataGridText {
        get => lblError.Text;
        set {
            lblError.Text = value;
            lblError.Visible = lblError.Text != "";
        }
    }

    public bool SelectedItemArchived {
        get => topBar.Restore;
        set => topBar.Restore = value;
    }

    public void DisplayItems(BindingList<DisplayStockItem> items) {
        dataGridView.SuspendLayout();
        _bindingSource.DataSource = items;
        dataGridView.ResumeLayout();
    }

    public void DisableAll() {
        topBar.Enabled = false;
        dataGridView.ReadOnly = true;
    }

    public void EnableAll() {
        topBar.Enabled = true;
        dataGridView.ReadOnly = false;
    }

    private void SetScrollOptions() {
        int numberOfVisibleRows = (dataGridView.Height - dataGridView.ColumnHeadersHeight) / dataGridView.RowTemplate.Height;

        if (dataGridView.RowCount < numberOfVisibleRows) {
            sb.Visible = false;
            return;
        }

        sb.Visible = true;
        sb.Maximum = dataGridView.RowCount - numberOfVisibleRows;
        sb.LargeChange = numberOfVisibleRows;
    }

    private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
        // Quantiity level is at index 4, row indexes start at 0 with the column header being index -1. Tiny bit odd
        if (e.ColumnIndex == 4 && e.RowIndex >= 0) {
            if (e.Value is string quantityLevel) {
                if (quantityLevel == "Low") {
                    e.CellStyle!.ForeColor = ColorScheme.CurrentTheme.Danger;
                    e.CellStyle!.SelectionForeColor = ColorScheme.CurrentTheme.Danger;
                }
                else if (quantityLevel == "Medium") {
                    e.CellStyle!.ForeColor = ColorScheme.CurrentTheme.Warning;
                    e.CellStyle!.SelectionForeColor = ColorScheme.CurrentTheme.Warning;
                }
                else if (quantityLevel == "High") {
                    e.CellStyle!.ForeColor = ColorScheme.CurrentTheme.Info;
                    e.CellStyle!.SelectionForeColor = ColorScheme.CurrentTheme.Info;
                }

            }
        }
    }

    private void sb_ValueChanged(object sender, EventArgs e) {
        if (sb.Visible && WindowState != FormWindowState.Minimized) dataGridView.FirstDisplayedScrollingRowIndex = sb.Value;
    }

    private void dataGridView_Resize(object sender, EventArgs e) {
        SetScrollOptions();
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
