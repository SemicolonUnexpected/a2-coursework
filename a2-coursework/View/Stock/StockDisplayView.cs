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
    public event EventHandler? ShowArchivedToggled;
    public event EventHandler? Search;
    public event EventHandler? PageChanged;
    public event EventHandler? SelectedRowChanged;
    public event EventHandler? DataGridResized;
    public event ColumnClickEventHandler ColumnClick;
    public event EventHandler? NameOrder;
    public event EventHandler? QuantityLevelOrder;

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
        topBar.ShowArchivedToggled += (s, e) => ShowArchivedToggled?.Invoke(this, EventArgs.Empty);

        paginator.PageChanged += (s, e) => PageChanged?.Invoke(this, EventArgs.Empty);
    }

    public void SetPresenter(StockDisplayPresenter presenter) => _presenter = presenter;

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        lblStock.ThemeTitle();
        lblStockResult.ThemeSubtitle();

        topBar.Theme();
        pnlData.Theme();
        dataGridView.Theme();
        paginator.Theme();
    }

    private void SetFont() {
        string fontName = Theming.Theme.CurrentTheme.FontName;

        topBar.SetFontName(fontName);
        dataGridView.SetFontName(fontName);
        paginator.SetFontName(fontName);
        lblStock.SetFontName(fontName);
        lblStockResult.SetFontName(fontName);
    }

    public string SearchText {
        get => topBar.SearchText;
        set => topBar.SearchText = value;
    }

    public string StockResultText {
        get => lblStockResult.Text;
        set => lblStockResult.Text = value;
    }

    public bool ShowNoStocksToDisplay {
        get => lblStockResult.Visible;
        set => lblStockResult.Visible = value;
    }

    public int CurrentPageNumber {
        get => paginator.CurrentPageNumber;
        set => paginator.CurrentPageNumber = value;
    }

    public int NumberOfPages {
        get => paginator.NumberOfPages;
        set => paginator.NumberOfPages = value;
    }

    public int SelectedRow {
        get => dataGridView.SelectedRows[0].Index;
        set => dataGridView.Rows[value].Selected = true;
    }

    public bool EditVisible { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool ArchiveVisible { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public int DisplayHeight => dataGridView.Height - dataGridView.ColumnHeadersHeight;

    public int RowHeight => dataGridView.RowTemplate.Height;

    public bool EditEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool ArchiveEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool ShowArchived { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void DisplayStock(List<object[]> data) {
        dataGridView.Rows.Clear();
        foreach (object[] row in data) {
            dataGridView.Rows.Add(row);
        }
    }

    private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
        // Quantiity level is at index 4, row indexes start at 0 with the column header being index -1. Tiny bit odd
        if (e.ColumnIndex == 4 && e.RowIndex >= 0) {
            if (e.Value is string quantityLevel) {
                if (quantityLevel == "Low") e.CellStyle.ForeColor = ColorScheme.CurrentTheme.Danger;
                else if (quantityLevel == "Medium") e.CellStyle.ForeColor = ColorScheme.CurrentTheme.Warning;
                else if (quantityLevel == "High") e.CellStyle.ForeColor = ColorScheme.CurrentTheme.Info;
                
            }
        }
    }
}
