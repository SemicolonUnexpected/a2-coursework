using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Order;
using a2_coursework.Model.Order;
using a2_coursework.Model.Staff;
using a2_coursework.View.Order;

namespace a2_coursework.Presenter.Order;
public class ViewOrderPresenter : ParentViewPresenter<IViewOrderView, OrderModel>, IChildPresenter, INavigatingPresenter {
    private readonly StaffModel _staff;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public ViewOrderPresenter(IViewOrderView view, OrderModel model, StaffModel staff) : base(view, model) {
        _staff = staff;

        _view.Back += OnBack;

        _view.DiscrepanciesVisible = model.Status == "Delivered";

        Navigate(GetManageStock());
    }

    private void OnBack(object? sender, EventArgs e) => NavigateBack();
    private void OnReceive(object? sender, EventArgs e) => Receive();

    protected override void Navigate(IChildView view, ICleanable presenter) {
        if (_childPresenter is SubmitOrderPresenter currentSubmitOrderPresenter) currentSubmitOrderPresenter.Receive -= OnReceive;

        base.Navigate(view, presenter);

        if (_childPresenter is SubmitOrderPresenter submitOrderPresenter) submitOrderPresenter.Receive += OnReceive;
    }

    private void NavigateBack() {
        if (!CanExit()) return;

        (IChildView view, IChildPresenter presenter) viewPresenter;

        if (_staff.PrivilegeLevel == PrivilegeLevel.CleaningManager) viewPresenter = OrderFactory.CreateDisplayOrder(_staff);
        else viewPresenter = OrderFactory.CreateApproveRejectOrder(_staff);

        NavigationRequest?.Invoke(this, new NavigationEventArgs(viewPresenter.view, viewPresenter.presenter));
    }

    private void Receive() {
        if (!CanExit()) return;

        (IChildView view, IChildPresenter presenter) = OrderFactory.CreateReceiveOrder(_model, _staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override (IChildView childView, ICleanable childPresenter) GetView(string selectedItem) => selectedItem switch {
        "Quantity" => GetManageStock(),
        "Details" => GetDetails(),
        "Discrepancies" => GetDiscrepancies(),
        _ => throw new NotImplementedException(),
    };

    #region Manage Stock
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetManageStock() {
        (ManageOrderStockView view, ManageOrderStockPresenter presenter) = OrderFactory.CreateManageOrderStock();

        presenter.Models = _model.StockItems;
        presenter.ReadOnly = true;

        return (view, presenter);
    }
    #endregion

    #region Details
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetDetails() {
        (SubmitOrderView view, SubmitOrderPresenter presenter) = OrderFactory.CreateSubmitOrder();

        presenter.Description = _model.Description;
        presenter.Receivable = _model.Status == "Pending";
        presenter.ButtonVisible = _staff.PrivilegeLevel == PrivilegeLevel.CleaningManager && (_model.Status == "Pending" || _model.Status == "Draft");
        presenter.ReadOnly = true;

        return (view, presenter);
    }
    #endregion

    #region Discrepancies
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetDiscrepancies() {
        (ManageOrderDiscrepanciesView view, ManageOrderDiscrepanciesPresenter presenter) = OrderFactory.CreateOrderDiscrepancies();

        presenter.Discrepancies = _model.Discrepancies;
        presenter.ReadOnly = true;

        return (view, presenter);
    }
    #endregion

    public override void CleanUp() {
        _view.Back -= OnBack;

        base.CleanUp();
    }
}
