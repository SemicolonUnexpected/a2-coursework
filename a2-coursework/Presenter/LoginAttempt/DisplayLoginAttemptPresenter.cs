using a2_coursework._Helpers;
using a2_coursework.Interfaces.LoginAttempt;
using a2_coursework.Model.LoginAttempt;
using a2_coursework.View;
using a2_coursework.View.LoginAttempt;

namespace a2_coursework.Presenter.Customer;
public class DisplayLoginAttemptPresenter : DisplayPresenter<IDisplayLoginAttemptView, LoginAttemptModel, DisplayLoginAttemptModel>, IChildPresenter, INavigatingPresenter {
    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public DisplayLoginAttemptPresenter (IDisplayLoginAttemptView view) : base(view) {
        LoadData();

        _view.Search += OnSearch;
        _view.SortRequested += OnSortRequested;
    }

    private void OnSearch(object? sender, EventArgs e) => Search(_view.SearchText);
    private void OnSortRequested(object? sender, SortRequestEventArgs e) => SortByColumn(e.ColumnName, e.SortAscending);

    protected override void DisplayItems() {
        _displayModels.Clear();
        _modelDisplayMap.Clear();

        foreach (LoginAttemptModel model in _models) {
            DisplayLoginAttemptModel displayModel = CreateDisplayItem(model);
            _modelDisplayMap.Add(displayModel, model);
            _displayModels.Add(displayModel);
        }

        _view.DisplayItems(_displayModels);
    }

    protected override  DisplayLoginAttemptModel CreateDisplayItem(LoginAttemptModel model) => new DisplayLoginAttemptModel(model);

    public async void LoadData() {
        _view.DataGridText = "Loading...";
        _view.DisableAll();

        try {
            _isAsyncRunning = true;

            _models = await LoginAttemptDAL.GetLoginAttempts();

            _models = OrderDefault(_models);

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

    protected override IComparable RankSearch(string searchText, LoginAttemptModel model) => MathF.Min((float)GeneralHelpers.LevensteinDistance(searchText, model.Username.ToLower()) / model.Username.Length, (float)(MathF.Pow(GeneralHelpers.LevensteinDistance(_view.SearchText.ToLower(), model.AttemptTime.ToString()), 2) + 1) / MathF.Pow(model.AttemptTime.ToString().Length, 2));
    protected override List<LoginAttemptModel> OrderDefault(List<LoginAttemptModel> models) => models.OrderByDescending(model => model.AttemptTime).ToList();

    protected override void SortByColumn(string columnName, bool sortAscending) {
        if (_isAsyncRunning) return;

        switch (columnName) {
            case "columnUsername":
                SortBy(x => x.Username, sortAscending);
                break;
            case "columnAttemptTime":
                SortBy(x => x.AttemptTime, !sortAscending);
                break;
            case "columnSuccessful":
                SortBy(x => x.Successful, sortAscending);
                break;

            default:
                throw new NotImplementedException("Invalid column name");
        }

        DisplayItems();
    }

    public override void CleanUp() {
        _view.Search -= OnSearch;
        _view.SortRequested -= OnSortRequested;

        base.CleanUp();
    }
}
