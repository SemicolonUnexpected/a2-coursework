
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Staff.Settings;

namespace a2_coursework.Presenter;
public abstract class ParentEditPresenter<TView, TModel> : EditPresenter<TView, TModel> where TView : IEditView {
    protected Action? PopulateDefaultValuesCurrent;
    protected Func<Task<bool>>? UpdateDatabaseCurrent;
    protected Func<bool>? ValidateInputsCurrent;
    protected Func<bool>? AnyChangesCurrent;
    protected Action? UpdateModelCurrent;

    protected ParentEditPresenter(TView view, TModel model) : base(view, model) { }

    protected override bool AnyChanges() => AnyChangesCurrent?.Invoke() ?? false;

    protected override void PopulateDefaultValues() => PopulateDefaultValuesCurrent?.Invoke();

    protected override Task<bool> UpdateDatabase() => UpdateDatabaseCurrent?.Invoke() ?? Task.FromResult(true);

    protected override void UpdateModel() => UpdateModelCurrent?.Invoke();

    protected override bool ValidateInputs() => ValidateInputsCurrent?.Invoke() ?? true;

    protected void Navigate((IChildView view, INotifyingChildPresenter presenter) pair) {
        Navigate(pair.view, pair.presenter);
    }

    protected abstract void Navigate(IChildView view, INotifyingChildPresenter presenter);
}
