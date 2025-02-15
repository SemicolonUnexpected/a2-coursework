using a2_coursework._Helpers;
using a2_coursework.Model;
using a2_coursework.View;
using a2_coursework.View.Interfaces;
using a2_coursework.View.Interfaces.Stock;
using a2_coursework.View.Stock;
using System.ComponentModel;

namespace a2_coursework.Presenter.Stock;
public class StockDisplayPresenter : BasePresenter<IStockDisplay>, IChildPresenter, INavigatingPresenter {
    private List<StockItem> _stockItems = [];
    private BindingList<DisplayStockItem> _displayItems = [];
    private Dictionary<int, StockItem> _stockItemMap = [];

    private bool _isAsyncRunning;

    private CancellationTokenSource _cancellationTokenSource = new();

    public event EventHandler<(IChildView view, IChildPresenter presenter)>? Navigate;

    public StockDisplayPresenter(IStockDisplay view) : base(view) {
        LoadData();

        _view.Add += OnAdd;
        _view.Edit += OnEdit;
        _view.ArchiveToggled += OnArchiveToggled;
        _view.ShowArchivedChanged += OnShowArchivedChanged;
        _view.Search += OnSearch;
        _view.SelectionChanged += OnSelectionChanged;
    }

    private void OnAdd(object? sender, EventArgs e) => Add();
    private void OnEdit(object? sender, EventArgs e) => Edit();
    private void OnShowArchivedChanged(object? sender, EventArgs e) => DisplayItems(_stockItems);
    private void OnArchiveToggled(object? sender, EventArgs e) => ToggleArchived();
    private void OnSearch(object? sender, EventArgs e) => Search();
    private void OnSelectionChanged(object? sender, EventArgs e) => Search();

    public async void LoadData() {
        _view.DataGridText = "Loading...";
        _view.DisableAll();

        try {
            _isAsyncRunning = true;

            _stockItems = await StockDAL.GetStock();

            _displayItems.Clear();
            _stockItemMap.Clear();

            foreach (StockItem stockItem in _stockItems) {
                if (!_view.ShowArchivedItems && stockItem.IsArchived) continue;

                DisplayStockItem displayStockItem = new(stockItem);
                _displayItems.Add(displayStockItem);
                _stockItemMap.Add(stockItem.Id, stockItem);
            }

            _view.DisplayItems(_displayItems);

            _view.DataGridText = "";
            _view.EnableAll();
        }
        catch {
            _view.DataGridText = "Error getting stock from the database";
        }
        finally {
            _isAsyncRunning = false;
        }
    }

    private void DisplayItems(List<StockItem> stockItems) {
        _displayItems.Clear();

        foreach (StockItem stockItem in stockItems) {
            if (!_view.ShowArchivedItems && stockItem.IsArchived) continue;

            DisplayStockItem displayStockItem = new(stockItem);
            _displayItems.Add(displayStockItem);
        }
    }

    private void Search() {
        _displayItems.Clear();

        _cancellationTokenSource.Cancel();
        _cancellationTokenSource = new CancellationTokenSource();
        CancellationToken token = _cancellationTokenSource.Token;

        try {
            Task searchTask = Task.Run(() => {
                if (string.IsNullOrWhiteSpace(_view.SearchText)) {
                    _stockItems = _stockItems.OrderBy(stockItem => {
                        token.ThrowIfCancellationRequested();
                        return stockItem.Id;
                    }).ToList();
                }
                else {
                    _stockItems = _stockItems.OrderBy(stockItem => {
                        token.ThrowIfCancellationRequested();
                        return MathF.Min((float)GeneralHelpers.LevensteinDistance(_view.SearchText.ToLower(), stockItem.Name.ToLower()) / stockItem.Name.Length, (float)(MathF.Pow(GeneralHelpers.LevensteinDistance(_view.SearchText.ToLower(), stockItem.SKU.ToLower()), 2) + 1) / MathF.Pow(stockItem.SKU.Length, 2));
                    }).ToList();
                }

                token.ThrowIfCancellationRequested();
                DisplayItems(_stockItems);
            }, token);
        }
        catch (OperationCanceledException) { }
    }

    private void SelectionChanged(object? sender, EventArgs e) {
        if (_view.SelectedItem is null) return;
        _view.SelectedItemArchived = _stockItemMap[_view.SelectedItem.Id].IsArchived;
    }

    private async void ToggleArchived() {
        if (_view.SelectedItem is null) {
            _view.SelectedItemArchived = false;
            return;
        }

        _view.DisableAll();

        StockItem stockItem = _stockItemMap[_view.SelectedItem.Id];

        try {
            _isAsyncRunning = true;

            bool success = await StockDAL.UpdateArchived(stockItem.Id, !stockItem.IsArchived);

            if (success) {
                stockItem.IsArchived = !stockItem.IsArchived;
                _view.SelectedItem.IsArchived = stockItem.IsArchived;
                if (!_view.ShowArchivedItems && _view.SelectedItem.IsArchived) _displayItems.Remove(_view.SelectedItem);
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

        Navigate?.Invoke(this, ViewFactory.CreateEditStock(_stockItemMap[_view.SelectedItem.Id]));
    }

    private void Add() {
        if (_view.SelectedItem is null) return;

        Navigate?.Invoke(this, ViewFactory.CreateEditStock(_stockItemMap[_view.SelectedItem.Id]));
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

        base.CleanUp();
    }
}
