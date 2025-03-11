using a2_coursework.View;
using a2_coursework.View.Stock.StockManagement;

namespace a2_coursework.Interfaces.Order;

public interface ISelectOrderStockView : IDisplayView<DisplayStockModel> {
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public string DataGridText { get; set; }
    public List<DisplayStockModel> SelectedItems { get; }

    public void DisableAll();
    public void EnableAll();
    public void SetSelectedItemsById(IEnumerable<int> models);
}
