using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Stock.StockManagement;
using a2_coursework.Model.Staff;
using a2_coursework.Model.Stock;
using a2_coursework.UserControls;
using a2_coursework.View;
using a2_coursework.View.Stock;

namespace a2_coursework.Presenter.Stock.StockManagement;
public class EditStockPresenter : ParentEditPresenter<IEditStockView, StockModel>, IChildPresenter, INavigatingPresenter {
    private readonly StaffModel _staff;

    private INotifyingChildPresenter? _childPresenter;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public EditStockPresenter(IEditStockView view, StockModel stockItem, StaffModel staff) : base(view, stockItem) {
        _staff = staff;

        _view.SelectedMenuItemChanged += OnSelectedMenuItemChanged;
        _view.PreviewSelectedMenuItemChanged += OnPreviewSelectedMenuItemChanged;
        _view.Back += OnBack;

        Navigate(GetStockDetails());
    }

    private void OnSelectedMenuItemChanged(object? sender, string selectedItem) => Navigate(GetView(selectedItem));
    private void OnPreviewSelectedMenuItemChanged(object? sender, ToggleEventArgs e) => e.Handled = CanNavigate();
    private void OnValidateSKU(object? sender, ValidationRequestEventArgs<string> e) => IsValidSKU(e);
    private void OnBack(object? sender, EventArgs e) => NavigateBack();
    private void OnDetailsChanged(object? sender, EventArgs e) => SetApproveChangesBarVisibility();

