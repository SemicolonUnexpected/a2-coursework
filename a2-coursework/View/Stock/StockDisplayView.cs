using a2_coursework._Helpers;
using a2_coursework.Model;
using a2_coursework.Presenter.Stock;
using a2_coursework.Theming;
using a2_coursework.View.Interfaces.Stock;
namespace a2_coursework.View;
public partial class StockDisplayView : Form, IStockDisplay {
    private StockDisplayPresenter? _presenter;

    public event EventHandler? Add;
    public event EventHandler? Edit;
    public event EventHandler? ArchiveToggled;
    public event EventHandler? ShowArchivedChanged;
    public event EventHandler? Search;

    public StockDisplayView() {
        InitializeComponent();

        columnID.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        columnQuantity.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        columnArchived.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        columnQuantityLevel.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        Theme();
        Theming.Theme.AppearanceThemeChanged += (s, e) => Theme();

        SetFont();
        Theming.Theme.FontNameChanged += (s, e) => SetFont();

        topBar.Add += (s, e) => Add?.Invoke(this, EventArgs.Empty);
        topBar.Edit += (s, e) => Edit?.Invoke(this, EventArgs.Empty);
        topBar.ArchiveToggled += (s, e) => ArchiveToggled?.Invoke(this, EventArgs.Empty);
        topBar.ShowArchivedToggled += (s, e) => ShowArchivedChanged?.Invoke(this, EventArgs.Empty);
        topBar.Search += (s, e) => Search?.Invoke(this, EventArgs.Empty);

        dataGridView.MouseWheel += (s, e) => {
            sb.Value += e.Delta;
        };
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

    public int SelectedRow {
        get => dataGridView.SelectedRows[0].Index;
        set => dataGridView.Rows[value].Selected = true;
    }

    public bool ShowArchived {
        get => topBar.ShowArchived;
    }

    public string ErrorText {
        get => lblError.Text;
    }

    public void DisplayStock(List<object[]> data) {
        dataGridView.Rows.Clear();
        foreach (object[] row in data) {
            dataGridView.Rows.Add(row);
        }

        lblError.Visible = data.Count == 0;

        SetScrollOptions();
    }

    private void SetScrollOptions() {
        int numberOfVisibleRows = (dataGridView.Height - dataGridView.ColumnHeadersHeight) / dataGridView.RowTemplate.Height;

        sb.Maximum = dataGridView.RowCount - numberOfVisibleRows - 1;
        sb.LargeChange = numberOfVisibleRows;
    }

    private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
        // Quantiity level is at index 4, row indexes start at 0 with the column header being index -1. Tiny bit odd
        if (e.ColumnIndex == 4 && e.RowIndex >= 0) {
            if (e.Value is string quantityLevel) {
                if (quantityLevel == "Low") e.CellStyle!.ForeColor = ColorScheme.CurrentTheme.Danger;
                else if (quantityLevel == "Medium") e.CellStyle!.ForeColor = ColorScheme.CurrentTheme.Warning;
                else if (quantityLevel == "High") e.CellStyle!.ForeColor = ColorScheme.CurrentTheme.Info;

            }
        }
    }

    private void sb_ValueChanged(object sender, EventArgs e) {
        dataGridView.FirstDisplayedScrollingRowIndex = sb.Value;
    }

    private void dataGridView_Resize(object sender, EventArgs e) {
        SetScrollOptions();
    }
}
