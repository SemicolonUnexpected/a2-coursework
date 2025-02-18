using a2_coursework.Interfaces;
using System.ComponentModel;

namespace a2_coursework.Presenter;
public abstract class DisplayPresenter<TView, TModel, TDisplayModel> : BasePresenter<TView>, IChildPresenter
    where TView : notnull, IView, IDisplayView<TDisplayModel>
    where TDisplayModel : notnull, INotifyPropertyChanged {
    protected List<TModel> _models = [];
    protected BindingList<TDisplayModel> _displayModels = [];
    protected Dictionary<TDisplayModel, TModel> _modelDisplayMap = [];

    protected bool _isAsyncRunning;

    protected CancellationTokenSource _cancellationTokenSource = new();

    protected DisplayPresenter(TView view) : base(view) { }

    protected abstract void DisplayItems();

    protected abstract TDisplayModel CreateDisplayItem(TModel model);

    protected async void Search(string searchText) {
        if (_isAsyncRunning) return;

        _displayModels.Clear();

        _cancellationTokenSource.Cancel();
        _cancellationTokenSource = new CancellationTokenSource();
        CancellationToken token = _cancellationTokenSource.Token;

        try {
            _models = await Task.Run(() => {
                List<TModel> models = _models.ToList();
                searchText = searchText.ToLower();

                if (string.IsNullOrWhiteSpace(searchText)) {
                    models = OrderDefault(models);
                }
                else {
                    models = [.. models.OrderBy(stockItem => {
                        token.ThrowIfCancellationRequested();
                        return RankSearch(searchText, stockItem);
                    })];
                }

                token.ThrowIfCancellationRequested();
                return models;
            }, token);

            DisplayItems();
        }
        catch (OperationCanceledException) { }
    }

    protected abstract IComparable RankSearch(string searchText, TModel model);
    protected abstract List<TModel> OrderDefault(List<TModel> models);

    protected void SortBy<T>(Func<TModel, T> property, bool sortAscending) where T : IComparable {
        if (sortAscending) _models.Sort((a, b) => property(a).CompareTo(property(b)));
        else _models.Sort((a, b) => property(b).CompareTo(property(a)));
    }

    public bool CanExit() {
        _cancellationTokenSource.Cancel();
        return !_isAsyncRunning;
    }

    public override void CleanUp() {
        _cancellationTokenSource.Cancel();
        _cancellationTokenSource.Dispose();

        base.CleanUp();
    }

    protected abstract void SortByColumn(string columnName, bool sortAscending);
}
