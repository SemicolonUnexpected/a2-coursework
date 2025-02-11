using a2_coursework._Helpers;
using a2_coursework.Presenter.Stock;
using a2_coursework.Theming;
using a2_coursework.View.Interfaces.Stock;
using System.ComponentModel;
using System.Diagnostics;
namespace a2_coursework.View;
public partial class StockDisplayView : Form, IStockDisplay {
    private StockDisplayPresenter? _presenter;

    public event EventHandler? Add;
    public event EventHandler? Edit;
    public event EventHandler? ArchiveToggled;
    public event EventHandler? ShowArchivedChanged;
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;

    public StockDisplayView() {
        InitializeComponent();

        columnID.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        columnQuantity.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        columnArchived.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        columnQuantityLevel.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        float scalingFactor = DeviceDpi / 96f;
        dataGridView.ColumnHeadersHeight = (int)(40 * scalingFactor);
        dataGridView.RowTemplate.Height = (int)(30 * scalingFactor);

        Theme();
        Theming.Theme.AppearanceThemeChanged += (s, e) => Theme();

        SetFont();
        Theming.Theme.FontNameChanged += (s, e) => SetFont();

        topBar.Add += (s, e) => Add?.Invoke(this, EventArgs.Empty);
        topBar.Edit += (s, e) => Edit?.Invoke(this, EventArgs.Empty);
        topBar.ArchiveToggled += (s, e) => ArchiveToggled?.Invoke(this, EventArgs.Empty);
        topBar.ShowArchivedToggled += (s, e) => ShowArchivedChanged?.Invoke(this, EventArgs.Empty);
        topBar.Search += (s, e) => Search?.Invoke(this, EventArgs.Empty);
        topBar.SearchTextChanged += (s, e) => Search?.Invoke(this, EventArgs.Empty);

        dataGridView.MouseWheel += (s, e) => {
            sb.Value -= Math.Sign(e.Delta);
            sb.Refresh();
        };

        dataGridView.SelectionChanged += (s, e) => SelectionChanged?.Invoke(this, EventArgs.Empty);
    }

    public void SetPresenter(StockDisplayPresenter presenter) => _presenter = presenter;

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        lblStock.ThemeTitle();
        lblError.ThemeSubtitle();

        topBar.Theme();
        pnlData.Theme();
        dataGridView.Theme();
        sb.Theme();
    }

    private void SetFont() {
        string fontName = Theming.Theme.CurrentTheme.FontName;

        topBar.SetFontName(fontName);
        dataGridView.SetFontName(fontName);
        lblStock.SetFontName(fontName);
        lblError.SetFontName(fontName);
    }

    public string SearchText {
        get => topBar.SearchText;
        set => topBar.SearchText = value;
    }

    public DataGridViewRow? SelectedRow {
        get {
            try {
                return dataGridView.SelectedRows[0];
            }
            catch (ArgumentOutOfRangeException) {
                return null;
            }
        }
    }

    public bool ShowArchivedStockItem {
        get => topBar.ShowArchived;
    }

    public string DataGridText {
        get => lblError.Text;
        set {
            lblError.Text = value;
            lblError.Visible = lblError.Text != "";
        }
    }

    public bool StockItemArchived {
        get => topBar.Restore;
        set => topBar.Restore = value;
    }

    public void DisplayData(List<object[]> data) {
        dataGridView.SuspendLayout();
        foreach (object[] row in data) {
            dataGridView.Rows.Add(row);
        }
        dataGridView.ResumeLayout();

        SetScrollOptions();
    }

    public void RemoveRow(DataGridViewRow row) {
        dataGridView.Rows.Remove(row);
    }

    public void ClearData() {
        dataGridView.Rows.Clear();

        SetScrollOptions();
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

    public bool DockInParent => true;

    public bool CanExit() => true;
}
