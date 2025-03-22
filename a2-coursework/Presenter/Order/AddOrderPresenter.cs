using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Order;
using a2_coursework.Model.Order;
using a2_coursework.Model.Staff;
using a2_coursework.Model.Stock;
using a2_coursework.View.Order;

namespace a2_coursework.Presenter.Order;
public class AddOrderPresenter : AddPresenter<IAddOrderView, OrderModel>, IChildPresenter, INavigatingPresenter {
    private readonly StaffModel _staff;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public AddOrderPresenter(IAddOrderView view, StaffModel staff) : base(view, new(-1, "Draft", "", "") { Staff = staff }) {
        _staff = staff;

        _view.Back += OnBack;

        _viewFactories.Add(GetSelectStock);
        _viewFactories.Add(GetManageOptions);
        _viewFactories.Add(GetSubmit);

        NavigateToCurrentView();
    }

    private void OnBack(object? sender, EventArgs e) => NavigateBack();

    private void NavigateBack() {
        if (!CanExit()) return;
        (IChildView view, IChildPresenter presenter) = OrderFactory.CreateDisplayOrder(_staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void BindValidation(ICleanable presenter) {
        if (_childPresenter is SubmitOrderPresenter submitPresenter) submitPresenter.Submit += OnSubmit;
    }

    protected override void UnBindValidation(ICleanable presenter) { 
        if (_childPresenter is SubmitOrderPresenter submitPresenter) submitPresenter.Submit -= OnSubmit;
    }

    #region Select Stock
    private (IChildView childView, ICleanable childPresenter) GetSelectStock() {
        (SelectOrderStockView view, SelectOrderStockPresenter presenter) = OrderFactory.CreateSelectOrderStock();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesSelectOrderStock(presenter);
        ValidateCurrent = () => ValidateInputsSelectOrderStock(presenter);
        UpdateModelCurrent = () => UpdateModelSelectOrderStock(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesSelectOrderStock(SelectOrderStockPresenter presenter) {
        presenter.SelectedStockItems = _model.StockItems;
    }

    private bool ValidateInputsSelectOrderStock(SelectOrderStockPresenter presenter) {
        if (presenter.SelectedStockItems.Count == 0) {
            //_view.ShowMessageBox("Please select at least one cleaning option", "No options selected", MessageBoxButtons.OK);
            return false;
        }
        else return true;
    }

    private void UpdateModelSelectOrderStock(SelectOrderStockPresenter presenter) {
        _model.StockItems = [.. _model.StockItems.Where(y => presenter.SelectedStockItems.Any(x => x.Id == y.Id))];

        foreach (StockModel stockItem in presenter.SelectedStockItems) {
            if (!_model.StockItems.Any(x => stockItem.Id == x.Id)) {
                _model.StockItems.Add(stockItem);
                stockItem.Quantity = 1;
                stockItem.CostAtTime = stockItem.UnitCost;
            }
        }
    }
    #endregion

    #region Manage Stock
    private (IChildView childView, ICleanable childPresenter) GetManageOptions() {
        (ManageOrderStockView view, ManageOrderStockPresenter presenter) = OrderFactory.CreateManageOrderStock();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesManageOrderStock(presenter);
        ValidateCurrent = () => ValidateInputsManageOrderStock(presenter);
        UpdateModelCurrent = () => UpdateModelManageOrderStock(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesManageOrderStock(ManageOrderStockPresenter presenter) {
        presenter.Models = _model.StockItems;
    }

    private bool ValidateInputsManageOrderStock(ManageOrderStockPresenter presenter) => true;

    private void UpdateModelManageOrderStock(ManageOrderStockPresenter  presenter) {
        foreach (StockModel model in _model.StockItems) {
            model.Quantity = presenter.NewQuantities[model.Id];
        }
    }
    #endregion

    #region Submit
    private (IChildView childView, ICleanable childPresenter) GetSubmit() {
        (SubmitOrderView view, SubmitOrderPresenter presenter) = OrderFactory.CreateSubmitOrder();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesSubmit(presenter);
        ValidateCurrent = () => ValidateInputsSubmit(presenter);
        UpdateModelCurrent = () => UpdateModelSubmit(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesSubmit(SubmitOrderPresenter presenter) {
        presenter.Description = _model.Description;
    }

    private bool ValidateInputsSubmit(SubmitOrderPresenter presenter) => true;

    private void UpdateModelSubmit(SubmitOrderPresenter presenter) {
        _model.Description = presenter.Description;
    }

    private void OnSubmit(object? sender, EventArgs e) {
        _model.Status = "Submitted";

        Done();
    }    
    #endregion

    public override void CleanUp() {
        _view.Back -= OnBack;

        base.CleanUp();
    }

    protected override void OnAddSuccessful() {
        (IChildView view, IChildPresenter presenter) = OrderFactory.CreateDisplayOrder(_staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override Task<bool> UpdateDatabase() => OrderDAL.CreateOrder(_model);
}
