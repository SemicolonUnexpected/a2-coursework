using a2_coursework._Helpers;
using a2_coursework.Interfaces.Order;
using a2_coursework.Model.Stock;
using a2_coursework.View.Stock.StockManagement;

namespace a2_coursework.Presenter.Order;
public class ManageOrderStockPresenter : DisplayPresenter<IManageOrderStockView, StockModel, DisplayStockModel>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public ManageOrderStockPresenter(IManageOrderStockView view) : base(view) {
        _view.SelectionChanged += OnSelectedItemChanged;
        _view.QuantityChanged += OnQuantityChanged;
    }

    private void OnSelectedItemChanged(object? sender, EventArgs e) {
        if (_view.SelectedItem is not null) LoadDetails(_modelDisplayMap[_view.SelectedItem]);
        else {
            _view.StockName = "";
            _view.StockDescription = "";
            _view.Quantity = 0;
            _view.Subtotal = 0;
            _view.Total = CalculateTotal();
        }
    }

    private void OnQuantityChanged(object? sender, EventArgs e) {
        ChangeQuantity();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    private void ChangeQuantity() {
        if (_view.SelectedItem is null) return;

        StockModel model = _modelDisplayMap[_view.SelectedItem!];
        _newQuantities[model.Id] = _view.Quantity;
        _view.Subtotal = _newQuantities[model.Id] * model.CostAtTime;
        _view.Total = CalculateTotal();
    }

    private decimal CalculateTotal() {
        decimal sum = 0;

        foreach (var model in _models) {
            sum += _newQuantities[model.Id] * model.CostAtTime;
        }

        return sum;
    }

    public List<StockModel> Models {
        set {
            _newQuantities = value.ToDictionary(x => x.Id, x => x.Quantity);
            LoadData(value);
        }
    }

    private Dictionary<int, int> _newQuantities = [];
    public Dictionary<int, int> NewQuantities {
        get => _newQuantities;
    }

    public bool ReadOnly {
        get => !_view.Editable;
        set => _view.Editable = !value;
    }

    private void LoadDetails(StockModel model) {
        _view.StockName = model.Name;
        _view.StockDescription = model.Description;
        _view.Quantity = _newQuantities[model.Id];
        _view.Subtotal = _newQuantities[model.Id] * model.CostAtTime;
        _view.Total = CalculateTotal();
    }

    private void LoadData(List<StockModel> options) {
        _view.DataGridText = "Loading...";
        _view.DisableAll();

        try {
            _isAsyncRunning = true;

            _models = options;

            DisplayItems();

            _view.DataGridText = "";
            _view.EnableAll();
        }
        catch {
            _displayModels.Clear();
            _view.DataGridText = "Error getting jobs from the database";
        }
        finally {
            _isAsyncRunning = false;
        }
    }

    protected override DisplayStockModel CreateDisplayItem(StockModel model) => new(model);
    protected override List<StockModel> OrderDefault(List<StockModel> models) => [.. models.OrderBy(x => x.Id)];
    protected override IComparable RankSearch(string searchText, StockModel model) => GeneralHelpers.SubstringLevenshteinDistance(searchText, model.Name);

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
    }
}
