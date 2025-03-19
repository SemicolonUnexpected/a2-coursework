using a2_coursework._Helpers;
using a2_coursework.CustomControls;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Order;
using a2_coursework.Theming;
using System.ComponentModel;

namespace a2_coursework.View.Order; 
public partial class ApproveRejectOrderView : Form, IDisplayView<DisplayOrderModel>, IChildView, IThemeable, IApproveRejectOrderView {
    private readonly BindingSource _bindingSource = [];

    public event EventHandler? View;
    public event EventHandler? Approve;
    public event EventHandler? Reject;
    public event EventHandler? Search;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public ApproveRejectOrderView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        topBar.View += (s, e) => View?.Invoke(this, EventArgs.Empty);
        topBar.Approve += (s, e) => Approve?.Invoke(this, EventArgs.Empty);
        topBar.Reject += (s, e) => Reject?.Invoke(this, EventArgs.Empty);
        topBar.SearchTextChanged += (s, e) => Search?.Invoke(this, EventArgs.Empty);

        SetupDataGrid();
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblOrders.ThemeTitle();
        lblError.ThemeSubtitle();

        pnlData.Theme();
        dataGridView.Theme();
        sb.Theme();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        foreach (DataGridViewColumn column in dataGridView.Columns) {
            column.ToolTipText = showToolTips ? "Left click to sort ascending\nRight click to sort descending" : "";
        }

        topBar.SetToolTipVisibility();
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

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
                _ => throw new ArgumentOutOfRangeException(nameof(e.Value)),
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
