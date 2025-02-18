using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Stock.StockManagement;
using a2_coursework.Model.Staff;
using a2_coursework.Model.Stock;
using a2_coursework.View;
using a2_coursework.View.Stock;

namespace a2_coursework.Presenter.Stock.StockManagement;

public class AddStockPresenter : IChildPresenter, INavigatingPresenter {
    private readonly IAddStockView _view;
    private int _index = 0;
    private readonly StockModel _model = new("", "", -1, "", 0, 0, 0, false);
    private string _reason = "Initial stock";
    private readonly StaffModel _staff;
    private INotifyingChildPresenter? _childPresenter;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public AddStockPresenter(IAddStockView view, StaffModel staff) {
        _view = view;
        _staff = staff;

        _view.Back += OnBack;
        _view.Next += OnNext;
        _view.Previous += OnPrevious;
        _view.Done += OnDone;

        Navigate(GetStockDetails());
    }

    private void OnDone(object? sender, EventArgs e) => CreateStock();
    private void OnBack(object? sender, EventArgs e) => NavigateBack();

    private void OnNext(object? sender, EventArgs e) {
        UpdateModel();
        _index++;
        Navigate(GetView(_index));
    }

    private void OnPrevious(object? sender, EventArgs e) {
        UpdateModel();
        _index--;
        Navigate(GetView(_index));
    }

    private void OnValidateSKU(object? sender, ValidationRequestEventArgs<string> e) => IsValidSKU(e);
    private void OnDetailsChanged(object? sender, EventArgs e) => UpdatePreviousNextDoneBarVisibility();

    private void NavigateBack() {
        (IChildView view, IChildPresenter presenter) = ViewFactory.CreateStockDisplay(_staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    private void Navigate((IChildView view, INotifyingChildPresenter presenter) pair) {
        Navigate(pair.view, pair.presenter);
    }

    private void Navigate(IChildView view, INotifyingChildPresenter presenter) {
        presenter.DetailsChanged += OnDetailsChanged;
        _view.DisplayChildView(view);

        if (_childPresenter is ManageStockDetailsPresenter manageStockDetailsPresenter) {
            manageStockDetailsPresenter.ValidateSKU -= OnValidateSKU;
        }

        if (_childPresenter is not null) {
            _childPresenter.DetailsChanged -= OnDetailsChanged;
            _childPresenter.CleanUp();
        }

        _childPresenter = presenter;
        PopulateDefaultValues();
        UpdatePreviousNextDoneBarVisibility();
    }

    private (IChildView view, INotifyingChildPresenter presenter) GetView(int index) => index switch {
        0 => GetStockDetails(),
        1 => GetStockQuantity(),
        2 => GetStockWarning(),
        _ => throw new NotImplementedException()
    };

    private (IChildView view, INotifyingChildPresenter presenter) GetStockQuantity() {
        (ManageStockQuantityView view, ManageStockQuantityPresenter presenter) = ViewFactory.CreateManageStockQuantity();
        presenter.Quantity = _model.Quantity;
        presenter.ReasonForQuantityChange = _reason;
        return (view, presenter);
    }

    private (IChildView view, INotifyingChildPresenter presenter) GetStockDetails() {
        (ManageStockDetailsView view, ManageStockDetailsPresenter presenter) = ViewFactory.CreateManageStockDetails();
        presenter.ValidateSKU += OnValidateSKU;
        presenter.SetName(_model.Name);
        presenter.SetSKU(_model.SKU);
        presenter.Description = _model.Description;
        presenter.Archived = _model.Archived;
        return (view, presenter);
    }

    private (IChildView view, INotifyingChildPresenter presenter) GetStockWarning() {
        (ManageStockWarningView view, ManageStockWarningPresenter presenter) = ViewFactory.CreateManageStockWarning();
        presenter.HighQuantity = _model.HighQuantity;
        presenter.LowQuantity = _model.LowQuantity;
        return (view, presenter);
    }

    private void IsValidSKU(ValidationRequestEventArgs<string> validateSKURequest) {
        string sku = validateSKURequest.Value;
        if (string.IsNullOrWhiteSpace(sku)) {
            validateSKURequest.SetValidation(false, "Please fill in an SKU");
        }
        else {
            validateSKURequest.SetValidation(
                StockDAL.SKUExists(sku).ContinueWith(x => !x.Result),
                "This SKU already exists. Please pick a different one"
            );
        }
    }

    private void PopulateDefaultValues() {
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

    private void UpdateModel() {
        if (_childPresenter is ManageStockDetailsPresenter manageStockDetailsPresenter) {
            bool nameValid = manageStockDetailsPresenter.TryGetName(out string? name);
            bool skuValid = manageStockDetailsPresenter.TryGetSKU(out string? sku);

            if (nameValid && skuValid) {
                _model.Name = name!;
                _model.SKU = sku!;
                _model.Description = manageStockDetailsPresenter.Description;
                _model.Archived = manageStockDetailsPresenter.Archived;
            }
        }
        else if (_childPresenter is ManageStockQuantityPresenter manageStockQuantityPresenter) {
            _model.Quantity = manageStockQuantityPresenter.Quantity;
            _reason = manageStockQuantityPresenter.ReasonForQuantityChange;
        }
        else if (_childPresenter is ManageStockWarningPresenter manageStockWarningPresenter) {
            _model.HighQuantity = manageStockWarningPresenter.HighQuantity;
            _model.LowQuantity = manageStockWarningPresenter.LowQuantity;
        }
    }

    private void UpdatePreviousNextDoneBarVisibility() {
        _view.PreviousVisible = _index > 0;
        _view.NextVisible = _index < 2;
        _view.DoneVisible = _index == 2;
    }

    private async void CreateStock() {
        UpdateModel();

        try {
            bool success = await StockDAL.CreateStock(
                _model,
                _staff.Id,
                DateTime.Now,
                _reason);

            _view.ShowMessageBox("Stock item created successfully.", "Success");
            NavigateBack();
        }
        catch {
            _view.ShowMessageBox("Failed to create stock item.", "Error");
        }
    }

    public void CleanUp() {
        _view.Back -= OnBack;
        _view.Next -= OnNext;
        _view.Previous -= OnPrevious;
        _view.Done -= OnDone;

        if (_childPresenter is ManageStockDetailsPresenter manageStockDetailsPresenter) {
            manageStockDetailsPresenter.ValidateSKU -= OnValidateSKU;
        }

        if (_childPresenter is not null) {
            _childPresenter.DetailsChanged -= OnDetailsChanged;
            _childPresenter.CleanUp();
        }

        _childPresenter = null;
    }

    private readonly bool _stockCreated = false;
    public bool CanExit() {
        if (_stockCreated) return true;
        if (_view.IsLoading) return false;

        DialogResult result = _view.ShowMessageBox("All your changes will be lost. Click OK if you want to continue", "Are you sure you want to leave?", MessageBoxButtons.OKCancel);

        return result == DialogResult.OK;
    }
}