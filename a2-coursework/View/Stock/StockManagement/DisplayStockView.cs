﻿using a2_coursework._Helpers;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Stock.StockManagement;
using a2_coursework.Theming;
using a2_coursework.View.Stock.StockManagement;
using System.ComponentModel;

namespace a2_coursework.View;
public partial class DisplayStockView : Form, IDisplayStockView, IThemeable, IDisplayView<DisplayStockModel> {
    private readonly BindingSource _bindingSource = [];

    public event EventHandler? Add;
    public event EventHandler? Edit;
    public event EventHandler? ArchiveToggled;
    public event EventHandler? ShowArchivedChanged;
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public DisplayStockView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        topBar.Add += (s, e) => Add?.Invoke(this, EventArgs.Empty);
        topBar.Edit += (s, e) => Edit?.Invoke(this, EventArgs.Empty);
        topBar.ArchiveToggled += (s, e) => ArchiveToggled?.Invoke(this, EventArgs.Empty);
        topBar.ShowArchivedToggled += (s, e) => ShowArchivedChanged?.Invoke(this, EventArgs.Empty);
        topBar.Search += (s, e) => Search?.Invoke(this, EventArgs.Empty);
        topBar.SearchTextChanged += (s, e) => Search?.Invoke(this, EventArgs.Empty);
        dataGridView.SelectionChanged += (s, e) => SelectionChanged?.Invoke(this, EventArgs.Empty);
        dataGridView.CellDoubleClick += (s, e) => Edit?.Invoke(this, EventArgs.Empty);

        _bindingSource.ListChanged += (s, e) => SetToolTipVisibility();

        SetupDataGrid();
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblStock.ThemeTitle();
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
        lblStock.SetFontName(fontName);
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

        columnId.DataPropertyName = nameof(DisplayStockModel.Id);
        columnName.DataPropertyName = nameof(DisplayStockModel.Name);
        columnSku.DataPropertyName = nameof(DisplayStockModel.Sku);
        columnQuantity.DataPropertyName = nameof(DisplayStockModel.Quantity);
        columnQuantityLevel.DataPropertyName = nameof(DisplayStockModel.QuantityLevel);
        columnArchived.DataPropertyName = nameof(DisplayStockModel.Archived);
    }

    public string SearchText {
        get => topBar.SearchText;
        set => topBar.SearchText = value;
    }

    public DisplayStockModel? SelectedItem {
        get {
            try {
                return ((BindingList<DisplayStockModel>)_bindingSource.DataSource)[dataGridView.SelectedRows[0].Index];
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

    public void DisplayItems(BindingList<DisplayStockModel> items) {
        dataGridView.SuspendLayout();
        _bindingSource.DataSource = items;
        dataGridView.ResumeLayout();
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
        // Quantiity level is at index 4, row indexes start at 0 with the column header being index -1. Tiny bit odd
        if (e.ColumnIndex == 4 && e.RowIndex >= 0) {
            if (e.Value is string quantityLevel) {
                if (quantityLevel == "Low") {
                    e.CellStyle!.ForeColor = ColorScheme.Current.Danger;
                    e.CellStyle!.SelectionForeColor = ColorScheme.Current.Danger;
                }
                else if (quantityLevel == "Medium") {
                    e.CellStyle!.ForeColor = ColorScheme.Current.Warning;
                    e.CellStyle!.SelectionForeColor = ColorScheme.Current.Warning;
                }
                else if (quantityLevel == "High") {
                    e.CellStyle!.ForeColor = ColorScheme.Current.Info;
                    e.CellStyle!.SelectionForeColor = ColorScheme.Current.Info;
                }

            }
        }

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

    private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
        foreach (DataGridViewColumn column in dataGridView.Columns) {
            column.HeaderCell.SortGlyphDirection = SortOrder.None;
        }

        bool isAscending = e.Button == MouseButtons.Left;

        SortRequestEventArgs sortRequestEventArgs = new(dataGridView.Columns[e.ColumnIndex].Name, isAscending);
        SortRequested?.Invoke(this, sortRequestEventArgs);

        dataGridView.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = isAscending ? SortOrder.Ascending : SortOrder.Descending;
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
