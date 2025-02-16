using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces.Stock; 
public interface IManageStockQuantityView : IChildView {
    public event EventHandler? BulkAdd;
    public event EventHandler? BulkRemove;
    public event EventHandler? ReasonForQuantityChangeChanged;

    public int Quantity { get; set; }
    public int BulkAddQuantity { get; }
    public int BulkRemoveQuantity { get; }
    public string ReasonForQuantityChange { get; set; }

    public void SetCharacterCount(int number);
}
