using a2_coursework._Helpers;
using a2_coursework.Model;
using a2_coursework.View;
using a2_coursework.View.Interfaces;
using a2_coursework.View.Interfaces.Stock;
using a2_coursework.View.Stock;
using System.ComponentModel;

namespace a2_coursework.Presenter.Stock;
public class DisplayStockPresenter : BasePresenter<IStockDisplayView>, IChildPresenter, INavigatingPresenter {
    private readonly Staff _staff;

    private List<StockItem> _stockItems = [];
    private BindingList<DisplayStockItem> _displayItems = [];
    private Dictionary<int, StockItem> _stockItemMap = [];

    private bool _isAsyncRunning;

    private CancellationTokenSource _cancellationTokenSource = new();

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public DisplayStockPresenter(IStockDisplayView view, Staff staff) : base(view) {
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
    private void OnShowArchivedChanged(object? sender, EventArgs e) => DisplayItems();
    private void OnArchiveToggled(object? sender, EventArgs e) => ToggleArchived();
    private void OnSearch(object? sender, EventArgs e) => Search();
    private void OnSelectionChanged(object? sender, EventArgs e) => SelectionChanged();
    private void OnSortRequested(object? sender, SortRequestEventArgs e) => SortByColumn(e.ColumnName, e.SortAscending);

    public async void LoadData() {
        _view.DataGridText = "Loading...";
        _view.DisableAll();

        try {
            _isAsyncRunning = true;

            _stockItems = await StockDAL.GetStock();

            _displayItems.Clear();
            _stockItemMap.Clear();

            foreach (StockItem stockItem in _stockItems) {
                _stockItemMap.Add(stockItem.Id, stockItem);

                if (!_view.ShowArchivedItems && stockItem.Archived) continue;

                DisplayStockItem displayStockItem = new(stockItem);
                _displayItems.Add(displayStockItem);
            }

            _view.DisplayItems(_displayItems);

            _view.DataGridText = "";
            _view.EnableAll();
        }
        catch {
            _displayItems.Clear();
            _view.DataGridText = "Error getting stock from the database";
        }
        finally {
            _isAsyncRunning = false;
        }
    }

    private void DisplayItems() {
        _displayItems.Clear();

        foreach (StockItem stockItem in _stockItems) {
            if (!_view.ShowArchivedItems && stockItem.Archived) continue;

            DisplayStockItem displayStockItem = new(stockItem);
            _displayItems.Add(displayStockItem);
        }

        _view.DisplayItems(_displayItems);
    }

    private async void Search() {
        if (_isAsyncRunning) return;

        _displayItems.Clear();

        _cancellationTokenSource.Cancel();
        _cancellationTokenSource = new CancellationTokenSource();
        CancellationToken token = _cancellationTokenSource.Token;

        try {
            _stockItems = await Task.Run(() => {
                List<StockItem> stockItems = _stockItems.ToList();
                string searchText = _view.SearchText.ToLower();

                if (string.IsNullOrWhiteSpace(_view.SearchText)) {
                    stockItems = stockItems.OrderBy(x => x.Id).ToList();
                }
                else {
                    stockItems = [.. stockItems.OrderBy(stockItem => {
                        token.ThrowIfCancellationRequested();
                        return Rank(searchText, stockItem);
                    })];
                }

                token.ThrowIfCancellationRequested();
                return stockItems;
            }, token);

            DisplayItems();
        }
        catch (OperationCanceledException) { }
    }

    private float Rank(string searchText, StockItem stockItem) => MathF.Min((float)GeneralHelpers.LevensteinDistance(searchText, stockItem.Name.ToLower()) / stockItem.Name.Length, (float)(MathF.Pow(GeneralHelpers.LevensteinDistance(_view.SearchText.ToLower(), stockItem.SKU.ToLower()), 2) + 1) / MathF.Pow(stockItem.SKU.Length, 2));

    private void SelectionChanged() {
        if (_view.SelectedItem is null) return;
        _view.SelectedItemArchived = _stockItemMap[_view.SelectedItem.Id].Archived;
    }

    private async void ToggleArchived() {
        if (_isAsyncRunning) return;

        if (_view.SelectedItem is null) {
            _view.SelectedItemArchived = false;
            return;
        }

        _view.DisableAll();

        StockItem stockItem = _stockItemMap[_view.SelectedItem.Id];

        try {
            _isAsyncRunning = true;

            bool success = await StockDAL.UpdateArchived(stockItem.Id, !stockItem.Archived);

            if (success) {
                stockItem.Archived = !stockItem.Archived;
                _view.SelectedItem.Archived = stockItem.Archived;
                if (!_view.ShowArchivedItems && _view.SelectedItem.Archived) _displayItems.Remove(_view.SelectedItem);
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

        (IChildView view, IChildPresenter presenter) = ViewFactory.CreateEditStock(_stockItemMap[_view.SelectedItem.Id], _staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    private void Add() {
        if (_view.SelectedItem is null) return;

        //Navigate?.Invoke(this, ViewFactory.CreateEditStock(_stockItemMap[_view.SelectedItem.Id]));
    }

    private void SortByColumn(string columnName, bool sortAscending) {
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

    private void SortBy<T>(Func<StockItem, T> property, bool sortAscending) where T : IComparable {
        if (sortAscending) _stockItems.Sort((a, b) => property(a).CompareTo(property(b)));
        else _stockItems.Sort((a, b) => property(b).CompareTo(property(a)));
    }

    private int ConvertQuantityLevelToInt(StockItem stockItem) {
        if (stockItem.Quantity >= stockItem.HighQuantity) return 1;
        else if (stockItem.Quantity <= stockItem.LowQuantity) return 3;
        else return 2;
    }

    public bool CanExit() {
        _cancellationTokenSource.Cancel();
        return !_isAsyncRunning;
    }

    public override void CleanUp() {
        _cancellationTokenSource.Cancel();
        _cancellationTokenSource.Dispose();

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
