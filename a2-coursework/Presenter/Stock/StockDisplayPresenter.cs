using a2_coursework._Helpers;
using a2_coursework.Model;
using a2_coursework.View.Interfaces.Stock;

namespace a2_coursework.Presenter.Stock;
public class StockDisplayPresenter {
    private readonly IStockDisplay _view;
    private List<StockItem>? _stockItems;

    private CancellationTokenSource? _cancellationTokenSource;
    private Task? _searchTask;

    public StockDisplayPresenter(IStockDisplay view) {
        _view = view;

        LoadData();

        _view.ShowArchivedChanged += (s, e) => DisplayData();
        _view.Search += (s, e) => Search();
    }

    public async void LoadData() {
        _view.DataGridText = "Loading...";

        try {
            _stockItems = await StockDAL.GetStock();
            _stockItems.Sort((a, b) => a.Id.CompareTo(b.Id));

            _view.DataGridText = "";

            DisplayData();
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

    private void DisplayData() {
        _view.ClearData();

        if (_stockItems is null) return;
        
        if (_view.ShowArchived) _view.DisplayData(_stockItems.ConvertAll(ConvertStockItemForDisplay));
        else _view.DisplayData(_stockItems.FindAll(stockItem => !stockItem.Archived).ConvertAll(ConvertStockItemForDisplay));
    }

    private async void Search() {
        _view.ClearData();
        _view.DataGridText = "Loading...";

        _cancellationTokenSource?.Cancel();
        _cancellationTokenSource = new CancellationTokenSource();
        CancellationToken token = _cancellationTokenSource.Token;

        try {
            Task searchTask = Task.Run(() => {
                if (_view.SearchText == "") {
                    _stockItems = _stockItems?.OrderBy(stockItem => {
                        if (token.IsCancellationRequested) throw new OperationCanceledException();
                        return stockItem.Id;
                        }).ToList();
                }
                else {
                    _stockItems = _stockItems?.OrderBy(stockItem => {
                        if (token.IsCancellationRequested) throw new OperationCanceledException();
                        return MathF.Min((float)GeneralHelpers.LevensteinDistance(_view.SearchText.ToLower(), stockItem.Name.ToLower()) / stockItem.Name.Length, (float)(MathF.Pow(GeneralHelpers.LevensteinDistance(_view.SearchText.ToLower(), stockItem.SKU.ToLower()), 2) + 1) / MathF.Pow(stockItem.SKU.Length, 2));
                    }).ToList();
                }
            });

            await Task.WhenAll(searchTask, Task.Delay(500, token));

            if (token.IsCancellationRequested) throw new OperationCanceledException();
            _view.DataGridText = "";
            DisplayData();
        }
        catch (OperationCanceledException) { }
    }
}
