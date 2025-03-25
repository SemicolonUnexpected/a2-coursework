using a2_coursework.Interfaces.Stock.StockManagement;

namespace a2_coursework.Presenter.Stock.StockManagement;
public class ManageStockWarningPresenter : BasePresenter<IManageStockWarningView>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public ManageStockWarningPresenter(IManageStockWarningView view) : base(view) {
        _view.LowQuantityChanged += OnLowQuantityChanged;
        _view.HighQuantityChanged += OnHighQuantityChanged;
    }

    private void OnLowQuantityChanged(object? sender, EventArgs e) {
        if (_view.LowQuantity > _view.HighQuantity) Error = true;
        else Error = false;

        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    private void OnHighQuantityChanged(object? sender, EventArgs e) {
        if (_view.LowQuantity > _view.HighQuantity) Error = true;
        else Error = false;

        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    public int HighQuantity {
        get => _view.HighQuantity;
        set => _view.HighQuantity = value;
    }

    public int LowQuantity {
        get => _view.LowQuantity;
        set => _view.LowQuantity = value;
    }

    private bool _error = false;
    public bool Error {
        get => _error;
        set {
            _error = value;
            _view.Error = value ? "Low quantity must be less than high quantity" : "";
        }
    }

    public bool CanExit() => true;
}
