using a2_coursework.Interfaces.Stock.StockManagement;

namespace a2_coursework.Presenter.Stock.StockManagement;
public class ManageStockQuantityPresenter : BasePresenter<IManageStockQuantityView>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public ManageStockQuantityPresenter(IManageStockQuantityView view) : base(view) {
        _view.BulkAdd += OnBulkAdd;
        _view.BulkRemove += OnBulkRemove;
        _view.ReasonForQuantityChangeChanged += OnReasonForQuantityChangeChanged;
        _view.QuantityChanged += OnQuantityChanged;
    }

    private void OnBulkAdd(object? sender, EventArgs e) => BulkAdd();
    private void OnBulkRemove(object? sender, EventArgs e) => BulkRemove();
    private void OnReasonForQuantityChangeChanged(object? sender, EventArgs e) {
        ReasonForQuantityChangeChanged();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }
    private void OnQuantityChanged(object? sender, EventArgs e) => DetailsChanged?.Invoke(this, EventArgs.Empty);

    public int Quantity {
        get => _view.Quantity;
        set => _view.Quantity = value;
    }

    public string ReasonForQuantityChange {
        get => _view.ReasonForQuantityChange;
        set => _view.ReasonForQuantityChange = value;
    }

    public bool ReasonForQuantityChangeReadOnly {
        get => _view.ReasonForChangedReadOnly;
        set => _view.ReasonForChangedReadOnly = value;
    }

    public void ResetBulkEdit() {
        _view.BulkAddQuantity = 0;
        _view.BulkRemoveQuantity = 0;
    }

    private void ReasonForQuantityChangeChanged() => _view.SetCharacterCount(_view.ReasonForQuantityChange.Length);

    private void BulkAdd() => _view.Quantity = (int)Math.Min((long)_view.Quantity + _view.BulkAddQuantity, 999999999);

    private void BulkRemove() => _view.Quantity = (int)Math.Max((long)_view.Quantity - _view.BulkRemoveQuantity, 0);

    public bool CanExit() => true;

    public override void CleanUp() {
        _view.BulkAdd -= OnBulkAdd;
        _view.BulkRemove -= OnBulkRemove;
        _view.ReasonForQuantityChangeChanged -= OnReasonForQuantityChangeChanged;
        _view.QuantityChanged -= OnQuantityChanged;

        base.CleanUp();
    }
}
