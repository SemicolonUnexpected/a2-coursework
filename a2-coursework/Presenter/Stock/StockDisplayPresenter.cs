using a2_coursework._Helpers;
using a2_coursework.Model;
using a2_coursework.View.Interfaces.Stock;

namespace a2_coursework.Presenter.Stock; 
public class StockDisplayPresenter {
    private readonly IStockDisplay _view;
    private readonly List<StockItem> _stockItems;

    private bool _sortAscending = true;

    public StockDisplayPresenter(IStockDisplay view, List<StockItem> stockItems) {
        _view = view;
        _stockItems = stockItems;

        DisplayData();

        _view.DataGridResized += (s, e) => DisplayData();
        _view.PageChanged += (s, e) => DisplayData();


        _view.Search += (s, e) => Search();
        _view.NameOrder += (s, e) => NameOrder();
    }

    private int CalculateRowsPerPage() => _view.DisplayHeight / _view.RowHeight;
    private int CalculateNumberOfPages() {
        if (_view.ShowArchived) return (int)Math.Ceiling((float)_stockItems.Count / CalculateRowsPerPage());
        else return (int)Math.Ceiling((float)_stockItems.Count(stockItem => stockItem.Archived) / CalculateNumberOfPages());
    }

    private object[] ConvertStockItemToDisplayData(StockItem stock) {
        string quantityLevelText;
        if (stock.Quantity < stock.LowQuantity) quantityLevelText = "Low";
        else if (stock.Quantity > stock.HighQuantity) quantityLevelText = "High";
        else quantityLevelText = "Medium";
        
        return [stock.Id, stock.Name, stock.SKU, stock.Quantity, quantityLevelText, stock.Archived];
    }

    private void DisplayData() {
        if (_stockItems.Count == 0) {
            _view.ShowNoStocksToDisplay = true;
            return;
        }

        int rowsPerPage = CalculateRowsPerPage();
        int numberOfPages = CalculateNumberOfPages();

        List<StockItem> stockSublist = _stockItems.Slice((_view.CurrentPageNumber - 1) * rowsPerPage, rowsPerPage);
        _view.DisplayStock(stockSublist.ConvertAll(ConvertStockItemToDisplayData));
    }

    private void Search() {
        _stockItems.OrderBy(stockItem => GeneralHelpers.LevensteinDistance(_view.SearchText, stockItem.Name + stockItem.SKU));
    }

    private void NameOrder() {
        //_stockItems.OrderBy(stockItem => stockItem.Name
    }
}
