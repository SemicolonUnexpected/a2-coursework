using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces.Stock;
public interface IStockDisplay :  IChildView {
    public event EventHandler? Add;
    public event EventHandler? Edit;
    public event EventHandler? ArchiveToggled;
    public event EventHandler? ShowArchivedChanged;
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;

    public string SearchText { get; set; }
    public string DataGridText { set; }
    public bool ShowArchivedStockItem { get; }
    public bool StockItemArchived { set; get; }
    public DataGridViewRow? SelectedRow { get; }

    public void DisplayData(List<object[]> data);
    public void RemoveRow(DataGridViewRow row);
    public void ClearData();
    public void DisableAll();
    public void EnableAll();
}
