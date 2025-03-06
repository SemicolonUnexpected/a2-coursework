using a2_coursework._Helpers;
using a2_coursework.Interfaces.CleaningJob;
using a2_coursework.Model.CleaningJobOption;
using a2_coursework.View;

namespace a2_coursework.Presenter.CleaningJob;

public class SelectCleaningJobOptionsPresenter : DisplayPresenter<ISelectCleaningJobOptionsView, CleaningJobOptionModel, DisplayCleaningJobOptionModel>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public SelectCleaningJobOptionsPresenter(ISelectCleaningJobOptionsView view, Task<List<CleaningJobOptionModel>> getCleaningJobOptions) : base(view) {
        LoadData(getCleaningJobOptions);

        _view.SelectionChanged += OnSelectionChanged;
        _view.SortRequested += OnSortRequested;
    }

    private void OnSelectionChanged(object? sender, EventArgs e) => DetailsChanged?.Invoke(this, EventArgs.Empty);
    private void OnSortRequested(object? sender, SortRequestEventArgs e) => SortByColumn(e.ColumnName, e.SortAscending);

    private async void LoadData(Task<List<CleaningJobOptionModel>> getCleaningJobOptions) {
        _view.DataGridText = "Loading...";
        _view.DisableAll();

        try {
            _isAsyncRunning = true;

            _models = await getCleaningJobOptions;

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
    protected override DisplayCleaningJobOptionModel CreateDisplayItem(CleaningJobOptionModel model) => new(model);

    protected override List<CleaningJobOptionModel> OrderDefault(List<CleaningJobOptionModel> models) => [.. models.OrderBy(x => x.Id)];

    protected override IComparable RankSearch(string searchText, CleaningJobOptionModel model) => GeneralHelpers.LevensteinDistance(searchText, model.Name);

    private List<int> _setSelectedItems = [];
    public List<CleaningJobOptionModel> SelectedCleaningJobOptions {
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
