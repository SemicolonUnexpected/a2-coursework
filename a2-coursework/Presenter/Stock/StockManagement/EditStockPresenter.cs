using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Stock.StockManagement;
using a2_coursework.Model.Staff;
using a2_coursework.Model.Stock;
using a2_coursework.View.Stock;
using a2_coursework.View.Stock.StockManagement;

namespace a2_coursework.Presenter.Stock.StockManagement;
public class EditStockPresenter : ParentEditPresenter<IEditStockView, StockModel>, IChildPresenter, INavigatingPresenter {
    private readonly StaffModel _staff;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public EditStockPresenter(IEditStockView view, StockModel stockItem, StaffModel staff) : base(view, stockItem) {
        _staff = staff;

        _view.Back += OnBack;

        Navigate(GetStockDetails());
    }

    private void OnValidateSku(object? sender, ValidationRequestEventArgs<string> e) => IsValidSku(e);
    private void OnBack(object? sender, EventArgs e) => NavigateBack();

    private void NavigateBack() {
        if (!CanExit()) return;
        (IChildView view, IChildPresenter presenter) = StockFactory.CreateStockDisplay(_staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void BindValidation() {
        if (_childPresenter is ManageStockDetailsPresenter manageStockDetailsPresenter) manageStockDetailsPresenter.ValidateSkuRequest += OnValidateSku;
    }

    protected override void UnBindValidation() {
        if (_childPresenter is ManageStockDetailsPresenter manageStockDetailsPresenter) manageStockDetailsPresenter.ValidateSkuRequest -= OnValidateSku;
    }

    protected override (IChildView childView, INotifyingChildPresenter childPresenter) GetView(string selectedItem) => selectedItem switch {
        "Stock Details" => GetStockDetails(),
        "Quantity" => GetStockQuantity(),
        "Warnings" => GetStockWarning(),
        "Unit Cost" => GetStockUnitCost(),
        _ => throw new NotImplementedException(),
    };

    #region Stock Quantity

    private (IChildView childView, INotifyingChildPresenter childPresenter) GetStockQuantity() {
        (ManageStockQuantityView view, ManageStockQuantityPresenter presenter) = StockFactory.CreateManageStockQuantity();

        presenter.Quantity = _model.Quantity;

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesStockQuantity(presenter);
        AnyChangesCurrent = () => AnyChangesStockQuantity(presenter);
        ValidateCurrent = () => true;
        UpdateDatabaseCurrent = () => UpdateDatabaseStockQuantity(presenter);
        UpdateModelCurrent = () => UpdateModelStockQuantity(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesStockQuantity(ManageStockQuantityPresenter presenter) {
        presenter.Quantity = _model.Quantity;
        presenter.ReasonForQuantityChange = "";
    }

    private bool AnyChangesStockQuantity(ManageStockQuantityPresenter presenter) => presenter.Quantity != _model.Quantity;

    private Task<bool> UpdateDatabaseStockQuantity(ManageStockQuantityPresenter presenter) => StockDAL.UpdateStockQuantity(_model.Id, _staff.Id, presenter.Quantity, DateTime.Now, presenter.ReasonForQuantityChange);

    private void UpdateModelStockQuantity(ManageStockQuantityPresenter presenter) {
        _model.Quantity = presenter.Quantity;

        PopulateDefaultValuesStockQuantity(presenter);
    }

    #endregion

    #region Stock Details

    private (IChildView childView, INotifyingChildPresenter childPresenter) GetStockDetails() {
        (ManageStockDetailsView view, ManageStockDetailsPresenter presenter) = StockFactory.CreateManageStockDetails();

        presenter.ValidateSkuRequest += OnValidateSku;

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesStockDetails(presenter);
        AnyChangesCurrent = () => AnyChangesStockDetails(presenter);
        ValidateCurrent = () => ValidateInputsStockDetails(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseStockDetails(presenter);
        UpdateModelCurrent = () => UpdateModelStockDetails(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesStockDetails(ManageStockDetailsPresenter presenter) {
        presenter.Name = _model.Name;
        presenter.Sku = _model.Sku;
        presenter.Description = _model.Description;
        presenter.Archived = _model.Archived;
    }

    private bool AnyChangesStockDetails(ManageStockDetailsPresenter presenter) {
        return presenter.Name != _model.Name || presenter.Sku != _model.Sku || presenter.Description != _model.Description || presenter.Archived != _model.Archived;
    }

    private bool ValidateInputsStockDetails(ManageStockDetailsPresenter presenter) => presenter.NameValid && presenter.SkuValid;

    private Task<bool> UpdateDatabaseStockDetails(ManageStockDetailsPresenter presenter) => StockDAL.UpdateStockDetails(_model.Id, presenter.Name, presenter.Description, presenter.Sku, presenter.Archived);

    private void UpdateModelStockDetails(ManageStockDetailsPresenter presenter) {
        _model.Name = presenter.Name;
        _model.Sku = presenter.Sku;
        _model.Description = presenter.Description;
        _model.Archived = presenter.Archived;
    }

    private void IsValidSku(ValidationRequestEventArgs<string> validateSKURequest) {
        string sku = validateSKURequest.Value;

        if (sku == _model.Sku) {
            validateSKURequest.SetValidation(true);
            return;
        }

        if (string.IsNullOrWhiteSpace(sku)) validateSKURequest.SetValidation(false, "Please fill in an SKU");
        else validateSKURequest.SetValidation(StockDAL.StockSkuExists(sku).ContinueWith(x => !x.Result), "This SKU already exists. Please pick a different one");
    }

    #endregion

    #region Stock Warning
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetStockWarning() {
        (ManageStockWarningView view, ManageStockWarningPresenter presenter) = StockFactory.CreateManageStockWarning();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesStockWarning(presenter);
        AnyChangesCurrent = () => AnyChangesStockWarning(presenter);
        ValidateCurrent = () => true;
        UpdateDatabaseCurrent = () => UpdateDatabaseStockWarning(presenter);
        UpdateModelCurrent = () => UpdateModelStockWarning(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesStockWarning(ManageStockWarningPresenter presenter) {
        presenter.HighQuantity = _model.HighQuantity;
        presenter.LowQuantity = _model.LowQuantity;
    }

    private bool AnyChangesStockWarning(ManageStockWarningPresenter presenter) => presenter.LowQuantity != _model.LowQuantity || presenter.HighQuantity != _model.HighQuantity;

    private Task<bool> UpdateDatabaseStockWarning(ManageStockWarningPresenter presenter) => StockDAL.UpdateStockWarnings(_model.Id, presenter.HighQuantity, presenter.LowQuantity);

    private void UpdateModelStockWarning(ManageStockWarningPresenter presenter) {
        _model.HighQuantity = presenter.HighQuantity;
        _model.LowQuantity = presenter.LowQuantity;
    }

    #endregion

    #region Stock Unit Cost
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetStockUnitCost() {
        (ManageStockUnitCostView view, ManageStockUnitCostPresenter presenter) = StockFactory.CreateManageStockUnitCost();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesStockUnitCost(presenter);
        AnyChangesCurrent = () => AnyChangesStockUnitCost(presenter);
        ValidateCurrent = () => true;
        UpdateDatabaseCurrent = () => UpdateDatabaseStockUnitCost(presenter);
        UpdateModelCurrent = () => UpdateModelStockUnitCost(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesStockUnitCost(ManageStockUnitCostPresenter presenter) {
        presenter.UnitCost = _model.UnitCost;
    }

    private bool AnyChangesStockUnitCost(ManageStockUnitCostPresenter presenter) => presenter.UnitCost != _model.UnitCost;

    private Task<bool> UpdateDatabaseStockUnitCost(ManageStockUnitCostPresenter presenter) => StockDAL.UpdateStockUnitCost(_model.Id, presenter.UnitCost);

    private void UpdateModelStockUnitCost(ManageStockUnitCostPresenter presenter) {
        _model.UnitCost = presenter.UnitCost;
    }

    #endregion

    public override void CleanUp() {
        if (_childPresenter is ManageStockDetailsPresenter manageStockDetailsPresenter) manageStockDetailsPresenter.ValidateSkuRequest -= OnValidateSku;

        base.CleanUp();
    }
}
