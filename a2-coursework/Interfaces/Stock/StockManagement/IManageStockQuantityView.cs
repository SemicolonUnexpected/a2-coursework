namespace a2_coursework.Interfaces.Stock.StockManagement;
public interface IManageStockQuantityView : IChildView
{
    public event EventHandler? BulkAdd;
    public event EventHandler? BulkRemove;
    public event EventHandler? ReasonForQuantityChangeChanged;
    public event EventHandler? QuantityChanged;

    public int Quantity { get; set; }
    public int BulkAddQuantity { get; set; }
    public int BulkRemoveQuantity { get; set; }
    public string ReasonForQuantityChange { get; set; }

    public void SetCharacterCount(int number);
}
