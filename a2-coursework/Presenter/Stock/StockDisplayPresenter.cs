using a2_coursework._Helpers;
using a2_coursework.Model;
using a2_coursework.View.Interfaces.Stock;

namespace a2_coursework.Presenter.Stock;
public class StockDisplayPresenter : BasePresenter<IStockDisplay>, IChildPresenter {
    private List<StockItem>? _stockItems;
    private Dictionary<int, StockItem>? _stockItemsDictionary;

    private CancellationTokenSource? _cancellationTokenSource;
    private Task? _searchTask;

    public StockDisplayPresenter(IStockDisplay view) : base(view) {
        LoadData();

        _view.ShowArchivedChanged += DisplayData;
        _view.Search += Search;
        _view.SelectionChanged += SelectionChanged;
        _view.ArchiveToggled += ArchiveToggled;
        _view.Edit += Edit;
        _view.Add += Add;
    }

    public async void LoadData() {
        _view.DataGridText = "Loading...";

        try {
            _stockItemsDictionary = await StockDAL.GetStock();
            _stockItems = _stockItemsDictionary.Values.ToList();
            _stockItems.Sort((a, b) => a.Id.CompareTo(b.Id));

            _view.DataGridText = "";

            DisplayData(null, EventArgs.Empty);
        }
        catch {
            _view.DataGridText = "Error getting data from the database";
            _view.DisableAll();
        }
    }

    private object[] ConvertStockItemForDisplay(StockItem stockItem) {
        string quantityLevel;
        if (stockItem.Quantity >= stockItem.HighQuantity) quantityLevel = "High";
        else if (stockItem.Quantity <= stockItem.LowQuantity) quantityLevel = "Low";
        else quantityLevel = "Medium";

        return [stockItem.Id, stockItem.Name, stockItem.SKU, stockItem.Quantity, quantityLevel, stockItem.Archived ? "Yes" : "No"];
    }

    private void DisplayData(object? sender, EventArgs e) {
        _view.ClearData();

        if (_stockItems is null) return;
        
        if (_view.ShowArchivedStockItem) _view.DisplayData(_stockItems.ConvertAll(ConvertStockItemForDisplay));
        else _view.DisplayData(_stockItems.FindAll(stockItem => !stockItem.Archived).ConvertAll(ConvertStockItemForDisplay));
    }

    private async void Search(object? sender, EventArgs e) {
        _view.ClearData();
        _view.DataGridText = "Loading...";

        _cancellationTokenSource?.Cancel();
        _cancellationTokenSource = new CancellationTokenSource();
        CancellationToken token = _cancellationTokenSource.Token;

        try {
            Task searchTask = Task.Run(() => {
                if (_view.SearchText == "") {
                    _stockItems = _stockItems?.OrderBy(stockItem => {
                        token.ThrowIfCancellationRequested();
                        return stockItem.Id;
                        }).ToList();
                }
                else {
                    _stockItems = _stockItems?.OrderBy(stockItem => {
                        token.ThrowIfCancellationRequested();
                        return MathF.Min((float)GeneralHelpers.LevensteinDistance(_view.SearchText.ToLower(), stockItem.Name.ToLower()) / stockItem.Name.Length, (float)(MathF.Pow(GeneralHelpers.LevensteinDistance(_view.SearchText.ToLower(), stockItem.SKU.ToLower()), 2) + 1) / MathF.Pow(stockItem.SKU.Length, 2));
                    }).ToList();
                }
            });

            await Task.WhenAll(searchTask, Task.Delay(500, token));
            token.ThrowIfCancellationRequested();
            _view.DataGridText = "";
            DisplayData(null, EventArgs.Empty);
        }
        catch (OperationCanceledException) { }
    }

    private void SelectionChanged(object? sender, EventArgs e) {
        if (_view.SelectedRow is DataGridViewRow row) {
            _view.StockItemArchived = _stockItemsDictionary![Convert.ToInt32(row.Cells[0].Value)]!.Archived;
        }
        else {
            _view.StockItemArchived = false;
        }
    }

    private async void ArchiveToggled(object? sender, EventArgs e) {
        if (_view.SelectedRow is null) {
            _view.StockItemArchived = false;
            return;
        }

        DataGridViewRow row = _view.SelectedRow;
        _view.DisableAll();

        int id = Convert.ToInt32(row.Cells[0].Value);
        StockItem stockItem = _stockItemsDictionary![id];

        try {
            bool success = await StockDAL.UpdateArchived(stockItem.Id, _view.StockItemArchived);

            if (success) {
                stockItem.Archived = _view.StockItemArchived;
                UpdateRow(row, ConvertStockItemForDisplay(stockItem));
                if (!_view.ShowArchivedStockItem) _view.RemoveRow(row);
            }
        }
        catch {
        }
        finally {
            _view.EnableAll();
        }
    }

    private void UpdateRow(DataGridViewRow row, object[] values) {
        for (int i = 0; i < values.Length; i++) {
            row.Cells[i].Value = values[i];
        }
    }

    private void Edit(object? sender, EventArgs e) {
    }

    private void Add(object? sender, EventArgs e) {
    }

    public bool CanExit() => true;

    public override void CleanUp() {
        _view.ShowArchivedChanged -= DisplayData;
        _view.Search -= Search;
        _view.SelectionChanged -= SelectionChanged;
        _view.ArchiveToggled -= ArchiveToggled;
        _view.Edit -= Edit;
        _view.Add -= Add;

        base.CleanUp();
    }
}
