using a2_coursework._Helpers;
using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Customer;
using a2_coursework.Model.Customer;
using a2_coursework.View;
using a2_coursework.View.CleaningJob;

namespace a2_coursework.Presenter.Customer;
public class DisplayCustomerPresenter : DisplayPresenter<IDisplayCustomerView, CustomerModel, DisplayCustomerModel>, IChildPresenter, INavigatingPresenter {
    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public DisplayCustomerPresenter(IDisplayCustomerView view) : base(view) {
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

        IEnumerable<CustomerModel> models;
        if (!_view.ShowArchivedItems) models = FilterOutArchived(_models);
        else models = _models;

        foreach (CustomerModel customerModel in models) {
            DisplayCustomerModel displayCustomerModel = CreateDisplayItem(customerModel);
            _modelDisplayMap.Add(displayCustomerModel, customerModel);
            _displayModels.Add(displayCustomerModel);
        }

        _view.DisplayItems(_displayModels);
    }

    protected override DisplayCustomerModel CreateDisplayItem(CustomerModel stockItem) => new DisplayCustomerModel(stockItem);

    public async void LoadData() {
        _view.DataGridText = "Loading...";
        _view.DisableAll();

        try {
            _isAsyncRunning = true;

            _models = await CustomerDAL.GetCustomers();

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

    private IEnumerable<CustomerModel> FilterOutArchived(IEnumerable<CustomerModel> models) => models.Where(x => !x.Archived);

    protected override IComparable RankSearch(string searchText, CustomerModel model) {
        string name = $"{model.Forename} {model.Surname}";

        return MathF.Min((float)GeneralHelpers.LevensteinDistance(searchText,name.ToLower()) / name.Length, (float)(MathF.Pow(GeneralHelpers.LevensteinDistance(_view.SearchText.ToLower(), model.Email.ToLower()), 2) + 1) / MathF.Pow(model.Email.Length, 2));
    }
    protected override List<CustomerModel> OrderDefault(List<CustomerModel> models) => models.OrderBy(model => model.Id).ToList();

    private void SelectionChanged() {
        if (_view.SelectedItem is null) return;
        _view.SelectedItemArchived = _modelDisplayMap[_view.SelectedItem].Archived;
    }

    private async void ToggleArchived() {
        if (_isAsyncRunning) return;

        if (_view.SelectedItem is null) {
            _view.SelectedItemArchived = false;
            return;
        }

        _view.DisableAll();

        CustomerModel model = _modelDisplayMap[_view.SelectedItem];

        try {
            _isAsyncRunning = true;

            if (await CustomerDAL.CustomerInFutureJob(model.Id)) {
                _view.ShowMessageBox("The customer is used in a future job so cannot be archived.", "Cannot archive customer");
                return;
            }

            bool success = await CustomerDAL.UpdateCustomerArchived(model.Id, model.Archived);

            if (success) {
                model.Archived = !model.Archived;
                _view.SelectedItem.Archived = model.Archived;
                if (!_view.ShowArchivedItems && _view.SelectedItem.Archived) _displayModels.Remove(_view.SelectedItem);
            }
        }
        catch { }
        finally {
            _view.EnableAll();
            _isAsyncRunning = false;
        }
    }

    private void Edit() {
        if (_view.SelectedItem is null) return;

        _cancellationTokenSource.Cancel();

        (IChildView view, IChildPresenter presenter) = CustomerFactory.CreateEditCustomer(_modelDisplayMap[_view.SelectedItem]);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    private void Add() {
        if (_view.SelectedItem is null) return;

        _cancellationTokenSource.Cancel();

        (IChildView view, IChildPresenter presenter) = CustomerFactory.CreateAddCustomer();
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void SortByColumn(string columnName, bool sortAscending) {
        if (_isAsyncRunning) return;

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
