using a2_coursework.Model;
using a2_coursework.UserControls;
using a2_coursework.View;
using a2_coursework.View.Interfaces;
using a2_coursework.View.Interfaces.Stock;
using a2_coursework.View.Stock;

namespace a2_coursework.Presenter.Stock;
public class EditStockPresenter  : BasePresenter<IEditStockView> {
    private readonly StockItem _stockItem;

    private IChildPresenter? _childPresenter;

    public EditStockPresenter(IEditStockView view, StockItem stockItem) : base(view) {
        _stockItem = stockItem;

        _view.SelectedMenuItemChanged += OnSelectedMenuItemChanged;
        _view.PreviewSelectedMenuItemChanged += OnPreviewSelectedMenuItemChanged;
        _view.Save += OnSave;
        _view.Cancel += OnCancel;
    }

    private void OnSelectedMenuItemChanged(object? sender, EventArgs e) => DisplayView();
    private void OnPreviewSelectedMenuItemChanged(object? sender, ToggleEventArgs e) => DisplayView();
    private void OnValidateSKU(object? sender, EventArgs e) => DisplayView();
    private void OnSave(object? sender, EventArgs e) => DisplayView();
    private void OnCancel(object? sender, EventArgs e) => DisplayView();

    private bool CanExit() {
        //if (_view.IsLoading) return false;

        //if (AnyChanges()) {
        //    DialogResult result = _view.ShowMessageBox("All your changes will be lost. Click OK if you want to continue", "Are you sure you want to leave?", MessageBoxButtons.OKCancel);

        //    return result == DialogResult.OK;
        //}

        return true;
    }

    private void DisplayView() {
    }

    private (IChildView view, IChildPresenter childPresenter) GetNextPresenterView(string selectedItem) => selectedItem switch {
        "Stock details" => GetStockDetails(),
        //"Quantity" => GetStockQuantity(),
        //"Warnings" => GetStockWarnings(),
        _ => throw new NotImplementedException(),
    };

    private ManageStockDetailsPresenter? _stockDetailsPresenter;
    private (IChildView view, IChildPresenter childPresenter) GetStockDetails() {
        (ManageStockDetailsView view, ManageStockDetailsPresenter presenter) =  ViewFactory.CreateManageStockDetails();

        presenter.SetName(_stockItem.Name);
        presenter.SetSKU(_stockItem.SKU);
        presenter.Description = _stockItem.Description;
        presenter.Archived = _stockItem.IsArchived;

        presenter.ValidateSKU += OnValidateSKU;

        return (view, presenter);
    }

    private async Task<bool> IsValidSKU(object? sender, ValidationRequestEventArgs<string> e) {
        string sku = e.Value;

        if (string.IsNullOrWhiteSpace(sku)) {
            e.Valid = false;
            e.ErrorMessage = "Please fill in an SKU";
        }
        else {
            //e.ValidationTask = await StockDAL.SKUExists(sku);
            e.ErrorMessage = "This SKU already exists. Please pick a different one";
        }

        return true;
    }

}
