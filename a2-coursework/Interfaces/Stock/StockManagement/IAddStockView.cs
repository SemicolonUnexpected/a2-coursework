namespace a2_coursework.Interfaces.Stock.StockManagement;
public interface IAddStockView : IAddView {
    public string Title { get; set; }
    public event EventHandler? Back;
}
