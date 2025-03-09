namespace a2_coursework.Interfaces.Stock.StockManagement; 
public interface IManageStockUnitCostView : IChildView {
    public event EventHandler? UnitCostChanged;

    public decimal UnitCost { get; set; }
}