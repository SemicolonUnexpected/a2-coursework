using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Order;
using a2_coursework.Model.Order;
using a2_coursework.Model.Staff;
using a2_coursework.Model.Stock;
using a2_coursework.View.Order;

namespace a2_coursework.Presenter.Order;
public class EditOrderPresenter : ParentEditPresenter<IEditOrderView, OrderModel>, IChildPresenter, INavigatingPresenter {
    private readonly StaffModel _staff;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public EditOrderPresenter(IEditOrderView view, OrderModel model, StaffModel staff) : base(view, model) {
        _staff = staff;

        _view.Back += OnBack;

        Navigate(GetSelectStock());
    }

    private void OnBack(object? sender, EventArgs e) => NavigateBack();

    private void NavigateBack() {
        if (!CanExit()) return;
        (IChildView view, IChildPresenter presenter) = OrderFactory.CreateDisplayOrder(_staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void BindValidation() {
        if (_childPresenter is SubmitOrderPresenter submitPresenter) submitPresenter.Submit += OnSubmit;
    }

    protected override void UnBindValidation() { 
        if (_childPresenter is SubmitOrderPresenter submitPresenter) submitPresenter.Submit -= OnSubmit;
    }

    protected override (IChildView childView, INotifyingChildPresenter childPresenter) GetView(string selectedItem) => selectedItem switch {
        "Stock" => GetSelectStock(),
        "Quantity" => GetManageOptions(),
        "Submit" => GetSubmit(),
        _ => throw new NotImplementedException(),
    };

    #region Select Stock
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetSelectStock() {
        (SelectOrderStockView view, SelectOrderStockPresenter presenter) = OrderFactory.CreateSelectOrderStock();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesSelectOrderStock(presenter);
        AnyChangesCurrent = () => AnyChangesSelectOrderStock(presenter);
        ValidateCurrent = () => ValidateInputsSelectOrderStock(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseSelectOrderStock(presenter);
        UpdateModelCurrent = () => UpdateModelSelectOrderStock(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesSelectOrderStock(SelectOrderStockPresenter presenter) {
        presenter.SelectedStockItems = _model.StockItems;
    }

    private bool AnyChangesSelectOrderStock(SelectOrderStockPresenter presenter) {
        List<int> a = presenter.SelectedStockItems.ConvertAll(x => x.Id);
        List<int> b = _model.StockItems.ConvertAll(x => x.Id);

        if (a.Count != b.Count) return true;

        return !a.All(b.Contains);
    }

    private bool ValidateInputsSelectOrderStock(SelectOrderStockPresenter presenter) {
        if (presenter.SelectedStockItems.Count == 0) {
            //_view.ShowMessageBox("Please select at least one cleaning option", "No options selected", MessageBoxButtons.OK);
            return false;
        }
        else return true;
    }

    private Task<bool> UpdateDatabaseSelectOrderStock(SelectOrderStockPresenter presenter) => OrderDAL.UpdateOrderStock(_model.Id, presenter.SelectedStockItems);

    private void UpdateModelSelectOrderStock(SelectOrderStockPresenter presenter) {
        _model.StockItems = [.. _model.StockItems.Where(y => presenter.SelectedStockItems.Any(x => x.Id == y.Id))];

        foreach (StockModel stockItem in presenter.SelectedStockItems) {
            if (!_model.StockItems.Any(x => stockItem.Id == x.Id)) {
                _model.StockItems.Add(stockItem);
                stockItem.Quantity = 1;
            }
        }
    }
    #endregion

    #region Manage Stock
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetManageOptions() {
        (ManageOrderStockView view, ManageOrderStockPresenter presenter) = OrderFactory.CreateManageOrderStock();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesManageOrderStock(presenter);
        AnyChangesCurrent = () => AnyChangesManageOrderStock(presenter);
        ValidateCurrent = () => ValidateInputsManageOrderStock(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseManageOrderStock(presenter);
        UpdateModelCurrent = () => UpdateModelManageOrderStock(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesManageOrderStock(ManageOrderStockPresenter presenter) {
        presenter.Models = _model.StockItems;
    }

    private bool AnyChangesManageOrderStock(ManageOrderStockPresenter presenter) {
        Dictionary<int, int> a = presenter.NewQuantities;
        Dictionary<int, int> b = _model.StockItems.ToDictionary(x => x.Id, x => x.Quantity);

        return a.Keys.Any(x => b.ContainsKey(x) && a[x] != b[x]);
    }

    private bool ValidateInputsManageOrderStock(ManageOrderStockPresenter presenter) => true;

    private Task<bool> UpdateDatabaseManageOrderStock(ManageOrderStockPresenter presenter) => OrderDAL.UpdateOrderStockQuantities(_model.Id, presenter.NewQuantities.Select(x => (x.Key, x.Value)));

    private void UpdateModelManageOrderStock(ManageOrderStockPresenter  presenter) {
        foreach (StockModel model in _model.StockItems) {
            model.Quantity = presenter.NewQuantities[model.Id];
        }
    }
    #endregion

    #region Submit
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetSubmit() {
        (SubmitOrderView view, SubmitOrderPresenter presenter) = OrderFactory.CreateSubmitOrder();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesSubmit(presenter);
        AnyChangesCurrent = () => AnyChangesSubmit(presenter);
        ValidateCurrent = () => ValidateInputsSubmit(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseSubmit(presenter);
        UpdateModelCurrent = () => UpdateModelSubmit(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesSubmit(SubmitOrderPresenter presenter) {
        presenter.Description = _model.Description;
    }

    private bool AnyChangesSubmit(SubmitOrderPresenter presenter) => presenter.Description != _model.Description;

    private bool ValidateInputsSubmit(SubmitOrderPresenter presenter) => true;

    private Task<bool> UpdateDatabaseSubmit(SubmitOrderPresenter presenter) => OrderDAL.UpdateOrderDescription(_model.Id, presenter.Description);

    private void UpdateModelSubmit(SubmitOrderPresenter presenter) {
        _model.Description = presenter.Description;
    }

    private async void OnSubmit(object? sender, EventArgs e) {
        if ((AnyChangesCurrent?.Invoke() ?? false) && (ValidateCurrent?.Invoke() ?? true)) {
            UpdateDatabaseCurrent?.Invoke().ContinueWith(task => {
                if (task.Result) UpdateModelCurrent?.Invoke();
                else {
                    _view.ShowMessageBox("Error updating the database", "Error", MessageBoxButtons.OK);
                    return;
                }
            });
        }

        try {
            bool success = await OrderDAL.SubmitOrder(_model.Id);
            if (success) {
                _view.ShowMessageBox("Order submitted successfully", "Success", MessageBoxButtons.OK);
                NavigateBack();
            }
            else _view.ShowMessageBox("Error submitting the order", "Error", MessageBoxButtons.OK);
        }
        catch {
            _view.ShowMessageBox("Error submitting the order", "Error", MessageBoxButtons.OK);
        }
    }    
    #endregion

    public override void CleanUp() {
        _view.Back -= OnBack;

        base.CleanUp();
    }
}
