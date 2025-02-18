using a2_coursework._Helpers;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Stock.StockManagement;
using a2_coursework.Model.Staff;
using a2_coursework.Model.Stock;
using a2_coursework.View;
using a2_coursework.View.Stock.StockManagement;

namespace a2_coursework.Presenter.Stock.StockManagement;
public class DisplayStockPresenter : DisplayPresenter<IDisplayStockView, StockModel, DisplayStockItem>, IChildPresenter, INavigatingPresenter {
    private readonly StaffModel _staff;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public DisplayStockPresenter(IDisplayStockView view, StaffModel staff) : base(view) {
        _staff = staff;

        LoadData();

        _view.Add += OnAdd;
        _view.Edit += OnEdit;
        _view.ArchiveToggled += OnArchiveToggled;
        _view.ShowArchivedChanged += OnShowArchivedChanged;
        _view.Search += OnSearch;
        _view.SelectionChanged += OnSelectionChanged;
        _view.SortRequested += OnSortRequested;
    }

    private void OnAdd(object? sender, EventArgs e) => Add();
    private void OnEdit(object? sender, EventArgs e) => Edit();
    private void OnShowArchivedChanged(object? sender, EventArgs e) {
        _view.DisableAll();
        DisplayItems();
        _view.EnableAll();
    }
    private void OnArchiveToggled(object? sender, EventArgs e) => ToggleArchived();
    private void OnSearch(object? sender, EventArgs e) => Search(_view.SearchText);
    private void OnSelectionChanged(object? sender, EventArgs e) => SelectionChanged();
    private void OnSortRequested(object? sender, SortRequestEventArgs e) => SortByColumn(e.ColumnName, e.SortAscending);

    protected override void DisplayItems() {
        _displayModels.Clear();
        _modelDisplayMap.Clear();

        IEnumerable<StockModel> models;
        if (!_view.ShowArchivedItems) models = FilterOutArchived(_models);
        else models = _models;

        foreach (StockModel stockItem in models) {
            DisplayStockItem displayStockItem = CreateDisplayItem(stockItem);
            _modelDisplayMap.Add(displayStockItem, stockItem);
            _displayModels.Add(displayStockItem);
        }

        _view.DisplayItems(_displayModels);
    }

    protected override DisplayStockItem CreateDisplayItem(StockModel stockItem) => new DisplayStockItem(stockItem);

    public async void LoadData() {
        _view.DataGridText = "Loading...";
        _view.DisableAll();

        try {
            _isAsyncRunning = true;

            _models = await StockDAL.GetStock();

            DisplayItems();

            _view.DataGridText = "";
            _view.EnableAll();
        }
        catch {
            _displayModels.Clear();
            _view.DataGridText = "Error getting stock from the database";
        }
        finally {
            _isAsyncRunning = false;
        }
    }

    private IEnumerable<StockModel> FilterOutArchived(IEnumerable<StockModel> stockItems) => stockItems.Where(x => !x.Archived);

    protected override IComparable RankSearch(string searchText, StockModel stockItem) => MathF.Min((float)GeneralHelpers.LevensteinDistance(searchText, stockItem.Name.ToLower()) / stockItem.Name.Length, (float)(MathF.Pow(GeneralHelpers.LevensteinDistance(_view.SearchText.ToLower(), stockItem.SKU.ToLower()), 2) + 1) / MathF.Pow(stockItem.SKU.Length, 2));
    protected override List<StockModel> OrderDefault(List<StockModel> models) => models.OrderBy(model => model.Id).ToList();

    private void SelectionChanged() {
        if (_view.SelectedItem is null) return;
        _view.SelectedItemArchived = _modelDisplayMap[_view.SelectedItem].Archived;
    }

    private async void ToggleArchived() {
        if (_isAsyncRunning) return;

        if (_view.SelectedItem is null) {
            _view.SelectedItemArchived = false;
            return;
        }

        _view.DisableAll();

        StockModel stockItem = _modelDisplayMap[_view.SelectedItem];

        try {
            _isAsyncRunning = true;

            bool success = await StockDAL.UpdateArchived(stockItem.Id, !stockItem.Archived);

            if (success) {
                stockItem.Archived = !stockItem.Archived;
                _view.SelectedItem.Archived = stockItem.Archived;
                if (!_view.ShowArchivedItems && _view.SelectedItem.Archived) _displayModels.Remove(_view.SelectedItem);
            }
        }
        catch { }
        finally {
            _view.EnableAll();
            _isAsyncRunning = false;
        }
    }

    private void Edit() {
        if (_view.SelectedItem is null) return;

        _cancellationTokenSource.Cancel();

        (IChildView view, IChildPresenter presenter) = ViewFactory.CreateEditStock(_modelDisplayMap[_view.SelectedItem], _staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    private void Add() {
        if (_view.SelectedItem is null) return;

        (IChildView view, IChildPresenter presenter) = ViewFactory.CreateAddStock(_staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void SortByColumn(string columnName, bool sortAscending) {
        if (_isAsyncRunning) return;

        switch (columnName) {
            case "columnID":
                SortBy(x => x.Id, sortAscending);
                break;
            case "columnName":
                SortBy(x => x.Name, sortAscending);
                break;
            case "columnSKU":
                SortBy(x => x.SKU, sortAscending);
                break;
            case "columnQuantity":
                SortBy(x => x.Quantity, sortAscending);
                break;
            case "columnQuantityLevel":
                SortBy(ConvertQuantityLevelToInt, sortAscending);
                break;
            case "columnArchived":
                SortBy(x => x.Archived, sortAscending);
                break;

            default:
                throw new NotImplementedException("Invalid column name");
        }

        DisplayItems();
    }

    private int ConvertQuantityLevelToInt(StockModel stockItem) {
        if (stockItem.Quantity >= stockItem.HighQuantity) return 1;
        else if (stockItem.Quantity <= stockItem.LowQuantity) return 3;
        else return 2;
    }

    public override void CleanUp() {
        _view.Add -= OnAdd;
        _view.Edit -= OnEdit;
        _view.ArchiveToggled -= OnArchiveToggled;
        _view.ShowArchivedChanged -= OnShowArchivedChanged;
        _view.Search -= OnSearch;
        _view.SelectionChanged -= OnSelectionChanged;
        _view.SortRequested -= OnSortRequested;

        base.CleanUp();
    }
}
