using a2_coursework.Model.Stock;
using a2_coursework.View;
using a2_coursework.View.Stock.StockManagement;

namespace a2_coursework.Interfaces.Order;

public interface IManageOrderStockView : IDisplayView<DisplayStockModel>, IChildView {
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;
    public event EventHandler? QuantityChanged;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public string SearchText { get; set; }
    public DisplayStockModel? SelectedItem { get; }
    public string DataGridText { get; set; }

    public string StockName { get; set; }
    public string StockDescription { get; set; }
    public int Quantity { get; set; }
    public decimal Subtotal { set; }
    public decimal Total { set; }
    public bool Editable { get; set; }

    public void DisableAll();
    public void EnableAll();
}
