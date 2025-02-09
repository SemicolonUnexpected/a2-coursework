using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces.Stock; 
public interface IStockQuantity : IThemeable {
    public event EventHandler? BulkAdd;
    public event EventHandler? BulkRemove;
    public event EventHandler? ReasonForQuantityChangeChanged;
    public event EventHandler? Save;
    public event EventHandler? Cancel;

    public int Quantity { get; set; }
    public int BulkAddQuantity { get; }
    public int BulkRemoveQuantity { get; }
    public string ReasonForQuantityChange { get; set; }

    public void SetCharacterCount(int number);

    public bool IsLoading { get; set; }
    public bool SaveVisible { get; set; }
}
