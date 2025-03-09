using a2_coursework.Interfaces.Stock.StockManagement;

namespace a2_coursework.Presenter.Stock.StockManagement;

public class ManageStockUnitCostPresenter : BasePresenter<IManageStockUnitCostView>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public ManageStockUnitCostPresenter(IManageStockUnitCostView view) : base(view) {
        _view.UnitCostChanged += OnUnitCostChanged;
    }

    private void OnUnitCostChanged(object? sender, EventArgs e) => DetailsChanged?.Invoke(this, EventArgs.Empty);

    public decimal UnitCost {
        get => _view.UnitCost;
        set => _view.UnitCost = value;
    }
}
