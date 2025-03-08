using a2_coursework._Helpers;
using a2_coursework.Model.Customer;
using a2_coursework.View;
using a2_coursework.View.CleaningJob;

namespace a2_coursework.Presenter.CleaningJob;

public class SelectCleaningJobCustomerPresenter : DisplayPresenter<ISelectCleaningJobCustomerView, CustomerModel, DisplayCustomerModel>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public SelectCleaningJobCustomerPresenter(ISelectCleaningJobCustomerView view) : base(view) {
        LoadData();

        _view.SelectionChanged += OnSelectionChanged;
        _view.SortRequested += OnSortRequested;
    }

    private void OnSortRequested(object? sender, SortRequestEventArgs e) => SortByColumn(e.ColumnName, e.SortAscending);

    private void OnSelectionChanged(object? sender, EventArgs e) {
        SetCustomerName();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    private async void LoadData() {
        _view.DataGridText = "Loading...";
        _view.DisableAll();

        try {
            _isAsyncRunning = true;

            _models = await CustomerDAL.GetNonArchivedCustomers();

            DisplayItems();
            _view.SetSelectedItemId(_setSelectedId);

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

    protected override DisplayCustomerModel CreateDisplayItem(CustomerModel model) => new(model);

    protected override List<CustomerModel> OrderDefault(List<CustomerModel> models) => [.. models.OrderBy(x => x.Id)];

    protected override IComparable RankSearch(string searchText, CustomerModel model) => GeneralHelpers.LevensteinDistance(searchText, $"{model.Forename} {model.Surname}");

    private int? _setSelectedId;
    public int? SelectedId {
        get {
            if (_view.SelectedItem is null) return null;
            else return _modelDisplayMap[_view.SelectedItem].Id;
        }
        set {
            _setSelectedId = value;
            _view.SetSelectedItemId(_setSelectedId);
        }
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
        _view.SetSelectedItemId(_setSelectedId);
    }

    private void SetCustomerName() => _view.SelectedCustomerName = _view.SelectedItem is null ? "" : $"{_modelDisplayMap[_view.SelectedItem].Forename} {_modelDisplayMap[_view.SelectedItem].Surname}";
}
