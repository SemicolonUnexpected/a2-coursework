using a2_coursework._Helpers;
using a2_coursework.Interfaces.Order;
using a2_coursework.Model.Stock;
using a2_coursework.View;
using a2_coursework.View.Stock.StockManagement;

namespace a2_coursework.Presenter.Order;

public class SelectOrderStockPresenter : DisplayPresenter<ISelectOrderStockView, StockModel, DisplayStockModel>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public SelectOrderStockPresenter(ISelectOrderStockView view) : base(view) {
        LoadData();

        _view.SelectionChanged += OnSelectionChanged;
        _view.SortRequested += OnSortRequested;
    }

    private void OnSelectionChanged(object? sender, EventArgs e) => DetailsChanged?.Invoke(this, EventArgs.Empty);
    private void OnSortRequested(object? sender, SortRequestEventArgs e) => SortByColumn(e.ColumnName, e.SortAscending);

    private async void LoadData() {
        _view.DataGridText = "Loading...";
        _view.DisableAll();

        try {
            _isAsyncRunning = true;

            _models = await StockDAL.GetNonArchivedStock();

            DisplayItems();
            _view.SetSelectedItemsById(_setSelectedItems);

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

    protected override DisplayStockModel CreateDisplayItem(StockModel model) => new(model);

    protected override List<StockModel> OrderDefault(List<StockModel> models) => [.. models.OrderBy(x => x.Id)];

    protected override IComparable RankSearch(string searchText, StockModel model) => GeneralHelpers.SubstringLevenshteinDistance(searchText, model.Name);

    private List<int> _setSelectedItems = [];
    public List<StockModel> SelectedStockItems {
        get => _view.SelectedItems.ConvertAll(selectedItem => _modelDisplayMap[selectedItem]);
        set {
            _setSelectedItems = value.ConvertAll(x => x.Id);
            _view.SetSelectedItemsById(_setSelectedItems);
        }
    }

    protected override void SortByColumn(string columnName, bool sortAscending) {
        switch (columnName) {
            case "columnId":
                SortBy(x => x.Id, sortAscending);
                break;
            case "columnName":
                SortBy(x => x.Name, sortAscending);
                break;
            case "columnUnitCost":
                SortBy(x => x.UnitCost, sortAscending);
                break;

            default:
                throw new NotImplementedException();
        }

        DisplayItems();
        _view.SetSelectedItemsById(_setSelectedItems);
    }
}
