using a2_coursework._Helpers;
using a2_coursework.Interfaces.CleaningJob;
using a2_coursework.Model.CleaningJobOption;

namespace a2_coursework.Presenter.CleaningJob;

public class SelectCleaningJobOptionsPresenter : DisplayPresenter<ISelectCleaningJobOptionsView, CleaningJobOptionModel, DisplayCleaningJobOptionModel>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public SelectCleaningJobOptionsPresenter(ISelectCleaningJobOptionsView view) : base(view) {
        LoadData();

        _view.SelectionChanged += OnSelectionChanged;
    }

    private void OnSelectionChanged(object? sender, EventArgs e) {
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    private async void LoadData() {
        _view.DataGridText = "Loading...";
        _view.DisableAll();

        try {
            _isAsyncRunning = true;

            _models = await CleaningJobOptionDAL.GetNonArchivedCleaningJobOptions();

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
    protected override DisplayCleaningJobOptionModel CreateDisplayItem(CleaningJobOptionModel model) => new(model);

    protected override List<CleaningJobOptionModel> OrderDefault(List<CleaningJobOptionModel> models) => [.. models.OrderBy(x => x.Id)];

    protected override IComparable RankSearch(string searchText, CleaningJobOptionModel model) => GeneralHelpers.LevensteinDistance(searchText, model.Name);

    public List<int> SelectedItems {
        get => _view.SelectedItems.ConvertAll(x => x.Id);
        set => _view.SetSelectedItemsById(value);
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
    }
}
