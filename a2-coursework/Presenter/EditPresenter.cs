using a2_coursework.Interfaces.Users.Settings;

namespace a2_coursework.Presenter;
public abstract class EditPresenter<TView, TModel> : BasePresenter<TView> where TView : IEditView {
    protected TModel _model;

    public EditPresenter(TView view, TModel model) : base(view) {
        _model = model;

        _view.Save += OnSave;
        _view.Cancel += OnCancel;
    }

    private void OnSave(object? sender, EventArgs e) => Save();
    private void OnCancel(object? sender, EventArgs e) => Cancel();

    protected abstract void PopulateDefaultValues();
    protected abstract void UpdateModel();
    protected abstract bool AnyChanges();

    protected virtual async void Save() {
        _view.IsLoading = true;

        if (!ValidateInputs()) {
            _view.ShowMessageBox("Invalid information. Could not save your changes.", "Save failed");
            _view.IsLoading = false;
            return;
        }

        try {
            if (await UpdateDatabase()) {
                UpdateModel();
                _view.IsLoading = false;
                _view.ShowMessageBox("Your changes have been successfully saved.", "Saved");
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
        finally {
            SetApproveChangesBarVisibility();
        }
    }

    protected virtual bool ValidateInputs() => true;

    protected abstract Task<bool> UpdateDatabase();

    protected virtual void Cancel() {
        PopulateDefaultValues();
        SetApproveChangesBarVisibility();
    }

    protected void SetApproveChangesBarVisibility() {
        _view.SaveCancelVisible = AnyChanges();
    }

    public virtual bool CanExit() {
        if (_view.IsLoading) return false;

        if (AnyChanges()) {
            DialogResult result = _view.ShowMessageBox("All your changes will be lost. Click OK if you want to continue", "Are you sure you want to leave?", MessageBoxButtons.OKCancel);

            return result == DialogResult.OK;
        }

        return true;
    }

    public override void CleanUp() {
        _view.Save -= OnSave;
        _view.Cancel -= OnCancel;

        base.CleanUp();
    }
}
