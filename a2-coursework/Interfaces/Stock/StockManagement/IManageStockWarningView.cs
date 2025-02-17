namespace a2_coursework.Interfaces.Stock.StockManagement;
public interface IManageStockWarningView : IChildView
{
    public event EventHandler? LowQuantityChanged;
    public event EventHandler? HighQuantityChanged;

    public int LowQuantity { get; set; }
    public int HighQuantity { get; set; }
}
