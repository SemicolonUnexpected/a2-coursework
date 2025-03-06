using a2_coursework._Helpers;
using a2_coursework.Interfaces;
using a2_coursework.Model.CleaningJobOption;

namespace a2_coursework.Presenter.CleaningJob;
public class ManageCleaningJobOptionsPresenter : DisplayPresenter<IManageCleaningJobOptionsView, CleaningJobOptionModel, DisplayCleaningJobOptionModel>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public ManageCleaningJobOptionsPresenter(IManageCleaningJobOptionsView view) : base(view) {
        _view.SelectionChanged += OnSelectedItemChanged;
        _view.QuantityChanged += OnQuantityChanged;
    }

    private void OnSelectedItemChanged(object? sender, EventArgs e) {
        if (_view.SelectedItem is not null) LoadDetails(_modelDisplayMap[_view.SelectedItem]);
        else {
            _view.Editable = false;
            _view.CleaningOptionName = "";
            _view.CleaningOptionDescription = "";
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

        CleaningJobOptionModel model = _modelDisplayMap[_view.SelectedItem!];
        model.Quantity = _view.Quantity;
        _view.Subtotal = model.Quantity * model.CostAtTime;
        _view.Total = CalculateTotal();
    }

    private decimal CalculateTotal() {
        decimal sum = 0;

        foreach (var model in _models) {
            sum += model.Quantity * model.UnitCost;
        }

        return sum;
    }

    public List<CleaningJobOptionModel> Models {
        set => LoadData(value);
        get => _models;
    }

    private void LoadDetails(CleaningJobOptionModel model) {
        _view.Editable = true;
        _view.CleaningOptionName = model.Name;
        _view.CleaningOptionDescription = model.Description;
        _view.Quantity = model.Quantity;
        _view.Subtotal = model.Quantity * model.CostAtTime;
        _view.Total = CalculateTotal();
    }

    private void LoadData(List<CleaningJobOptionModel> options) {
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

    protected override DisplayCleaningJobOptionModel CreateDisplayItem(CleaningJobOptionModel model) => new(model);
    protected override List<CleaningJobOptionModel> OrderDefault(List<CleaningJobOptionModel> models) => [.. models.OrderBy(x => x.Id)];
    protected override IComparable RankSearch(string searchText, CleaningJobOptionModel model) => GeneralHelpers.LevensteinDistance(searchText, model.Name);

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
