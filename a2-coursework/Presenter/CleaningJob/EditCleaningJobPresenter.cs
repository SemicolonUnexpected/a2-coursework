using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.CleaningJob;
using a2_coursework.Model.CleaningJob;
using a2_coursework.Presenter.CleaningJob;
using a2_coursework.View.CleaningJob;

namespace a2_coursework.Presenter.CleaningJobOption;
public class EditCleaningJobPresenter : ParentEditPresenter<IEditCleaningJobView, CleaningJobModel>, IChildPresenter, INavigatingPresenter {
    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public EditCleaningJobPresenter(IEditCleaningJobView view, CleaningJobModel model) : base(view, model) {
        _view.Back += OnBack;

        Navigate(GetDetails());
    }

    private void OnBack(object? sender, EventArgs e) => NavigateBack();

    private void NavigateBack() {
        if (!CanExit()) return;
        (IChildView view, IChildPresenter presenter) = CleaningJobFactory.CreateBookCleaningJob();
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void BindValidation() { }

    protected override void UnBindValidation() { }

    protected override (IChildView childView, INotifyingChildPresenter childPresenter) GetView(string selectedItem) => selectedItem switch {
        "Details" => GetDetails(),
        _ => throw new NotImplementedException(),
    };

    #region Cleaning Job Details
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetDetails() {
        (ManageCleaningJobDetailsView view, ManageCleaningJobDetailsPresenter presenter) = CleaningJobFactory.CreateManageCleaningJobDetails();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesCleaningJobDetails(presenter);
        AnyChangesCurrent = () => AnyChangesCleaningJobDetails(presenter);
        ValidateCurrent = () => ValidateInputsCleaningJobDetails(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseCleaningJobDetails(presenter);
        UpdateModelCurrent = () => UpdateModelCleaningJobDetails(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesCleaningJobDetails(ManageCleaningJobDetailsPresenter presenter) {
        presenter.Address = _model.Address;
        presenter.ExtraInformation = _model.ExtraInformation;
    }

    private bool AnyChangesCleaningJobDetails(ManageCleaningJobDetailsPresenter presenter) => presenter.Address != _model.Address || presenter.ExtraInformation != _model.ExtraInformation;

    private bool ValidateInputsCleaningJobDetails(ManageCleaningJobDetailsPresenter presenter) => presenter.AddressValid;

    private Task<bool> UpdateDatabaseCleaningJobDetails(ManageCleaningJobDetailsPresenter presenter) => CleaningJobDAL.UpdateCleaningJobDetails(_model.Id, presenter.Address, presenter.ExtraInformation);

    private void UpdateModelCleaningJobDetails(ManageCleaningJobDetailsPresenter presenter) {
        _model.Address = presenter.Address;
        _model.ExtraInformation = presenter.ExtraInformation;
    }
    #endregion

    #region Select Cleaning Job Options
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetOptions() {
        (SelectCleaningJobOptionsView view, SelectCleaningJobOptionsPresenter presenter) = CleaningJobFactory.CreateSelectCleaningJobOptions();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesCleaningJobOptions(presenter);
        AnyChangesCurrent = () => AnyChangesCleaningJobOptions(presenter);
        ValidateCurrent = () => ValidateInputsCleaningJobOptions(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseCleaningJobOptions(presenter);
        UpdateModelCurrent = () => UpdateModelCleaningJobOptions(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesCleaningJobOptions(SelectCleaningJobOptionsPresenter presenter) {
        presenter.SelectedItems
    }

    private bool AnyChangesCleaningJobOptions(SelectCleaningJobOptionsPresenter presenter) => presenter.Address != _model.Address || presenter.ExtraInformation != _model.ExtraInformation;

    private bool ValidateInputsCleaningJobOptions(SelectCleaningJobOptionsPresenter presenter) => presenter.AddressValid;

    private Task<bool> UpdateDatabaseCleaningJobOptions(SelectCleaningJobOptionsPresenter presenter) => CleaningJobDAL.UpdateCleaningJobOptions(_model.Id, presenter.Address, presenter.ExtraInformation);

    private void UpdateModelCleaningJobOptions(SelectCleaningJobOptionsPresenter presenter) {
        _model.Address = presenter.Address;
        _model.ExtraInformation = presenter.ExtraInformation;
    }
    #endregion

    public override void CleanUp() {
        _view.Back -= OnBack;

        base.CleanUp();
    }
}
