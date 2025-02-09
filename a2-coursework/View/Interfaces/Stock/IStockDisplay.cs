using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces.Stock;
public interface IStockDisplay : IThemeable {
    public event EventHandler? Add;
    public event EventHandler? Edit;
    public event EventHandler? ArchiveToggled;
    public event EventHandler? ShowArchivedToggled;

    public event EventHandler? PageChanged;

    public event EventHandler? SelectedRowChanged;
    public event EventHandler? DataGridResized;
    public event ColumnClickEventHandler ColumnClick;

    public event EventHandler? Search;
    public event EventHandler? NameOrder;
    public event EventHandler? QuantityLevelOrder;


    public string SearchText { get; set; }
    public bool EditEnabled { get; set; }
    public bool ArchiveEnabled { get; set; }
    public bool ShowArchived { get; set; }

    public int CurrentPageNumber { get; set; }
    public int NumberOfPages { get; set; }

    public int SelectedRow { get; set; }
    public int DisplayHeight { get; }
    public int RowHeight { get; }
    public bool ShowNoStocksToDisplay { get; set; }

    public void DisplayStock(List<object[]> data);
}
