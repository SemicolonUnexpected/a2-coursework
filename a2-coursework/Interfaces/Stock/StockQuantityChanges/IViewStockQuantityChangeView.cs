namespace a2_coursework.Interfaces.Stock.StockQuantityChanges;
public interface IViewStockQuantityChangeView : IChildView {
    public event EventHandler? Back;

    public string Username { set; }
    public string StockName { set; }
    public int Quantity { set; }
    public DateTime DateOfChange { set; }
    public string ReasonForQuantityChange { set; }
}
