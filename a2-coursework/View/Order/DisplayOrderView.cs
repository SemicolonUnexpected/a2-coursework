﻿using a2_coursework._Helpers;
using a2_coursework.CustomControls;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Order;
using a2_coursework.Theming;
using System.ComponentModel;

namespace a2_coursework.View.Order; 
public partial class DisplayOrderView : Form, IDisplayView<DisplayOrderModel>, IChildView, IThemeable, IDisplayOrderView {
    private readonly BindingSource _bindingSource = [];

    public event EventHandler? Add;
    public event EventHandler? Edit;
    public event EventHandler? Delete;
    public event EventHandler? View;
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;
    public event EventHandler<SortRequestEventArgs>? SortRequested;
    public event EventHandler? CellDoubleCick;

    public DisplayOrderView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        topBar.Add += (s, e) => Add?.Invoke(this, EventArgs.Empty);
        topBar.Edit += (s, e) => Edit?.Invoke(this, EventArgs.Empty);
        topBar.Delete += (s, e) => Delete?.Invoke(this, EventArgs.Empty);
        topBar.Search += (s, e) => Search?.Invoke(this, EventArgs.Empty);
        topBar.SearchTextChanged += (s, e) => Search?.Invoke(this, EventArgs.Empty);
        topBar.View += (s, e) => View?.Invoke(this, EventArgs.Empty);
        dataGridView.SelectionChanged += (s, e) => SelectionChanged?.Invoke(this, EventArgs.Empty);
        dataGridView.CellDoubleClick += (s, e) => {
            if (topBar.ViewMode) View?.Invoke(this, EventArgs.Empty);
            else Edit?.Invoke(this, EventArgs.Empty);
        };

        _bindingSource.ListChanged += (s, e) => SetToolTipVisibility();

        SetupDataGrid();
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblOrders.ThemeTitle();
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
        lblOrders.SetFontName(fontName);
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

        columnId.DataPropertyName = nameof(DisplayOrderModel.Id);
        columnStaff.DataPropertyName = nameof(DisplayOrderModel.StaffName);
        columnStatus.DataPropertyName = nameof(DisplayOrderModel.Status);
    }

    public string SearchText {
        get => topBar.SearchText;
        set => topBar.SearchText = value;
    }

    private bool _upcoming = false;
    public bool Upcoming {
        get => _upcoming;
        set {
            _upcoming = value;

            lblOrders.Text = _upcoming ? "Upcoming Deliveries" : "Orders";
        }
    }

    public DisplayOrderModel? SelectedItem {
        get {
            try {
                return ((BindingList<DisplayOrderModel>)_bindingSource.DataSource)[dataGridView.SelectedRows[0].Index];
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

    public void DisplayItems(BindingList<DisplayOrderModel> items) {
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

    public bool ViewMode {
        set {
            topBar.ViewMode = value;
        }
    }

    public bool DeleteEnabled {
        set => topBar.DeleteEnabled = value;
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
        if (e.ColumnIndex == 2 && e.RowIndex >= 0) {
            Color foreColor = (e.Value as string) switch {
                "Draft" => ColorScheme.Current.Data,
                "Pending" => ColorScheme.Current.Warning,
                "Rejected" => ColorScheme.Current.Danger,
                "Delivered" => ColorScheme.Current.Info,
                "Submitted" => ColorScheme.Current.Other,
                _ => throw new ArgumentOutOfRangeException(nameof(e)),
            };

            e.CellStyle!.ForeColor = foreColor;
            e.CellStyle.SelectionForeColor = foreColor;
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
        dataGridView.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = isAscending ? SortOrder.Ascending : SortOrder.Descending;

        SortRequestEventArgs sortRequestEventArgs = new(dataGridView.Columns[e.ColumnIndex].Name, isAscending);
        SortRequested?.Invoke(this, sortRequestEventArgs);
    }

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK) => CustomMessageBox.Show(text, caption, buttons);

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
