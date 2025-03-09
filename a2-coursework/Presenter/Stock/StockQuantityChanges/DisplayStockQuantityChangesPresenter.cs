using a2_coursework._Helpers;
using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Stock.StockQuantityChanges;
using a2_coursework.Model.Stock;
using a2_coursework.View;
using a2_coursework.View.Stock.StockQuantityChanges;

namespace a2_coursework.Presenter.Stock.StockQuantityChanges;
public class DisplayStockQuantityChangesPresenter : DisplayPresenter<IDisplayStockQuantityChangesView, StockQuantityChange, DisplayStockQuantityChangeModel>, IChildPresenter, INavigatingPresenter {
    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public DisplayStockQuantityChangesPresenter(IDisplayStockQuantityChangesView view) : base(view) {
        LoadData();

        _view.View += OnView;
        _view.Search += OnSearch;
        _view.SortRequested += OnSortRequested;
        _view.ShowArchivedChanged += OnShowArchivedChanged;
    }

    private void OnView(object? sender, EventArgs e) => View();
    private void OnShowArchivedChanged(object? sender, EventArgs e) {
        _view.DisableAll();
        DisplayItems();
        _view.EnableAll();
    }
    private void OnSearch(object? sender, EventArgs e) => Search(_view.SearchText);
    private void OnSortRequested(object? sender, SortRequestEventArgs e) => SortByColumn(e.ColumnName, e.SortAscending);

    public async void LoadData() {
        _view.DataGridText = "Loading...";
        _view.DisableAll();

        try {
            _isAsyncRunning = true;

            _models = OrderDefault(await StockDAL.GetStockQuantityChanges());

            DisplayItems();

            _view.DataGridText = "";
            _view.EnableAll();
        }
        catch {
            _displayModels.Clear();
            _view.DataGridText = "Error getting stock quantity changes from the database";
        }
        finally {
            _isAsyncRunning = false;
        }
    }

    protected override void DisplayItems() {
        _displayModels.Clear();
        _modelDisplayMap.Clear();

        IEnumerable<StockQuantityChange> models;
        if (!_view.ShowArchivedItems) models = FilterOutArchived(_models);
        else models = _models;

        foreach (StockQuantityChange stockQuantityChange in models) {
            DisplayStockQuantityChangeModel displayStockQuantityChange = CreateDisplayItem(stockQuantityChange);
            _modelDisplayMap.Add(displayStockQuantityChange, stockQuantityChange);
            _displayModels.Add(displayStockQuantityChange);
        }

        _view.DisplayItems(_displayModels);
    }

    protected override DisplayStockQuantityChangeModel CreateDisplayItem(StockQuantityChange model) => new DisplayStockQuantityChangeModel(model);

    private IEnumerable<StockQuantityChange> FilterOutArchived(IEnumerable<StockQuantityChange> stockItems) => stockItems.Where(x => !x.StockArchived);

    protected override List<StockQuantityChange> OrderDefault(List<StockQuantityChange> models) => models.OrderByDescending(model => model.Date).ToList();

    protected override IComparable RankSearch(string searchText, StockQuantityChange model) {
        float stockNameDistance = (float)GeneralHelpers.LevensteinDistance(searchText, model.StockName) / model.StockName.Length;
        float stockSKUDistance = (float)GeneralHelpers.LevensteinDistance(searchText, model.StockSKU) / model.StockSKU.Length;
        float staffUsernameDistance = (float)GeneralHelpers.LevensteinDistance(searchText, model.StaffUsername) / model.StaffUsername.Length;
        float dateDistance = (float)GeneralHelpers.LevensteinDistance(searchText, model.Date.ToString()) / model.StaffUsername.Length;

        float minDistance = Math.Min(Math.Min(stockNameDistance, stockSKUDistance), Math.Min(staffUsernameDistance, dateDistance));

        return minDistance;
    }

    protected override void SortByColumn(string columnName, bool sortAscending) {
        if (_isAsyncRunning) return;

        switch (columnName) {
            case "columnUsername":
                SortBy(x => x.StaffUsername, sortAscending);
                break;
            case "columnStockName":
                SortBy(x => x.StockName, sortAscending);
                break;
            case "columnSku":
                SortBy(x => x.StockSKU, sortAscending);
                break;
            case "columnQuantity":
                SortBy(x => x.Quantity, sortAscending);
                break;
            case "columnDate":
                SortBy(x => x.Date, !sortAscending);
                break;
            case "columnArchived":
                SortBy(x => x.StockArchived, sortAscending);
                break;

            default:
                throw new NotImplementedException("Invalid column name");
        }

        DisplayItems();
    }

    private void View() {
        if (_view.SelectedItem is null) return;

        (IChildView view, IChildPresenter presenter) = StockFactory.CreateViewStockQuantityChange(_modelDisplayMap[_view.SelectedItem]);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    public override void CleanUp() {
        _view.View -= OnView;
        _view.Search -= OnSearch;
        _view.SortRequested -= OnSortRequested;
        _view.ShowArchivedChanged -= OnShowArchivedChanged;

        base.CleanUp();
    }
}
