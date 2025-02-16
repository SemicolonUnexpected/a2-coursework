namespace a2_coursework.View.Interfaces.Stock; 
public interface IManageStockWarningView : IChildView {
    public event EventHandler? LowQuantityChanged;
    public event EventHandler? HighQuantityChanged;

    public int LowQuantity { get; set; }
    public int HighQuantity { get; set; }
}
