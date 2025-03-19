using a2_coursework.Interfaces;

namespace a2_coursework.Presenter;

public abstract class AddPresenter<TView, TModel> : BasePresenter<TView> where TView : IAddView {
    protected TModel _model;

    protected Action? PopulateDefaultValuesCurrent;
    protected Func<bool>? ValidateCurrent;
    protected Action? UpdateModelCurrent;

    protected ICleanable? _childPresenter;
    protected int _currentViewIndex = 0;
    protected readonly List<Func<(IChildView, ICleanable)>> _viewFactories = [];

    public AddPresenter(TView view, TModel model) : base(view) {
        _model = model;

        _view.Next += OnNext;
        _view.Previous += OnPrevious;
        _view.Done += OnDone;
    }

    private void OnNext(object? sender, EventArgs e) => Next();
    private void OnPrevious(object? sender, EventArgs e) => Previous();
    private void OnDone(object? sender, EventArgs e) => Done();

    protected virtual void Next() {
        if (!ValidateInputs()) {
            _view.ShowMessageBox("Ensure all data is valid before continuing.", "Invalid data");
            return;
        }

        UpdateModel();

        _currentViewIndex++;
        NavigateToCurrentView();
    }

    protected virtual void Previous() {
        UpdateModel();

        _currentViewIndex--;
        NavigateToCurrentView();
    }

    protected virtual async void Done() {
        if (!ValidateInputs()) {
            _view.ShowMessageBox("Ensure all data is valid before finishing.", "Invalid data");
            return;
        }

        UpdateModel();

        await Add();
    }

    protected virtual void NavigateToCurrentView() {
        (IChildView childView, ICleanable presenter) = _viewFactories[_currentViewIndex]();

        _view.DoneVisible = _currentViewIndex == _viewFactories.Count - 1;
        _view.NextVisible = _currentViewIndex < _viewFactories.Count - 1;
        _view.PreviousVisible = _currentViewIndex > 0;

        _view.DisplayChildView(childView);

        if (_childPresenter is not null) {
            UnBindValidation(_childPresenter);
            _childPresenter.CleanUp();
        }

        _childPresenter = presenter;

        BindValidation(_childPresenter);
        PopulateDefaultValues();
    }

    protected virtual void PopulateDefaultValues() => PopulateDefaultValuesCurrent?.Invoke();
    protected virtual void UpdateModel() => UpdateModelCurrent?.Invoke();
    protected virtual bool ValidateInputs() => ValidateCurrent?.Invoke() ?? true;

    protected abstract void BindValidation(ICleanable presenter);
    protected abstract void UnBindValidation(ICleanable presenter);

    protected virtual async Task Add() {
        _view.IsLoading = true;

        try {
            if (await UpdateDatabase()) {
                _view.IsLoading = false;
                _view.ShowMessageBox("Your changes have been successfully saved.", "Saved");
                OnAddSuccessful();
            }
            else {
                _view.IsLoading = false;
                _view.ShowMessageBox("Could not save your changes.", "Save failed");
            }
        }
        catch {
            _view.IsLoading = false;
            _view.ShowMessageBox("Could not save your changes.", "Save failed");
        }
    }

    protected abstract Task<bool> UpdateDatabase();

    protected virtual void OnAddSuccessful() { }

    public virtual bool CanExit() {
        if (_view.IsLoading) return false;

        DialogResult result = _view.ShowMessageBox("All your changes will be lost. Click OK if you want to continue", "Are you sure you want to leave?", MessageBoxButtons.OKCancel);

        return result == DialogResult.OK;
    }

    public override void CleanUp() {
        _view.Next -= OnNext;
        _view.Previous -= OnPrevious;
        _view.Done -= OnDone;

        if (_childPresenter is not null) _childPresenter.CleanUp();
        _childPresenter = null;

        base.CleanUp();
    } 
}