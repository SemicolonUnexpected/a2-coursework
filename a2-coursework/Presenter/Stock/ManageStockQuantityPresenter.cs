using a2_coursework.View.Interfaces.Stock;

namespace a2_coursework.Presenter.Stock; 
public class ManageStockQuantityPresenter {
    private readonly IManageStockQuantityView _view;

    public ManageStockQuantityPresenter(IManageStockQuantityView view) {
        _view = view;

        _view.BulkAdd += (s, e) => BulkAdd();
        _view.BulkRemove += (s, e) => BulkRemove();
        _view.ReasonForQuantityChangeChanged += (s, e) => ReasonForQuantityChangeChanged();
    }

    public int Quantity {
        get => _view.Quantity;
    }

    public string ReasonForQuantityChange {
        get => _view.ReasonForQuantityChange;
    }

    private void ReasonForQuantityChangeChanged() => _view.SetCharacterCount(_view.ReasonForQuantityChange.Length);

    private void BulkAdd() => _view.Quantity = (int)Math.Min((long)_view.Quantity + _view.BulkAddQuantity, 999999999);

    private void BulkRemove() => _view.Quantity = (int)Math.Max((long)_view.Quantity - _view.BulkRemoveQuantity, 0);
}
