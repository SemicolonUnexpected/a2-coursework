using a2_coursework._Helpers;
using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Order;
using a2_coursework.Model.Order;
using a2_coursework.Model.Staff;
using a2_coursework.View;
using a2_coursework.View.Order;

namespace a2_coursework.Presenter.Order;

public class ApproveRejectOrderPresenter : DisplayPresenter<IApproveRejectOrderView, OrderModel, DisplayOrderModel>, IChildPresenter, INavigatingPresenter {
    private readonly StaffModel _staff;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public ApproveRejectOrderPresenter(IApproveRejectOrderView view, StaffModel staff) : base(view) {
        _staff = staff;

        LoadData();

        _view.View += OnView;
        _view.Approve += OnApprove;
        _view.Reject += OnReject;
        _view.Search += OnSearch;
        _view.SortRequested += OnSortRequested;
    }

    private void OnReject(object? sender, EventArgs e) => Reject();
    private void OnApprove(object? sender, EventArgs e) => Approve();
    private void OnView(object? sender, EventArgs e) => View();
    private void OnSearch(object? sender, EventArgs e) => Search(_view.SearchText);
    private void OnSortRequested(object? sender, SortRequestEventArgs e) => SortByColumn(e.ColumnName, e.SortAscending);

    protected override void DisplayItems() {
        _displayModels.Clear();
        _modelDisplayMap.Clear();

        foreach (OrderModel order in _models) {
            DisplayOrderModel displayOrder = CreateDisplayItem(order);
            _modelDisplayMap.Add(displayOrder, order);
            _displayModels.Add(displayOrder);
        }

        _view.DisplayItems(_displayModels);
    }

    protected override DisplayOrderModel CreateDisplayItem(OrderModel order) => new DisplayOrderModel(order);

    public async void LoadData() {
        _view.DataGridText = "Loading...";
        _view.DisableAll();

        try {
            _isAsyncRunning = true;

            _models = [.. (await OrderDAL.GetOrders()).Where(x => x.Status != "Draft")];

            DisplayItems();

            _view.DataGridText = "";
            _view.EnableAll();
        }
        catch {
            _displayModels.Clear();
            _view.DataGridText = "Error getting orders from the database";
        }
        finally {
            _isAsyncRunning = false;
        }
    }

    protected override IComparable RankSearch(string searchText, OrderModel order) {
        return Math.Min(
            (float)GeneralHelpers.SubstringLevenshteinDistance(searchText, $"{order.Staff?.Forename} {order.Staff?.Surname}") / $"{order.Staff?.Forename} {order.Staff?.Surname}".Length,
            (float)GeneralHelpers.SubstringLevenshteinDistance(searchText, order.Status) / order.Status.Length
            );
    }

    protected override List<OrderModel> OrderDefault(List<OrderModel> models) => [.. models.OrderByDescending(model => model.Id)];

    private async void Approve() {
        if (_isAsyncRunning) return;

        if (_view.SelectedItem is null || _view.SelectedItem.Status != "Submitted") return;

        _view.DisableAll();

        DisplayOrderModel displayModel = _view.SelectedItem;
        OrderModel model = _modelDisplayMap[displayModel];

        try {
            _isAsyncRunning = true;

            bool success = await OrderDAL.ApproveOrder(model.Id);

            if (success) {
                model.Status = "Pending";
                displayModel.Status = "Pending";
            }
        }
        catch { }
        finally {
            _view.EnableAll();
            _isAsyncRunning = false;
        }
    }

    private async void Reject() {
        if (_isAsyncRunning) return;

        if (_view.SelectedItem is null || _view.SelectedItem.Status != "Submitted") return;

        _view.DisableAll();

        DisplayOrderModel displayModel = _view.SelectedItem;
        OrderModel model = _modelDisplayMap[displayModel];

        try {
            _isAsyncRunning = true;

            bool success = await OrderDAL.RejectOrder(model.Id);

            if (success) {
                model.Status = "Rejected";
                displayModel.Status = "Rejected";
            }
        }
        catch { }
        finally {
            _view.EnableAll();
            _isAsyncRunning = false;
        }
    }

    private void View() {
        if (_view.SelectedItem is null) return;

        _cancellationTokenSource.Cancel();

        (IChildView view, IChildPresenter presenter) = OrderFactory.CreateViewOrder(_modelDisplayMap[_view.SelectedItem], _staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void SortByColumn(string columnName, bool sortAscending) {
        if (_isAsyncRunning) return;

        switch (columnName) {
            case "columnId":
                SortBy(x => x.Id, sortAscending);
                break;
            case "columnStaff":
                SortBy(x => $"{x.Staff!.Forename} {x.Staff.Surname}", sortAscending);
                break;
            case "columnStatus":
                SortBy(x => x.Status, sortAscending);
                break;
            default:
                throw new NotImplementedException("Invalid column name");
        }

        DisplayItems();
    }

    public override void CleanUp() {
        _view.SortRequested -= OnSortRequested;

        base.CleanUp();
    }
}
