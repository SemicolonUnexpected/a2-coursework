using a2_coursework._Helpers;
using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.CleaningJob;
using a2_coursework.Model.CleaningJob;
using a2_coursework.Model.Staff;
using a2_coursework.View.CleaningJob;

namespace a2_coursework.Presenter.CleaningJob;
public class BookCleaningJobPresenter : DisplayPresenter<IBookCleaningJobView, CleaningJobModel, DisplayCleaningJobModel>, INavigatingPresenter {
    private readonly StaffModel _staff;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public BookCleaningJobPresenter(IBookCleaningJobView view, StaffModel staff) : base(view) {
        _staff = staff;

        _view.DateChanged += OnDateChanged;
        _view.Add += OnAdd;
        _view.Edit += OnEdit;
        _view.View += OnView;
        _view.Delete += OnDelete;

        _view.Date = DateTime.Today;
    }

    public void OnDateChanged(object? sender, EventArgs e) {
        SetAddEditDeleteView();
        LoadData();
        DisplayItems();
    }
    public void OnAdd(object? sender, EventArgs e) => Add();
    public void OnEdit(object? sender, EventArgs e) => Edit();
    public void OnView(object? sender, EventArgs e) => View();
    public void OnDelete(object? sender, EventArgs e) => Delete();

    protected override void DisplayItems() {
        _displayModels.Clear();
        _modelDisplayMap.Clear();

        foreach (CleaningJobModel model in _models) {
            DisplayCleaningJobModel displayModel = CreateDisplayItem(model);
            _modelDisplayMap.Add(displayModel, model);
            _displayModels.Add(displayModel);
        }

        _view.DisplayItems(_displayModels);
    }

    protected override DisplayCleaningJobModel CreateDisplayItem(CleaningJobModel model) => new(model);

    protected override IComparable RankSearch(string searchText, CleaningJobModel model) => GeneralHelpers.LevensteinDistance(searchText, model.StartDate.ToString("HH mm") + " - " + model.EndDate.ToString("HH mm"));

    protected override List<CleaningJobModel> OrderDefault(List<CleaningJobModel> models) => [.. models.OrderBy(x => x.Id)];

    protected override void SortByColumn(string columnName, bool sortAscending) {
        switch (columnName) {
            case "columnId":
                SortBy(x => x.Id, sortAscending);
                break;
            case "columnAddress":
                SortBy(x => x.Address, sortAscending);
                break;
            case "columnTime":
                SortBy(x => x.StartDate, !sortAscending);
                break;

            default:
                throw new NotImplementedException("Invalid column name");
        }
    }

    public async void LoadData() {
        _view.DataGridText = "Loading...";
        _view.DisableAll();

        try {
            _isAsyncRunning = true;

            _models = await CleaningJobDAL.GetCleaningJobsByDate(_view.Date);

            DisplayItems();

            _view.DataGridText = "";
            _view.EnableAll();
        }
        catch (Exception e) {
            _displayModels.Clear();
            _view.DataGridText = "Error getting stock from the database";
        }
        finally {
            _isAsyncRunning = false;
        }
    }

    private void Edit() {
        if (_view.SelectedItem is null) return;

        _cancellationTokenSource.Cancel();

        (IChildView view, IChildPresenter presenter) = CleaningJobFactory.CreateEditCleaningJob(_modelDisplayMap[_view.SelectedItem], _staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    private void View() {
        if (_view.SelectedItem is null) return;

        _cancellationTokenSource.Cancel();

        (IChildView view, IChildPresenter presenter) = CleaningJobFactory.CreateViewCleaningJob(_modelDisplayMap[_view.SelectedItem], _staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    private void Add() {
        _cancellationTokenSource.Cancel();

        (IChildView view, IChildPresenter presenter) = CleaningJobOptionFactory.CreateAddCleaningJob(_view.Date, _staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    private async void Delete() {
        if (_view.SelectedItem is null) return;

        _cancellationTokenSource.Cancel();

        if (_view.ShowMessageBox("Are you sure you want to permanently delete this cleaning job?", "Confirm deletion", MessageBoxButtons.OKCancel) == DialogResult.OK) {
            try {
                bool success = await CleaningJobDAL.DeleteCleaningJob(_modelDisplayMap[_view.SelectedItem].Id);

                if (success) {
                    _displayModels.Remove(_view.SelectedItem);
                }
                else _view.ShowMessageBox("Error deleting job", "Error");
            }
            catch {
                _view.ShowMessageBox("Error deleting job", "Error");
            }
        }
    }

    private void SetAddEditDeleteView() {
        bool beforeToday = _view.Date <= DateTime.Today;
        _view.AddEnabled = !beforeToday;
        _view.DeleteEnabled = !beforeToday;
        _view.ViewMode = beforeToday;
    }
}
