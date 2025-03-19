using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Order;
using a2_coursework.Model.Order;
using a2_coursework.Model.Staff;
using a2_coursework.Model.Stock;
using a2_coursework.View.Order;
using System.Linq;

namespace a2_coursework.Presenter.Order;

public class ReceiveOrderPresenter : AddPresenter<IAddOrderView, OrderModel>, IChildPresenter, INavigatingPresenter {
    private readonly List<StockModel> _orderStock;
    private readonly StaffModel _staff;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public ReceiveOrderPresenter(IAddOrderView view, OrderModel model, StaffModel staff) : base(view, model) {
        _staff = staff;

        _view.Back += OnBack;

        _orderStock = [.. model.StockItems.Select(x => new StockModel(x.Name, x.Description, x.Id, x.Sku, x.Quantity, x.LowQuantity, x.HighQuantity, x.Archived, x.UnitCost))];

        _viewFactories.Add(GetManageOptions);
        _viewFactories.Add(GetDiscrepancies);

        NavigateToCurrentView();
    }

    private void OnBack(object? sender, EventArgs e) => NavigateBack();

    private void NavigateBack() {
        if (!CanExit()) return;
        (IChildView view, IChildPresenter presenter) = OrderFactory.CreateDisplayOrder(_staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void BindValidation(ICleanable presenter) { }

    protected override void UnBindValidation(ICleanable presenter) { }

    #region Manage Stock
    private (IChildView childView, ICleanable childPresenter) GetManageOptions() {
        (ManageOrderStockView view, ManageOrderStockPresenter presenter) = OrderFactory.CreateManageOrderStock();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesManageOrderStock(presenter);
        ValidateCurrent = () => true;
        UpdateModelCurrent = () => UpdateModelManageOrderStock(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesManageOrderStock(ManageOrderStockPresenter presenter) {
        presenter.Models = _orderStock;
    }

    private void UpdateModelManageOrderStock(ManageOrderStockPresenter presenter) {
        foreach (StockModel model in _orderStock) {
            model.Quantity = presenter.NewQuantities[model.Id];
        }
    }
    #endregion

    #region Discrepancies
    private (IChildView childView, ICleanable childPresenter) GetDiscrepancies() {
        (ManageOrderDiscrepanciesView view, ManageOrderDiscrepanciesPresenter presenter) = OrderFactory.CreateOrderDiscrepancies();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesManageOrderDiscrepanciesStock(presenter);
        ValidateCurrent = () => true;
        UpdateModelCurrent = () => UpdateModelManageOrderDiscrepancies(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesManageOrderDiscrepanciesStock(ManageOrderDiscrepanciesPresenter presenter) {
        presenter.Discrepancies = _model.Discrepancies;
    }

    private void UpdateModelManageOrderDiscrepancies(ManageOrderDiscrepanciesPresenter presenter) {
        _model.Discrepancies = presenter.Discrepancies;
    }
    #endregion

    protected override Task<bool> UpdateDatabase() {
        return OrderDAL.ReceiveOrder(_model.Id, _orderStock.ToDictionary(x => x.Id, y => (_model.StockItems.FirstOrDefault(z => z.Id == y.Id)?.Quantity ?? 0) + y.Quantity), _model.Staff!.Id, _model.Discrepancies);
    }

    protected override void OnAddSuccessful() {
        _view.ShowMessageBox("Updated stock quantities.", "Delivery saved", MessageBoxButtons.OK);

        (IChildView view, IChildPresenter presenter) = OrderFactory.CreateDisplayOrder(_staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }
}
