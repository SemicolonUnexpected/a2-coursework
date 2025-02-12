using a2_coursework.View.Interfaces.Stock;

namespace a2_coursework.Presenter.Stock; 
public class ManageStockWarningPresenter {
    private IManageStockWarningView _view;

    public ManageStockWarningPresenter(IManageStockWarningView view) {
        _view = view;
    }

    public int HightQuantity {
        get => _view.HighQuantity;
        set => _view.HighQuantity = value;
    }

    public int LowtQuantity {
        get => _view.LowQuantity;
        set => _view.LowQuantity = value;
    }
}
