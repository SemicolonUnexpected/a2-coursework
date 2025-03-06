using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.CleaningJob;
using a2_coursework.Model.CleaningJob;
using a2_coursework.Model.CleaningJobOption;
using a2_coursework.View.CleaningJob;

namespace a2_coursework.Presenter.CleaningJob;
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
        "Times" => GetDuration(),
        "Staff" => GetSelectStaff(),
        "Options" => GetOptions(),
        "Quantity" => GetManageOptions(),
        "Customer" => GetCustomer(),
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

    #region Manage Cleaning Job Times
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetDuration() {
        (ManageCleaningJobDurationView view, ManageCleaningJobDurationPresenter presenter) = CleaningJobFactory.CreateManageCleaningJobDuration();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesCleaningJobDuration(presenter);
        AnyChangesCurrent = () => AnyChangesCleaningJobDuration(presenter);
        ValidateCurrent = () => ValidateInputsCleaningJobDuration(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseCleaningJobDuration(presenter);
        UpdateModelCurrent = () => UpdateModelCleaningJobDuration(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesCleaningJobDuration(ManageCleaningJobDurationPresenter presenter) {
        presenter.StartDate = _model.StartDate;
        presenter.EndDate = _model.EndDate;
    }

    private bool AnyChangesCleaningJobDuration(ManageCleaningJobDurationPresenter presenter) => presenter.StartDate != _model.StartDate || presenter.EndDate != _model.EndDate;

    private bool ValidateInputsCleaningJobDuration(ManageCleaningJobDurationPresenter presenter) => presenter.DatesValid;

    private Task<bool> UpdateDatabaseCleaningJobDuration(ManageCleaningJobDurationPresenter presenter) => CleaningJobDAL.UpdateCleaningJobTimes(_model.Id, (DateTime)presenter.StartDate!, (DateTime)presenter.EndDate!);

    private void UpdateModelCleaningJobDuration(ManageCleaningJobDurationPresenter presenter) {
        _model.StartDate = (DateTime)presenter.StartDate!;
        _model.EndDate = (DateTime)presenter.EndDate!;
    }
    #endregion

    #region Select Cleaning Job Options
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetOptions() {
        (SelectCleaningJobOptionsView view, SelectCleaningJobOptionsPresenter presenter) = CleaningJobFactory.CreateSelectCleaningJobOptions(CleaningJobOptionDAL.GetNonArchivedCleaningJobOptions());

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesSelectCleaningJobOptions(presenter);
        AnyChangesCurrent = () => AnyChangesSelectCleaningJobOptions(presenter);
        ValidateCurrent = () => ValidateInputsSelectCleaningJobOptions(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseSelectCleaningJobOptions(presenter);
        UpdateModelCurrent = () => UpdateModelSelectCleaningJobOptions(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesSelectCleaningJobOptions(SelectCleaningJobOptionsPresenter presenter) {
        presenter.SelectedCleaningJobOptions = _model.CleaningJobOptions;
    }

    private bool AnyChangesSelectCleaningJobOptions(SelectCleaningJobOptionsPresenter presenter) {
        List<int> a = presenter.SelectedCleaningJobOptions.ConvertAll(x => x.Id);
        List<int> b = _model.CleaningJobOptions.ConvertAll(x => x.Id);

        if (a.Count != b.Count) return true;

        return !a.All(b.Contains);
    }

    private bool ValidateInputsSelectCleaningJobOptions(SelectCleaningJobOptionsPresenter presenter) {
        if (presenter.SelectedCleaningJobOptions.Count == 0) {
            //_view.ShowMessageBox("Please select at least one cleaning option", "No options selected", MessageBoxButtons.OK);
            return false;
        }
        else return true;
    }

    private Task<bool> UpdateDatabaseSelectCleaningJobOptions(SelectCleaningJobOptionsPresenter presenter) => CleaningJobDAL.UpdateCleaningJobCleaningOptions(_model.Id, presenter.SelectedCleaningJobOptions);

    private void UpdateModelSelectCleaningJobOptions(SelectCleaningJobOptionsPresenter presenter) {
        _model.CleaningJobOptions = presenter.SelectedCleaningJobOptions;
    }
    #endregion

    #region Manage Cleaning Job Options
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetManageOptions() {
        (ManageCleaningJobOptionsView view, ManageCleaningJobOptionsPresenter presenter) = CleaningJobFactory.CreateManageCleaningJobOptions();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesManageCleaningJobOptions(presenter);
        AnyChangesCurrent = () => AnyChangesManageCleaningJobOptions(presenter);
        ValidateCurrent = () => ValidateInputsManageCleaningJobOptions(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseManageCleaningJobOptions(presenter);
        UpdateModelCurrent = () => UpdateModelManageCleaningJobOptions(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesManageCleaningJobOptions(ManageCleaningJobOptionsPresenter presenter) {
        presenter.Models = _model.CleaningJobOptions;
    }

    private bool AnyChangesManageCleaningJobOptions(ManageCleaningJobOptionsPresenter presenter) {
        Dictionary<int, int> a = presenter.Models.ToDictionary(x => x.Id, x => x.Quantity);
        Dictionary<int, int> b = _model.CleaningJobOptions.ToDictionary(x => x.Id, x => x.Quantity);

        return a.Keys.Any(x => b.ContainsKey(x) && a[x] != b[x]);
    }

    private bool ValidateInputsManageCleaningJobOptions(ManageCleaningJobOptionsPresenter presenter) => true;

    private Task<bool> UpdateDatabaseManageCleaningJobOptions(ManageCleaningJobOptionsPresenter presenter) => throw new NotImplementedException();

    private void UpdateModelManageCleaningJobOptions(ManageCleaningJobOptionsPresenter presenter) {
        _model.CleaningJobOptions = presenter.Models;
    }
    #endregion

    #region Select Cleaning Job Customer
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetCustomer() {
        (SelectCleaningJobCustomerView view, SelectCleaningJobCustomerPresenter presenter) = CleaningJobFactory.CreateSelectCleaningJobCustomer();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesSelectCleaningJobCustomer(presenter);
        AnyChangesCurrent = () => AnyChangesSelectCleaningJobCustomer(presenter);
        ValidateCurrent = () => ValidateInputsSelectCleaningJobCustomer(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseSelectCleaningJobCustomer(presenter);
        UpdateModelCurrent = () => UpdateModelSelectCleaningJobCustomer(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesSelectCleaningJobCustomer(SelectCleaningJobCustomerPresenter presenter) {
        presenter.SelectedId = _model.CustomerId;
    }

    private bool AnyChangesSelectCleaningJobCustomer(SelectCleaningJobCustomerPresenter presenter) => presenter.SelectedId != _model.CustomerId;

    private bool ValidateInputsSelectCleaningJobCustomer(SelectCleaningJobCustomerPresenter presenter) => true;

    private Task<bool> UpdateDatabaseSelectCleaningJobCustomer(SelectCleaningJobCustomerPresenter presenter) => CleaningJobDAL.UpdateCleaningJobCustomer(_model.Id, presenter.SelectedId);

    private void UpdateModelSelectCleaningJobCustomer(SelectCleaningJobCustomerPresenter presenter) {
        _model.CustomerId = presenter.SelectedId;
    }

    #endregion

    #region Select Cleaning Job Staff
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetSelectStaff() {
        (SelectCleaningJobStaffView view, SelectCleaningJobStaffPresenter presenter) = CleaningJobFactory.CreateSelectCleaningJobStaff(CleaningJobDAL.GetAvailableCleaners(_model));

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesSelectCleaningJobStaff(presenter);
        AnyChangesCurrent = () => AnyChangesSelectCleaningJobStaff(presenter);
        ValidateCurrent = () => ValidateInputsSelectCleaningJobStaff(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseSelectCleaningJobStaff(presenter);
        UpdateModelCurrent = () => UpdateModelSelectCleaningJobStaff(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesSelectCleaningJobStaff(SelectCleaningJobStaffPresenter presenter) {
        presenter.SelectedStaffIds = _model.StaffIds;
    }

    private bool AnyChangesSelectCleaningJobStaff(SelectCleaningJobStaffPresenter presenter) {
        List<int> a = presenter.SelectedStaffIds;
        List<int> b = _model.StaffIds;

        if (a.Count != b.Count) return true;

        return !a.All(b.Contains);
    }

    private bool ValidateInputsSelectCleaningJobStaff(SelectCleaningJobStaffPresenter presenter) {
        if (presenter.SelectedStaffIds.Count == 0) {
            //_view.ShowMessageBox("Please select at least one cleaning option", "No options selected", MessageBoxButtons.OK);
            return false;
        }
        else return true;
    }

    private Task<bool> UpdateDatabaseSelectCleaningJobStaff(SelectCleaningJobStaffPresenter presenter) => CleaningJobDAL.UpdateCleaningJobStaff(_model.Id, presenter.SelectedStaffIds);

    private void UpdateModelSelectCleaningJobStaff(SelectCleaningJobStaffPresenter presenter) {
        _model.StaffIds = presenter.SelectedStaffIds;
    }

    #endregion

    public override void CleanUp() {
        _view.Back -= OnBack;

        base.CleanUp();
    }
}
