using a2_coursework._Helpers;
using a2_coursework.Interfaces.Staff;
using a2_coursework.Model.Staff;
using a2_coursework.View;
using a2_coursework.View.StaffView.StaffManagement;

namespace a2_coursework.Presenter.StaffPresenters.ManageStaff;

public class DisplayStaffPresenter : DisplayPresenter<IDisplayStaffView, StaffModel, DisplayStaff>, IChildPresenter, INavigatingPresenter {
    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public DisplayStaffPresenter(IDisplayStaffView view) : base(view) {
        LoadData();

        _view.Add += OnAdd;
        _view.Edit += OnEdit;
        _view.ArchiveToggled += OnArchiveToggled;
        _view.ShowArchivedChanged += OnShowArchivedChanged;
        _view.Search += OnSearch;
        _view.SelectionChanged += OnSelectionChanged;
        _view.SortRequested += OnSortRequested;
    }

    private void OnAdd(object? sender, EventArgs e) => Add();
    private void OnEdit(object? sender, EventArgs e) => Edit();
    private void OnShowArchivedChanged(object? sender, EventArgs e) {
        _view.DisableAll();
        DisplayItems();
        _view.EnableAll();
    }
    private void OnArchiveToggled(object? sender, EventArgs e) => ToggleArchived();
    private void OnSearch(object? sender, EventArgs e) => Search(_view.SearchText);
    private void OnSelectionChanged(object? sender, EventArgs e) => SelectionChanged();
    private void OnSortRequested(object? sender, SortRequestEventArgs e) => SortByColumn(e.ColumnName, e.SortAscending);

    protected override void DisplayItems() {
        _displayModels.Clear();
        _modelDisplayMap.Clear();

        IEnumerable<StaffModel> models;
        if (!_view.ShowArchivedItems) models = FilterOutArchived(_models);
        else models = _models;

        foreach (StaffModel staff in models) {
            DisplayStaff displayStaff = CreateDisplayItem(staff);
            _modelDisplayMap.Add(displayStaff, staff);
            _displayModels.Add(displayStaff);
        }

        _view.DisplayItems(_displayModels);
    }

    protected override DisplayStaff CreateDisplayItem(StaffModel staff) => new DisplayStaff(staff);

    public async void LoadData() {
        _view.DataGridText = "Loading...";
        _view.DisableAll();

        try {
            _isAsyncRunning = true;

            _models = await StaffDAL.GetStaff();

            DisplayItems();

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

    private IEnumerable<StaffModel> FilterOutArchived(IEnumerable<StaffModel> staffItems) => staffItems.Where(x => !x.Archived);

    protected override IComparable RankSearch(string searchText, StaffModel staff) {
        string staffNames = $"{staff.Forename} {staff.Surname}";

        return MathF.Min(
            (float)GeneralHelpers.LevensteinDistance(searchText, staffNames.ToLower()) / staffNames.Length,
            (float)GeneralHelpers.LevensteinDistance(searchText, staff.Username.ToLower()) / staff.Username.Length
        );
    }

    protected override List<StaffModel> OrderDefault(List<StaffModel> models) => models.OrderBy(model => model.Id).ToList();

    private async void ToggleArchived() {
        if (_isAsyncRunning) return;

        if (_view.SelectedItem is null) {
            _view.SelectedItemArchived = false;
            return;
        }

        _view.DisableAll();

        StaffModel staff = _modelDisplayMap[_view.SelectedItem];

        try {
            _isAsyncRunning = true;

            bool success = await StaffDAL.UpdateArchived(staff.Id, !staff.Archived);

            if (success) {
                staff.Archived = !staff.Archived;
                _view.SelectedItem.Archived = staff.Archived;
                if (!_view.ShowArchivedItems && _view.SelectedItem.Archived) _displayModels.Remove(_view.SelectedItem);
            }
        }
        catch { }
        finally {
            _view.EnableAll();
            _isAsyncRunning = false;
        }
    }

    private void SelectionChanged() {
        if (_view.SelectedItem is null) return;
        _view.SelectedItemArchived = _modelDisplayMap[_view.SelectedItem].Archived;
    }

    private void Edit() {
        if (_view.SelectedItem is null) return;

        _cancellationTokenSource.Cancel();

        //(IChildView view, IChildPresenter presenter) = ViewFactory.CreateEditStaff(_modelDisplayMap[_view.SelectedItem]);
        //NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    private void Add() {
        //(IChildView view, IChildPresenter presenter) = ViewFactory.CreateAddStaff();
        //NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void SortByColumn(string columnName, bool sortAscending) {
        if (_isAsyncRunning) return;

        switch (columnName) {
            case "columnID":
                SortBy(x => x.Id, sortAscending);
                break;
            case "columnUsername":
                SortBy(x => x.Username, sortAscending);
                break;
            case "columnNames":
                SortBy(x => $"{x.Forename} {x.Surname}", sortAscending);
                break;
            case "columnPhoneNumber":
                SortBy(x => x.PhoneNumber, sortAscending);
                break;
            case "columnEmail":
                SortBy(x => x.Email, sortAscending);
                break;
            case "columnArchived":
                SortBy(x => x.Archived, sortAscending);
                break;

            default:
                throw new NotImplementedException("Invalid column name");
        }

        DisplayItems();
    }

    public override void CleanUp() {
        _view.Add -= OnAdd;
        _view.Edit -= OnEdit;
        _view.ArchiveToggled -= OnArchiveToggled;
        _view.ShowArchivedChanged -= OnShowArchivedChanged;
        _view.Search -= OnSearch;
        _view.SelectionChanged -= OnSelectionChanged;
        _view.SortRequested -= OnSortRequested;

        base.CleanUp();
    }
}
