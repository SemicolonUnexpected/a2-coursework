﻿using a2_coursework._Helpers;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Order;
using a2_coursework.Theming;
using a2_coursework.View.Stock.StockManagement;
using System.ComponentModel;
using System.Globalization;

namespace a2_coursework.View.Order;
public partial class ManageOrderStockView : Form, IDisplayView<DisplayStockModel>, IChildView, IThemeable, IManageOrderStockView {
    private readonly BindingSource _bindingSource = [];

    public event EventHandler? QuantityChanged;
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public ManageOrderStockView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        searchBar.Search += (s, e) => Search?.Invoke(this, EventArgs.Empty);
        searchBar.SearchTextChanged += (s, e) => Search?.Invoke(this, EventArgs.Empty);
        dataGridView.SelectionChanged += (s, e) => SelectionChanged?.Invoke(this, EventArgs.Empty);
        nudQuantity.ValueChanged += (s, e) => QuantityChanged?.Invoke(this, EventArgs.Empty);

        SetupDataGrid();
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        searchBar.Theme();
        pnlData.Theme();
        dataGridView.Theme();
        sb.Theme();
        lblError.ThemeSubtitle();

        pnlDetails.Theme();
        lblName.ThemeTitle();
        tbName.Theme();
        lblDescription.ThemeTitle();
        tbDescription.Theme();
        lblQuantity.ThemeTitle();
        nudQuantity.Theme();
        lblSubtotal.ThemeTitle();
        tbSubtotal.Theme();
        lblTotal.ThemeTitle();
        tbTotal.Theme();
        tbQuantity.Theme();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        foreach (DataGridViewColumn column in dataGridView.Columns) {
            column.ToolTipText = showToolTips ? "Left click to sort ascending\nRight click to sort descending" : "";
        }

        searchBar.SetToolTipVisibility();
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        searchBar.SetFontName(fontName);
        pnlData.SetFontName(fontName);
        dataGridView.SetFontName(fontName);
        sb.SetFontName(fontName);
        lblError.SetFontName(fontName);

        pnlDetails.SetFontName(fontName);
        lblName.SetFontName(fontName);
        tbName.SetFontName(fontName);
        lblDescription.SetFontName(fontName);
        tbDescription.SetFontName(fontName);
        lblQuantity.SetFontName(fontName);
        nudQuantity.SetFontName(fontName);
        lblSubtotal.SetFontName(fontName);
        tbSubtotal.SetFontName(fontName);
        lblTotal.SetFontName(fontName);
        tbTotal.SetFontName(fontName);
        tbQuantity.SetFontName(fontName);
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
        columnUnitCost.DataPropertyName = nameof(DisplayStockModel.UnitCostAtTime);
    }

    public string SearchText {
        get => searchBar.SearchText;
        set => searchBar.SearchText = value;
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

    public string DataGridText {
        get => lblError.Text;
        set {
            lblError.Text = value;
            lblError.Visible = lblError.Text != "";
        }
    }

    public string StockName {
        get => tbName.Text;
        set => tbName.Text = value;
    }

    public string StockDescription {
        get => tbDescription.Text;
        set => tbDescription.Text = value;
    }

    public int Quantity {
        get => nudQuantity.Value;
        set {
            nudQuantity.Value = value;
            tbQuantity.Text = value.ToString();
        }
    }

    public decimal Subtotal {
        set => tbSubtotal.Text = value.ToString("C", new CultureInfo("en-GB"));
    }

    public decimal Total {
        set => tbTotal.Text = value.ToString("C", new CultureInfo("en-GB"));
    }

    public bool Editable {
        get => tbName.ReadOnly;
        set {
            nudQuantity.Visible = value;
            tbQuantity.Visible = !value;
        }
    }

    public void DisplayItems(BindingList<DisplayStockModel> items) {
        dataGridView.SuspendLayout();
        _bindingSource.DataSource = items;
        dataGridView.ResumeLayout();
    }

    public void DisableAll() {
        searchBar.Enabled = false;
        dataGridView.Enabled = false;
        nudQuantity.Enabled = false;
    }

    public void EnableAll() {
        searchBar.Enabled = true;
        dataGridView.Enabled = true;
        nudQuantity.Enabled = true;
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
        dataGridView.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = isAscending ? SortOrder.Ascending : SortOrder.Descending;

        SortRequestEventArgs sortRequestEventArgs = new(dataGridView.Columns[e.ColumnIndex].Name, isAscending);
        SortRequested?.Invoke(this, sortRequestEventArgs);
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }

    private void pnlData_Resize(object sender, EventArgs e) {
        searchBar.Width = pnlData.Width * 4 / 5;
        searchBar.Location = new Point(pnlData.Location.X + (pnlData.Width - searchBar.Width) / 2, searchBar.Location.Y);
        Invalidate();
    }
}
