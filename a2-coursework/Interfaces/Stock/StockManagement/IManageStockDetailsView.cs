namespace a2_coursework.Interfaces.Stock.StockManagement;
public interface IManageStockDetailsView : IChildView {
    public event EventHandler? DescriptionChanged;
    public event EventHandler? NameChanged;
    public event EventHandler? SKUChanged;
    public event EventHandler? ArchivedChanged;

    public string StockName { get; set; }
    public string Description { get; set; }
    public string SKU { get; set; }
    public bool Archived { get; set; }

    public void SetCharacterCount(int number);

    public string NameSKUError { set; }
    public void SetNameBorderError(bool isError);
    public void SetSKUBorderError(bool isError);
}
