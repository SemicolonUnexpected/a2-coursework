using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Stock.StockQuantityChanges;
using a2_coursework.Model.Stock;

namespace a2_coursework.Presenter.StockPresenter.StockQuantityChanges;
public class ViewStockQuantityChangePresenter : BasePresenter<IViewStockQuantityChangeView>, INavigatingPresenter, IChildPresenter {
    private readonly StockQuantityChange _stockQuantityChange;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public ViewStockQuantityChangePresenter(IViewStockQuantityChangeView view, StockQuantityChange stockQuantityChange) : base(view) {
        _stockQuantityChange = stockQuantityChange;

        _view.Back += OnBack;

        PopulateDefaultValues();
    }

    private void PopulateDefaultValues() {
        _view.StockName = _stockQuantityChange.StockName;
        _view.Quantity = _stockQuantityChange.Quantity;
        _view.Username = _stockQuantityChange.StaffUsername;
        _view.DateOfChange = _stockQuantityChange.Date;
        _view.ReasonForQuantityChange = _stockQuantityChange.ReasonForQuantityChange;
    }

    private void OnBack(object? sender, EventArgs e) => NavigateBack();

    private void NavigateBack() {
        if (!CanExit()) return;

        (IChildView view, IChildPresenter presenter) = StaffFactory.CreateDisplayStockQuantityChanges();
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    public bool CanExit() => true;

    public override void CleanUp() {
        _view.Back -= OnBack;

        base.CleanUp();
    }
}
