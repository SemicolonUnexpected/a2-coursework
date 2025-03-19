using a2_coursework._Helpers;
using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.CleaningJob;
using a2_coursework.Model.CleaningJob;
using a2_coursework.Model.Staff;
using a2_coursework.View;
using a2_coursework.View.CleaningJob;

namespace a2_coursework.Presenter.CleaningJob;
public class DisplayUpcomingCleaningJobPresenter : DisplayPresenter<IDisplayUpcomingCleaningJobView, CleaningJobModel, DisplayCleaningJobModel>, IChildPresenter, INavigatingPresenter {
    private readonly StaffModel _staff;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public DisplayUpcomingCleaningJobPresenter(IDisplayUpcomingCleaningJobView view, StaffModel staff) : base(view) {
        _staff = staff;

        LoadData();

        _view.View += OnView;
        _view.Search += OnSearch;
        _view.SortRequested += OnSortRequested;
    }

    private void OnView(object? sender, EventArgs e) => View();
    private void OnSearch(object? sender, EventArgs e) => Search(_view.SearchText);
    private void OnSortRequested(object? sender, SortRequestEventArgs e) => SortByColumn(e.ColumnName, e.SortAscending);

    protected override void DisplayItems() {
        _displayModels.Clear();
        _modelDisplayMap.Clear();

        foreach (CleaningJobModel stockItem in _models) {
            DisplayCleaningJobModel displayStockItem = CreateDisplayItem(stockItem);
            _modelDisplayMap.Add(displayStockItem, stockItem);
            _displayModels.Add(displayStockItem);
        }

        _view.DisplayItems(_displayModels);
    }

    protected override DisplayCleaningJobModel CreateDisplayItem(CleaningJobModel stockItem) => new DisplayCleaningJobModel(stockItem);

    public async void LoadData() {
        _view.DataGridText = "Loading...";
        _view.DisableAll();

        try {
            _isAsyncRunning = true;

            _models = await CleaningJobDAL.GetUpcomingCleaningJobs();

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

    protected override IComparable RankSearch(string searchText, CleaningJobModel model) => MathF.Min((float)GeneralHelpers.LevensteinDistance(searchText, model.Address.ToLower()) / model.Address.Length, (float)(MathF.Pow(GeneralHelpers.LevensteinDistance(_view.SearchText.ToLower(), model.StartDate.ToString().ToLower()), 2) + 1) / MathF.Pow(model.StartDate.ToString().Length, 2));
    protected override List<CleaningJobModel> OrderDefault(List<CleaningJobModel> models) => [.. models.OrderBy(model => model.Id)];

    private void View() {
        if (_view.SelectedItem is null) return;

        (IChildView view, IChildPresenter presenter) = CleaningJobFactory.CreateViewCleaningJob(_modelDisplayMap[_view.SelectedItem], _staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void SortByColumn(string columnName, bool sortAscending) {
        if (_isAsyncRunning) return;

        switch (columnName) {
            case "columnId":
                SortBy(x => x.Id, sortAscending);
                break;
            case "columnAddress":
                SortBy(x => x.Address, sortAscending);
                break;
            case "columnTimes":
                SortBy(x => $"{x.StartDate} - {x.EndDate}", sortAscending);
                break;

            default:
                throw new NotImplementedException("Invalid column name");
        }

        DisplayItems();
    }

    public override void CleanUp() {
        _view.View -= OnView;
        _view.Search -= OnSearch;
        _view.SortRequested -= OnSortRequested;

        base.CleanUp();
    }
}
