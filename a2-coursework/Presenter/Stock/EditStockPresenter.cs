using a2_coursework.Model;
using a2_coursework.UserControls;
using a2_coursework.View;
using a2_coursework.View.Interfaces;
using a2_coursework.View.Interfaces.Stock;
using a2_coursework.View.Stock;

namespace a2_coursework.Presenter.Stock;
public class EditStockPresenter : EditPresenter<IEditStockView, StockItem>, IChildPresenter, INavigatingPresenter {
    private readonly Staff _staff;

    private INotifyingChildPresenter? _childPresenter;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public EditStockPresenter(IEditStockView view, StockItem stockItem, Staff staff) : base(view, stockItem) {
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
        (IChildView view, IChildPresenter presenter) = ViewFactory.CreateStockDisplay(_staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    private bool CanNavigate() => _childPresenter is null || _childPresenter.CanExit();

    private void Navigate((IChildView view, INotifyingChildPresenter presenter) pair) {
        Navigate(pair.view, pair.presenter);
    }

    private void Navigate(IChildView view, INotifyingChildPresenter presenter) {
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

    private (IChildView view, INotifyingChildPresenter childPresenter) GetStockQuantity() {
        (ManageStockQuantityView view, ManageStockQuantityPresenter presenter) =  ViewFactory.CreateManageStockQuantity(_staff);

        presenter.Quantity = _model.Quantity;

        return (view, presenter);
    }

    private (IChildView view, INotifyingChildPresenter childPresenter) GetStockDetails() {
        (ManageStockDetailsView view, ManageStockDetailsPresenter presenter) =  ViewFactory.CreateManageStockDetails();

        presenter.ValidateSKU += OnValidateSKU;

        presenter.SetName(_model.Name);
        presenter.SetSKU(_model.SKU);
        presenter.Description = _model.Description;
        presenter.Archived = _model.Archived;

        return (view, presenter);
    }

    private (IChildView view, INotifyingChildPresenter childPresenter) GetStockWarning() {
        (ManageStockWarningView view, ManageStockWarningPresenter presenter) =  ViewFactory.CreateManageStockWarning();

        presenter.HighQuantity = _model.HighQuantity;
        presenter.LowQuantity = _model.LowQuantity;

        return (view, presenter);
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

    protected override void PopulateDefaultValues() {
        if (_childPresenter is ManageStockDetailsPresenter manageStockDetailsPresenter) {
            manageStockDetailsPresenter.SetName(_model.Name);
            manageStockDetailsPresenter.SetSKU(_model.SKU);
            manageStockDetailsPresenter.Description = _model.Description;
            manageStockDetailsPresenter.Archived = _model.Archived;
        }
        else if (_childPresenter is ManageStockQuantityPresenter manageStockQuantityPresenter) {
            manageStockQuantityPresenter.Quantity = _model.Quantity;
        }
        else if (_childPresenter is ManageStockWarningPresenter manageStockWarningPresenter) {
            manageStockWarningPresenter.HighQuantity = _model.HighQuantity;
            manageStockWarningPresenter.LowQuantity = _model.LowQuantity;
        }
    }

    protected override void UpdateModel() {
        if (_childPresenter is ManageStockDetailsPresenter manageStockDetailsPresenter) {
            bool nameValid = manageStockDetailsPresenter.TryGetName(out string? name);
            bool skuValid = manageStockDetailsPresenter.TryGetSKU(out string? sku);

            _model.Name = name!;
            _model.SKU = sku!;
            _model.Description = _model.Description;
            _model.Archived = _model.Archived;
        }
        else if (_childPresenter is ManageStockQuantityPresenter manageStockQuantityPresenter) {
            _model.Quantity = manageStockQuantityPresenter.Quantity;
        }
        else if (_childPresenter is ManageStockWarningPresenter manageStockWarningPresenter) {
            _model.HighQuantity = manageStockWarningPresenter.HighQuantity;
            _model.LowQuantity = manageStockWarningPresenter.LowQuantity;
        }
    }

    protected override bool AnyChanges() {
        if (_childPresenter is ManageStockDetailsPresenter manageStockDetailsPresenter) {
            bool nameValid = manageStockDetailsPresenter.TryGetName(out string? name);
            bool skuValid = manageStockDetailsPresenter.TryGetSKU(out string? sku);

            if (!nameValid || !skuValid) return true;

            return name != _model.Name || sku != _model.SKU || manageStockDetailsPresenter.Description != _model.Description || manageStockDetailsPresenter.Archived != _model.Archived;
        }
        else if (_childPresenter is ManageStockQuantityPresenter manageStockQuantityPresenter) {
            return manageStockQuantityPresenter.Quantity != _model.Quantity;
        }
        else if (_childPresenter is ManageStockWarningPresenter manageStockWarningPresenter) {
            return manageStockWarningPresenter.LowQuantity != _model.LowQuantity || manageStockWarningPresenter.HighQuantity != _model.HighQuantity;
        }

        return false;
    }

    protected override Task<bool> UpdateDatabase() {
        if (_childPresenter is ManageStockDetailsPresenter manageStockDetailsPresenter) {
            bool nameValid = manageStockDetailsPresenter.TryGetName(out string? name);
            bool skuValid = manageStockDetailsPresenter.TryGetSKU(out string? sku);

            return StockDAL.UpdateDetails(_model.Id, name!, manageStockDetailsPresenter.Description, sku!, manageStockDetailsPresenter.Archived);
        }
        else if (_childPresenter is ManageStockQuantityPresenter manageStockQuantityPresenter) {
            return StockDAL.UpdateQuantity(_model.Id, _staff.Id, manageStockQuantityPresenter.Quantity, DateTime.Now, manageStockQuantityPresenter.ReasonForQuantityChange);
        }
        else if (_childPresenter is ManageStockWarningPresenter manageStockWarningPresenter) {
            return StockDAL.UpdateWarnings(_model.Id, manageStockWarningPresenter.HighQuantity, manageStockWarningPresenter.LowQuantity);
        }

        throw new NotImplementedException();
    }

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