    private void NavigateBack() {
        if (!CanExit()) return;
        (IChildView view, IChildPresenter presenter) = ViewFactory.CreateStockDisplay(_staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    private bool CanNavigate() => _childPresenter is null || _childPresenter.CanExit();

    protected override void Navigate(IChildView view, INotifyingChildPresenter presenter) {
        presenter.DetailsChanged += OnDetailsChanged;
        // Display the next view
        _view.DisplayChildView(view);

        if (_childPresenter is ManageStockDetailsPresenter manageStockDetailsPresenter) manageStockDetailsPresenter.ValidateSKU -= OnValidateSKU;

        if (_childPresenter is not null) {
            _childPresenter.DetailsChanged -= OnDetailsChanged;
            _childPresenter.CleanUp();
        }

        _childPresenter = presenter;

        PopulateDefaultValues();

        SetApproveChangesBarVisibility();
    }

    private (IChildView view, INotifyingChildPresenter childPresenter) GetView(string selectedItem) => selectedItem switch {
        "Stock Details" => GetStockDetails(),
        "Quantity" => GetStockQuantity(),
        "Warnings" => GetStockWarning(),
        _ => throw new NotImplementedException(),
    };

    #region Stock Quantity

    private (IChildView view, INotifyingChildPresenter childPresenter) GetStockQuantity() {
        (ManageStockQuantityView view, ManageStockQuantityPresenter presenter) = ViewFactory.CreateManageStockQuantity();

        presenter.Quantity = _model.Quantity;

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesStockQuantity(presenter);
        AnyChangesCurrent = () => AnyChangesStockQuantity(presenter);
        ValidateInputsCurrent = () => true;
        UpdateDatabaseCurrent = () => UpdateDatabaseStockQuantity(presenter);
        UpdateModelCurrent = () => UpdateModelStockQuantity(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesStockQuantity(ManageStockQuantityPresenter presenter) {
        presenter.Quantity = _model.Quantity;
        presenter.ReasonForQuantityChange = "";
    }

    private bool AnyChangesStockQuantity(ManageStockQuantityPresenter presenter) => presenter.Quantity != _model.Quantity;

    private Task<bool> UpdateDatabaseStockQuantity(ManageStockQuantityPresenter presenter) => StockDAL.UpdateQuantity(_model.Id, _staff.Id, presenter.Quantity, DateTime.Now, presenter.ReasonForQuantityChange);

    private void UpdateModelStockQuantity(ManageStockQuantityPresenter presenter) {
        _model.Quantity = presenter.Quantity;

        PopulateDefaultValuesStockQuantity(presenter);
    }

    #endregion

    #region Stock Details

    private (IChildView view, INotifyingChildPresenter childPresenter) GetStockDetails() {
        (ManageStockDetailsView view, ManageStockDetailsPresenter presenter) = ViewFactory.CreateManageStockDetails();

        presenter.ValidateSKU += OnValidateSKU;

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesStockDetails(presenter);
        AnyChangesCurrent = () => AnyChangesStockDetails(presenter);
        ValidateInputsCurrent = () => ValidateInputsStockDetails(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseStockDetails(presenter);
        UpdateModelCurrent = () => UpdateModelStockDetails(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesStockDetails(ManageStockDetailsPresenter presenter) {
        presenter.SetName(_model.Name);
        presenter.SetSKU(_model.SKU);
        presenter.Description = _model.Description;
        presenter.Archived = _model.Archived;
    }

    private bool AnyChangesStockDetails(ManageStockDetailsPresenter presenter) {
        bool nameValid = presenter.TryGetName(out string? name);
        bool skuValid = presenter.TryGetSKU(out string? sku);

        if (!nameValid || !skuValid) return true;

        return name != _model.Name || sku != _model.SKU || presenter.Description != _model.Description || presenter.Archived != _model.Archived;
    }

    private bool ValidateInputsStockDetails(ManageStockDetailsPresenter presenter) => presenter.TryGetSKU(out _) && presenter.TryGetName(out _);

    private Task<bool> UpdateDatabaseStockDetails(ManageStockDetailsPresenter presenter) {
        bool nameValid = presenter.TryGetName(out string? name);
        bool skuValid = presenter.TryGetSKU(out string? sku);

        return StockDAL.UpdateDetails(_model.Id, name!, presenter.Description, sku!, presenter.Archived);
    }

    private void UpdateModelStockDetails(ManageStockDetailsPresenter presenter) {
        bool nameValid = presenter.TryGetName(out string? name);
        bool skuValid = presenter.TryGetSKU(out string? sku);

        _model.Name = name!;
        _model.SKU = sku!;
        _model.Description = _model.Description;
        _model.Archived = _model.Archived;
    }

    private void IsValidSKU(ValidationRequestEventArgs<string> validateSKURequest) {
        string sku = validateSKURequest.Value;

        if (sku == _model.SKU) {
            validateSKURequest.SetValidation(true);
            return;
        }

        if (string.IsNullOrWhiteSpace(sku)) validateSKURequest.SetValidation(false, "Please fill in an SKU");
        else validateSKURequest.SetValidation(StockDAL.SKUExists(sku).ContinueWith(x => !x.Result), "This SKU already exists. Please pick a different one");
    }

    #endregion

    #region Stock Warning
    private (IChildView view, INotifyingChildPresenter childPresenter) GetStockWarning() {
        (ManageStockWarningView view, ManageStockWarningPresenter presenter) = ViewFactory.CreateManageStockWarning();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesStockWarning(presenter);
        AnyChangesCurrent = () => AnyChangesStockWarning(presenter);
        ValidateInputsCurrent = () => true;
        UpdateDatabaseCurrent = () => UpdateDatabaseStockWarning(presenter);
        UpdateModelCurrent = () => UpdateModelStockWarning(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesStockWarning(ManageStockWarningPresenter presenter) {
        presenter.HighQuantity = _model.HighQuantity;
        presenter.LowQuantity = _model.LowQuantity;
    }

    private bool AnyChangesStockWarning(ManageStockWarningPresenter presenter) => presenter.LowQuantity != _model.LowQuantity || presenter.HighQuantity != _model.HighQuantity;

    private Task<bool> UpdateDatabaseStockWarning(ManageStockWarningPresenter presenter) => StockDAL.UpdateWarnings(_model.Id, presenter.HighQuantity, presenter.LowQuantity);

    private void UpdateModelStockWarning(ManageStockWarningPresenter presenter) {
        _model.HighQuantity = presenter.HighQuantity;
        _model.LowQuantity = presenter.LowQuantity;
    }

    #endregion

    public override void CleanUp() {
        _view.SelectedMenuItemChanged -= OnSelectedMenuItemChanged;
        _view.PreviewSelectedMenuItemChanged -= OnPreviewSelectedMenuItemChanged;

        if (_childPresenter is ManageStockDetailsPresenter manageStockDetailsPresenter) manageStockDetailsPresenter.ValidateSKU -= OnValidateSKU;

        if (_childPresenter is not null) {
            _childPresenter.DetailsChanged -= OnDetailsChanged;
            _childPresenter.CleanUp();
        }

        _childPresenter = null;

        base.CleanUp();
    }
}
