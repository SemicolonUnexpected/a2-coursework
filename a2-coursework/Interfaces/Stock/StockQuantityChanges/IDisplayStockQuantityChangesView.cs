using a2_coursework.View;
using a2_coursework.View.Stock.StockQuantityChanges;

namespace a2_coursework.Interfaces.Stock.StockQuantityChanges;
public interface IDisplayStockQuantityChangesView : IDisplayView<DisplayStockQuantityChange>, IView {
    public event EventHandler? View;
    public event EventHandler? ShowArchivedChanged;
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public string SearchText { get; set; }
    public string DataGridText { set; }
    public bool ShowArchivedItems { get; }
    public DisplayStockQuantityChange? SelectedItem { get; }

    public void DisableAll();
    public void EnableAll();
}
