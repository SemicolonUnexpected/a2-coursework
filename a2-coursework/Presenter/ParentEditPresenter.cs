
using a2_coursework.Interfaces;
using a2_coursework.UserControls;

namespace a2_coursework.Presenter;
public abstract class ParentEditPresenter<TView, TModel> : EditPresenter<TView, TModel> where TView : IEditView {
    protected Action? PopulateDefaultValuesCurrent;
    protected Func<Task<bool>>? UpdateDatabaseCurrent;
    protected Func<bool>? ValidateCurrent;
    protected Func<bool>? AnyChangesCurrent;
    protected Action? UpdateModelCurrent;

    protected INotifyingChildPresenter? _childPresenter;

    protected ParentEditPresenter(TView view, TModel model) : base(view, model) {
        _view.SelectedMenuItemChanged += OnSelectedMenuItemChanged;
        _view.PreviewSelectedMenuItemChanged += OnPreviewSelectedMenuItemChanged;
    }

    private void OnDetailsChanged(object? sender, EventArgs e) => SetApproveChangesBarVisibility();
    private void OnSelectedMenuItemChanged(object? sender, string selectedItem) => Navigate(GetView(selectedItem));
    private void OnPreviewSelectedMenuItemChanged(object? sender, ToggleEventArgs e) => e.Handled = !CanNavigate();

    #region Delegate based validation

    protected override bool AnyChanges() => AnyChangesCurrent?.Invoke() ?? false;
    protected override void PopulateDefaultValues() => PopulateDefaultValuesCurrent?.Invoke();
    protected override Task<bool> UpdateDatabase() => UpdateDatabaseCurrent?.Invoke() ?? Task.FromResult(true);
    protected override void UpdateModel() => UpdateModelCurrent?.Invoke();
    protected override bool Validate() => ValidateCurrent?.Invoke() ?? true;

    #endregion

    protected abstract void BindValidation();
    protected abstract void UnBindValidation();

    private bool CanNavigate() {
        if (_view.IsLoading) return false;

        if (AnyChanges()) {
            DialogResult result = _view.ShowMessageBox("All your changes will be lost. Click OK if you want to continue", "Are you sure you want to leave?", MessageBoxButtons.OKCancel);

            return result == DialogResult.OK;
        }

        return true;
    }

    protected abstract (IChildView childView, INotifyingChildPresenter childPresenter) GetView(string selectedItem);

    protected virtual void Navigate(IChildView view, INotifyingChildPresenter presenter) {
        presenter.DetailsChanged += OnDetailsChanged;

        _view.DisplayChildView(view);

        if (_childPresenter is not null) {
            _childPresenter.DetailsChanged -= OnDetailsChanged;
            UnBindValidation();
            _childPresenter.CleanUp();
        }

        _childPresenter = presenter;

        BindValidation();
        PopulateDefaultValues();
        SetApproveChangesBarVisibility();
    }

    protected void Navigate((IChildView childView, INotifyingChildPresenter childPresenter) pair) => Navigate(pair.childView, pair.childPresenter);

    public override bool CanExit() => CanNavigate();

    public override void CleanUp() {
        _view.SelectedMenuItemChanged -= OnSelectedMenuItemChanged;
        _view.PreviewSelectedMenuItemChanged -= OnPreviewSelectedMenuItemChanged;

        if (_childPresenter is not null) _childPresenter.CleanUp();
        _childPresenter = null;

        base.CleanUp();
    }
}
