using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Stock.StockManagement;
using a2_coursework.Model.Staff;
using a2_coursework.Model.Stock;
using a2_coursework.View.Stock;

namespace a2_coursework.Presenter.Stock.StockManagement;

public class AddStockPresenter : AddPresenter<IAddStockView, StockModel>, IChildPresenter, INavigatingPresenter  {
    private readonly StaffModel _staff;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public AddStockPresenter(IAddStockView view, StaffModel staff) : base(view, new("", "", -1, "", 0, 0, 0, false)) {
        _staff = staff;

        _viewFactories.Add(GetStockDetails);
        _viewFactories.Add(GetStockQuantity);
        _viewFactories.Add(GetStockWarning);

        _view.Back += OnBack;

        NavigateToCurrentView();
    }

    private void OnBack(object? sender, EventArgs e) {
        if (CanExit()) NavigateBack();
    }
    private void OnValidateSkuRequest(object? sender, ValidationRequestEventArgs<string> e) => IsValidSku(e);

    private void NavigateBack() {
        (IChildView view, IChildPresenter presenter) = StaffFactory.CreateStockDisplay(_staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void BindValidation(ICleanable presenter) {
        if (presenter is ManageStockDetailsPresenter manageStockDetailsPresenter) manageStockDetailsPresenter.ValidateSkuRequest += OnValidateSkuRequest; 
    }

    protected override void UnBindValidation(ICleanable presenter) {
        if (presenter is ManageStockDetailsPresenter manageStockDetailsPresenter) manageStockDetailsPresenter.ValidateSkuRequest -= OnValidateSkuRequest; 
    }

    protected override Task<bool> UpdateDatabase() => StockDAL.CreateStock(_model, _staff.Id, DateTime.Now, "Initial stock value.");

    #region Stock Quantity
    private (IChildView view, ICleanable presenter) GetStockQuantity() {
        (ManageStockQuantityView view, ManageStockQuantityPresenter presenter) = StaffFactory.CreateManageStockQuantity();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesStockQuantity(presenter);
        ValidateCurrent = () => ValidateStockQuantity(presenter);
        UpdateModelCurrent = () => UpdateModelStockQuantity(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesStockQuantity(ManageStockQuantityPresenter presenter) {
        presenter.Quantity = _model.Quantity;
        presenter.ReasonForQuantityChange = "Initial stock value.";
        presenter.ReasonForQuantityChangeReadOnly = true;
    }

    private void UpdateModelStockQuantity(ManageStockQuantityPresenter presenter) {
        _model.Quantity = presenter.Quantity;
    }

    private bool ValidateStockQuantity(ManageStockQuantityPresenter presenter) => true;
    #endregion

    #region Stock Details
    private (IChildView view, ICleanable presenter) GetStockDetails() {
        (ManageStockDetailsView view, ManageStockDetailsPresenter presenter) = StaffFactory.CreateManageStockDetails();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesStockDetails(presenter);
        UpdateModelCurrent = () => UpdateModelStockDetails(presenter);
        ValidateCurrent = () => ValidateStockDetails(presenter);
        
        return (view, presenter);
    }

    private void PopulateDefaultValuesStockDetails(ManageStockDetailsPresenter presenter) {
        presenter.Name = _model.Name;
        presenter.Sku = _model.Sku;
        presenter.Description = _model.Description;
        presenter.Archived = _model.Archived;
    }

    private void UpdateModelStockDetails(ManageStockDetailsPresenter presenter) {
        _model.Name = presenter.Name;
        _model.Sku = presenter.Sku;
        _model.Description = presenter.Description;
        _model.Archived = presenter.Archived;
    }

    private bool ValidateStockDetails(ManageStockDetailsPresenter presenter) => presenter.NameValid && presenter.SkuValid;

    private void IsValidSku(ValidationRequestEventArgs<string> validateSKURequest) {
        string sku = validateSKURequest.Value;
        if (string.IsNullOrWhiteSpace(sku)) {
            validateSKURequest.SetValidation(false, "Please fill in an SKU");
        }
        else {
            validateSKURequest.SetValidation(
                StockDAL.SkuExists(sku).ContinueWith(x => !x.Result),
                "This SKU already exists. Please pick a different one"
            );
        }
    }
    #endregion

    #region Stock Warning
    private (IChildView view, ICleanable presenter) GetStockWarning() {
        (ManageStockWarningView view, ManageStockWarningPresenter presenter) = StaffFactory.CreateManageStockWarning();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesStockWarning(presenter);
        UpdateModelCurrent = () => UpdateModelStockWarning(presenter);
        ValidateCurrent = () => ValidateStockWarning(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesStockWarning(ManageStockWarningPresenter presenter) {
        presenter.LowQuantity = _model.LowQuantity;
        presenter.HighQuantity = _model.HighQuantity;
    }

    private void UpdateModelStockWarning(ManageStockWarningPresenter presenter) {
        _model.LowQuantity = presenter.LowQuantity;
        _model.HighQuantity = presenter.HighQuantity;
    }

    private bool ValidateStockWarning(ManageStockWarningPresenter presenter) => true;
    #endregion

    protected override void OnAddSuccessful() => NavigateBack();

    public override void CleanUp() {
        _view.Back -= OnBack;

        base.CleanUp();
    }
}