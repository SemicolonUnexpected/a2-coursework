using a2_coursework._Helpers;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Stock.StockQuantityChanges;
using a2_coursework.Theming;
using a2_coursework.View.Stock.StockQuantityChanges;
using System.ComponentModel;

namespace a2_coursework.View.Stock;
public partial class DisplayStockQuantityChangesView : Form, IThemeable, IDisplayStockQuantityChangesView, IChildView {
    private readonly BindingSource _bindingSource = new();

    public event EventHandler? View;
    public event EventHandler? ShowArchivedChanged;
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public DisplayStockQuantityChangesView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        topBar.View += (s, e) => View?.Invoke(this, EventArgs.Empty);
        topBar.ShowArchivedToggled += (s, e) => ShowArchivedChanged?.Invoke(this, EventArgs.Empty);
        topBar.Search += (s, e) => Search?.Invoke(this, EventArgs.Empty);
        topBar.SearchTextChanged += (s, e) => Search?.Invoke(this, EventArgs.Empty);
        dataGridView.SelectionChanged += (s, e) => SelectionChanged?.Invoke(this, EventArgs.Empty);
        dataGridView.CellDoubleClick += (s, e) => View?.Invoke(this, EventArgs.Empty);

        _bindingSource.ListChanged += (s, e) => SetToolTipVisibility();

        SetupDataGrid();
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblStockQuantityChanges.ThemeTitle();
        lblError.ThemeSubtitle();

        topBar.Theme();
        pnlData.Theme();
        dataGridView.Theme();
        sb.Theme();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        foreach (DataGridViewColumn column in dataGridView.Columns) {
            column.ToolTipText = showToolTips ? "Left click to sort ascending\nRight click to sort descending" : "";
        }

        foreach(DataGridViewRow row in dataGridView.Rows) {
            if (row.Index == -1) continue;

            foreach (DataGridViewCell cell in row.Cells) {
                cell.ToolTipText = showToolTips ? "Double click to open" : "";
            }
        }

        topBar.SetToolTipVisibility();
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        topBar.SetFontName(fontName);
        dataGridView.SetFontName(fontName);
        lblStockQuantityChanges.SetFontName(fontName);
        lblError.SetFontName(fontName);
    }

    private void SetupDataGrid() {
        dataGridView.AutoGenerateColumns = false;

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

        columnUsername.DataPropertyName = nameof(DisplayStockQuantityChangeModel.Username);
        columnStockName.DataPropertyName = nameof(DisplayStockQuantityChangeModel.StockName);
        columnSku.DataPropertyName = nameof(DisplayStockQuantityChangeModel.StockSKU);
        columnQuantity.DataPropertyName = nameof(DisplayStockQuantityChangeModel.Quantity);
        columnDate.DataPropertyName = nameof(DisplayStockQuantityChangeModel.Date);
        columnArchived.DataPropertyName = nameof(DisplayStockQuantityChangeModel.Archived);
    }

    public string SearchText {
        get => topBar.SearchText;
        set => topBar.SearchText = value;
    }

    public DisplayStockQuantityChangeModel? SelectedItem {
        get {
            try {
                return ((BindingList<DisplayStockQuantityChangeModel>)_bindingSource.DataSource)[dataGridView.SelectedRows[0].Index];
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

    public void DisableAll() {
        topBar.Enabled = false;
        dataGridView.Enabled = false;
    }

    public void EnableAll() {
        topBar.Enabled = true;
        dataGridView.Enabled = true;
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
        // Format the archived
        if (e.ColumnIndex == 5 && e.RowIndex >= 0) {
            if (e.Value is bool isArchived) {
                e.Value = isArchived ? "Yes" : "No";
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

    private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
        foreach (DataGridViewColumn column in dataGridView.Columns) {
            column.HeaderCell.SortGlyphDirection = SortOrder.None;
        }

        bool isAscending = e.Button == MouseButtons.Left;
        SortRequestEventArgs sortRequestEventArgs = new(dataGridView.Columns[e.ColumnIndex].Name, isAscending);
        SortRequested?.Invoke(this, sortRequestEventArgs);
        dataGridView.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = isAscending ? SortOrder.Ascending : SortOrder.Descending;
    }

    public void DisplayItems(BindingList<DisplayStockQuantityChangeModel> items) {
        dataGridView.SuspendLayout();
        _bindingSource.DataSource = items;
        dataGridView.ResumeLayout();
    }
}
