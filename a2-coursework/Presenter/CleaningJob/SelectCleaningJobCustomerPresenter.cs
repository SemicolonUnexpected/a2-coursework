using a2_coursework._Helpers;
using a2_coursework.Model.Customer;
using a2_coursework.View.CleaningJob;

namespace a2_coursework.Presenter.CleaningJob;

public class SelectCleaningJobCustomerPresenter : DisplayPresenter<ISelectCleaningJobCustomerView, CustomerModel, DisplayCustomerModel>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public SelectCleaningJobCustomerPresenter(ISelectCleaningJobCustomerView view) : base(view) {
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

            _models = await CustomerDAL.GetNonArchivedCustomers();

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
    protected override DisplayCustomerModel CreateDisplayItem(CustomerModel model) => new(model);

    protected override List<CustomerModel> OrderDefault(List<CustomerModel> models) => [.. models.OrderBy(x => x.Id)];

    protected override IComparable RankSearch(string searchText, CustomerModel model) => GeneralHelpers.LevensteinDistance(searchText, $"{model.Forename} {model.Surname}");

    public int SelectedId {
        get => _modelDisplayMap[_view.SelectedItem].Id;
        set => _view.SetSelectedItemId(value);
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
    }
}
