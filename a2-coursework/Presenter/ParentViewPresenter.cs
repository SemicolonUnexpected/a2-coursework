using a2_coursework.Interfaces;

namespace a2_coursework.Presenter;

public abstract class ParentViewPresenter<TView, TModel> : BasePresenter<TView>, IChildPresenter where TView : IViewView {
    protected TModel _model;
    protected ICleanable? _childPresenter;

    protected ParentViewPresenter(TView view, TModel model) : base(view) {
        _model = model;

        _view.SelectedMenuItemChanged += OnSelectedMenuItemChanged;
    }

    private void OnSelectedMenuItemChanged(object? sender, string selectedItem) => Navigate(GetView(selectedItem));

    protected abstract (IChildView childView, ICleanable childPresenter) GetView(string selectedItem);

    protected virtual void Navigate(IChildView view, ICleanable presenter) {
        _view.DisplayChildView(view);

        _childPresenter?.CleanUp();

        _childPresenter = presenter;
    }

    protected void Navigate((IChildView childView, ICleanable childPresenter) pair) => Navigate(pair.childView, pair.childPresenter);

    public virtual bool CanExit() => true;

    public override void CleanUp() {
        _childPresenter?.CleanUp();
        _childPresenter = null;

        base.CleanUp();
    }
}
