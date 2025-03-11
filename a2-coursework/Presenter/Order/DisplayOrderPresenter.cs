using a2_coursework._Helpers;
using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Order;
using a2_coursework.Model.Order;
using a2_coursework.Model.Staff;
using a2_coursework.View;
using a2_coursework.View.Order;

namespace a2_coursework.Presenter.Order;

public class DisplayOrderPresenter : DisplayPresenter<IDisplayOrderView, OrderModel, DisplayOrderModel>, IChildPresenter, INavigatingPresenter {
    private readonly StaffModel _staff;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public DisplayOrderPresenter(IDisplayOrderView view, StaffModel staff) : base(view) {
        _staff = staff;

        LoadData();

        _view.Add += OnAdd;
        _view.Edit += OnEdit;
        _view.Search += OnSearch;
        _view.View += OnView;
        _view.SelectionChanged += OnSelectionChanged;
        _view.SortRequested += OnSortRequested;
    }

    private void OnView(object? sender, EventArgs e) => View();
    private void OnAdd(object? sender, EventArgs e) => Add();
    private void OnEdit(object? sender, EventArgs e) => Edit();
    private void OnSearch(object? sender, EventArgs e) => Search(_view.SearchText);
    private void OnSelectionChanged(object? sender, EventArgs e) => SelectionChanged();
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

            _models = await OrderDAL.GetOrders();

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

    protected override IComparable RankSearch(string searchText, OrderModel order) => GeneralHelpers.LevensteinDistance(searchText, $"{order.Staff.Forename} {order.Staff.Surname} {order.Status}");

    protected override List<OrderModel> OrderDefault(List<OrderModel> models) => models.OrderBy(model => model.Id).ToList();

    private void SelectionChanged() {
        if (_view.SelectedItem is null) return;

        _view.ViewMode = _view.SelectedItem.Status != "Draft";
        _view.DeleteEnabled = _view.SelectedItem.Status != "Draft";
    }

    private void Edit() {
        if (_view.SelectedItem is null) return;

        _cancellationTokenSource.Cancel();

        (IChildView view, IChildPresenter presenter) = OrderFactory.CreateEditOrder(_modelDisplayMap[_view.SelectedItem], _staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    private void Add() {
        if (_view.SelectedItem is null) return;

        _cancellationTokenSource.Cancel();

        (IChildView view, IChildPresenter presenter) = OrderFactory.CreateAddOrder(_staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    private void View() {
        if (_view.SelectedItem is null) return;

        _cancellationTokenSource.Cancel();

        (IChildView view, IChildPresenter presenter) = OrderFactory.CreateViewOrder(_modelDisplayMap[_view.SelectedItem]);
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
        _view.Add -= OnAdd;
        _view.Edit -= OnEdit;
        _view.Search -= OnSearch;
        _view.SelectionChanged -= OnSelectionChanged;
        _view.SortRequested -= OnSortRequested;

        base.CleanUp();
    }
}
