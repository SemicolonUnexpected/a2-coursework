using a2_coursework._Helpers;
using a2_coursework.Interfaces.CleaningJob;
using a2_coursework.Model.Staff;
using a2_coursework.View;
using a2_coursework.View.StaffView.StaffManagement;

namespace a2_coursework.Presenter.CleaningJob;

public class SelectCleaningJobStaffPresenter : DisplayPresenter<ISelectCleaningJobStaffView, StaffModel, DisplayStaffModel>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public SelectCleaningJobStaffPresenter (ISelectCleaningJobStaffView view, Task<List<StaffModel>> getStaff) : base(view) {
        LoadData(getStaff);

        _view.SelectionChanged += OnSelectionChanged;
        _view.SortRequested += OnSortRequested;
    }

    private void OnSelectionChanged(object? sender, EventArgs e) => DetailsChanged?.Invoke(this, EventArgs.Empty);
    private void OnSortRequested(object? sender, SortRequestEventArgs e) => SortByColumn(e.ColumnName, e.SortAscending);

    private async void LoadData(Task<List<StaffModel>> getStaff) {
        _view.DataGridText = "Loading...";
        _view.DisableAll();

        try {
            _isAsyncRunning = true;

            _models = await getStaff;

            DisplayItems();
            _view.SetSelectedItemsById(_setSelectedItems);

            _view.DataGridText = "";
            _view.EnableAll();
        }
        catch {
            _displayModels.Clear();
            _view.DataGridText = "Error getting staff from the database";
        }
        finally {
            _isAsyncRunning = false;
        }
    }
    protected override DisplayStaffModel CreateDisplayItem(StaffModel model) => new(model);

    protected override List<StaffModel> OrderDefault(List<StaffModel> models) => [.. models.OrderBy(x => x.Id)];

    protected override IComparable RankSearch(string searchText, StaffModel model) => GeneralHelpers.LevensteinDistance(searchText, $"{model.Forename} {model.Surname}");

    private List<int> _setSelectedItems = [];
    public List<int> SelectedStaffIds {
        get => _view.SelectedItems.ConvertAll(x => x.Id);
        set {
            _setSelectedItems = value;
            _view.SetSelectedItemsById(value);
        }
    }

    public bool ReadOnly {
        get => _view.ReadOnly;
        set => _view.ReadOnly = value;
    }

    protected override void SortByColumn(string columnName, bool sortAscending) {
        switch (columnName) {
            case "columnId":
                SortBy(x => x.Id, sortAscending);
                break;
            case "columnName":
                SortBy(x => $"{x.Forename} {x.Surname}", sortAscending);
                break;
            case "columnEmail":
                SortBy(x => x.Email, sortAscending);
                break;
            case "columnPhoneNumber":
                SortBy(x => x.PhoneNumber, sortAscending);
                break;

            default:
                throw new NotImplementedException();
        }

        DisplayItems();
        _view.SetSelectedItemsById(_setSelectedItems);
    }
}
