using a2_coursework.Model;
using a2_coursework.View;
using a2_coursework.View.Interfaces;
using a2_coursework.View.Interfaces.Stock;
using a2_coursework.View.Stock;

namespace a2_coursework.Presenter.Stock;
public class AddStockPresenter : BasePresenter<IAddStockView>, INavigatingPresenter {
    private int _index = 0;
    private StockItem _model = new("", "", -1, "", 0, 0, 0, false);
    private readonly Staff _staff;

    private (IChildView view, ManageStockDetailsPresenter presenter) _manageStockDetails;
    private (IChildView view, ManageStockQuantityPresenter presenter) _manageStockQuantity;
    private (IChildView view, ManageStockWarningPresenter presenter) _manageStockWarning;

    private INotifyingChildPresenter? _childPresenter;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public AddStockPresenter(IAddStockView view, Staff staff) : base(view) {
        _staff = staff;

        _view.Back += OnBack;
        _view.Next += OnNext;
        _view.Previous += OnPrevious;
        _view.Done += OnDone;

        CreateViewsAndPresenters();
    }

    private void OnDone(object? sender, EventArgs e) => CreateStock();
    private void OnBack(object? sender, EventArgs e) => NavigateBack();
    private void OnNext(object? sender, EventArgs e) {
        _index++;
        Navigate(GetView(_index));
    }
    private void OnPrevious(object? sender, EventArgs e) {
        _index--;
        Navigate(GetView(_index));
    }
    private void OnValidateSKU(object? sender, ValidationRequestEventArgs<string> e) => IsValidSKU(e);
    private void OnDetailsChanged(object? sender, EventArgs e) => SetApproveChangesBarVisibility();

    private void NavigateBack() {
        (IChildView view, IChildPresenter presenter) = ViewFactory.CreateStockDisplay(_staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    private void Navigate((IChildView view, INotifyingChildPresenter presenter) pair) {
        Navigate(pair.view, pair.presenter);
    }

    private void Navigate(IChildView view, INotifyingChildPresenter presenter) {
        _view.DisplayChildView(view);

        SetPreviousNextDoneBarVisibility();
    }

    private (IChildView view, INotifyingChildPresenter childPresenter) GetView(int index) => index switch {
        0 => _manageStockDetails,
        1 => _manageStockQuantity,
        2 => _manageStockWarning,
        _ => throw new NotImplementedException(),
    };

    private void IsValidSKU(ValidationRequestEventArgs<string> validateSKURequest) {
        string sku = validateSKURequest.Value;

        if (sku == _model.SKU) {
            validateSKURequest.SetValidation(true);
            return;
        }

        if (string.IsNullOrWhiteSpace(sku)) validateSKURequest.SetValidation(false, "Please fill in an SKU");
        else validateSKURequest.SetValidation(StockDAL.SKUExists(sku).ContinueWith(x => !x.Result), "This SKU already exists. Please pick a different one");
    }


    private void CreateViewsAndPresenters() {
        _manageStockDetails = ViewFactory.CreateManageStockDetails();
        _manageStockQuantity = ViewFactory.CreateManageStockQuantity();
        _manageStockWarning = ViewFactory.CreateManageStockWarning();

        _manageStockDetails.presenter.ValidateSKU += OnValidateSKU;
    }

    protected void PopulateDefaultValues() {
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

    protected void UpdateModel() {
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

    protected bool AnyChanges() {
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

        base.CleanUp();
    }
}
