using a2_coursework.Model;
using a2_coursework.View;
using a2_coursework.View.Interfaces;
using a2_coursework.View.Interfaces.Stock;
using a2_coursework.View.Stock;

namespace a2_coursework.Presenter.Stock;
public class EditStockPresenter {
    private readonly IEditStockView _view;
    private readonly StockItem _stockItem;

    public EditStockPresenter(IEditStockView view, StockItem stockItem) {
        _view = view;
        _stockItem = stockItem;
    }

    private void PreviewSelectedIndexChanged() {
    }

    private void SelectedIndexChanged() => _view.DisplayView(GetNextView(_view.SelectedMenuItem)); 

    private IChildView GetNextView(string selectedItem) => selectedItem switch {
        "Stock details" => GetStockDetails(),
        //"Quantity" => GetStockQuantity(),
        //"Warnings" => GetStockWarnings(),
        _ => throw new NotImplementedException(),
    };

    private IChildView? _stockDetailsView;
    private ManageStockDetailsPresenter? _stockDetailsPresenter;
    private IChildView GetStockDetails() {
        (ManageStockDetailsView view, ManageStockDetailsPresenter presenter) =  ViewFactory.CreateManageStockDetails();

        presenter.SetName(_stockItem.Name);
        presenter.SetSKU(_stockItem.SKU);
        presenter.Description = _stockItem.Description;
        presenter.Archived = _stockItem.Archived;

        presenter.ValidateSKU += ValidateSKU;

        _stockDetailsView = view;
        return _stockDetailsView;
    }

    private void ValidateSKU(object? sender, ValidationRequestEventArgs<string> e) {
        string sku = e.Value;

        if (string.IsNullOrWhiteSpace(sku)) {
            e.Valid = false;
            e.ErrorMessage = "Please fill in an SKU";
        }
        else {
            e.ValidationTask = StockDAL.SKUExists(sku).ContinueWith(x => !x.Result);
            e.ErrorMessage = "This SKU already exists. Please pick a different one";
        }
    }

}
