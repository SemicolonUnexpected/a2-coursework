using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.CleaningJob;
using a2_coursework.Model.CleaningJob;
using a2_coursework.Model.CleaningJobOption;
using a2_coursework.Model.Staff;
using a2_coursework.View.Order;

namespace a2_coursework.Presenter.CleaningJob;

public class AddCleaningJobPresenter : AddPresenter<IAddCleaningJobView, CleaningJobModel>, ICleanable, INavigatingPresenter, IChildPresenter {
    private readonly StaffModel _staff;
    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public AddCleaningJobPresenter(IAddCleaningJobView view, DateTime date, StaffModel staff) : base(view, new CleaningJobModel(-1, date.Date.AddHours(9), date.Date.AddHours(10), "", -1, staff.Id, "")) {
        _staff = staff;

        _view.Back += OnBack;

        _viewFactories.Add(GetCustomer);
        _viewFactories.Add(GetDetails);
        _viewFactories.Add(GetDuration);
        _viewFactories.Add(GetOptions);
        _viewFactories.Add(GetManageOptions);
        _viewFactories.Add(GetSelectStaff);

        NavigateToCurrentView();
    }

    private void OnBack(object? sender, EventArgs e) => NavigateBack();

    private void NavigateBack() {
        if (!CanExit()) return;
        (IChildView view, IChildPresenter presenter) = CleaningJobFactory.CreateBookCleaningJob(_staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void BindValidation(ICleanable presenter) { }

    protected override void UnBindValidation(ICleanable presenter) { }

    protected override Task<bool> UpdateDatabase() => CleaningJobDAL.CreateCleaningJob(_model);

    #region Cleaning Job Details
    private (IChildView childView, ICleanable childPresenter) GetDetails() {
        (ManageCleaningJobDetailsView view, ManageCleaningJobDetailsPresenter presenter) = CleaningJobFactory.CreateManageCleaningJobDetails();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesCleaningJobDetails(presenter);
        ValidateCurrent = () => ValidateInputsCleaningJobDetails(presenter);
        UpdateModelCurrent = () => UpdateModelCleaningJobDetails(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesCleaningJobDetails(ManageCleaningJobDetailsPresenter presenter) {
        presenter.Address = _model.Address;
        presenter.ExtraInformation = _model.ExtraInformation;
    }

    private bool ValidateInputsCleaningJobDetails(ManageCleaningJobDetailsPresenter presenter) => presenter.AddressValid;

    private void UpdateModelCleaningJobDetails(ManageCleaningJobDetailsPresenter presenter) {
        _model.Address = presenter.Address;
        _model.ExtraInformation = presenter.ExtraInformation;
    }
    #endregion

    #region Manage Cleaning Job Times
    private (IChildView childView, ICleanable childPresenter) GetDuration() {
        (ManageCleaningJobDurationView view, ManageCleaningJobDurationPresenter presenter) = CleaningJobFactory.CreateManageCleaningJobDuration();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesCleaningJobDuration(presenter);
        ValidateCurrent = () => ValidateInputsCleaningJobDuration(presenter);
        UpdateModelCurrent = () => UpdateModelCleaningJobDuration(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesCleaningJobDuration(ManageCleaningJobDurationPresenter presenter) {
        presenter.StartDate = _model.StartDate;
        presenter.EndDate = _model.EndDate;
    }

    private bool ValidateInputsCleaningJobDuration(ManageCleaningJobDurationPresenter presenter) => presenter.DatesValid;

    private void UpdateModelCleaningJobDuration(ManageCleaningJobDurationPresenter presenter) {
        _model.StartDate = (DateTime)presenter.StartDate!;
        _model.EndDate = (DateTime)presenter.EndDate!;
    }
    #endregion

    #region Select Cleaning Job Options
    private (IChildView childView, ICleanable) GetOptions() {
        (SelectCleaningJobOptionsView view, SelectCleaningJobOptionsPresenter presenter) = CleaningJobFactory.CreateSelectCleaningJobOptions(CleaningJobOptionDAL.GetNonArchivedCleaningJobOptions());

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesSelectCleaningJobOptions(presenter);
        ValidateCurrent = () => ValidateInputsSelectCleaningJobOptions(presenter);
        UpdateModelCurrent = () => UpdateModelSelectCleaningJobOptions(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesSelectCleaningJobOptions(SelectCleaningJobOptionsPresenter presenter) {
        presenter.SelectedCleaningJobOptions = _model.CleaningJobOptions;
    }

    private bool ValidateInputsSelectCleaningJobOptions(SelectCleaningJobOptionsPresenter presenter) {
        if (presenter.SelectedCleaningJobOptions.Count == 0) {
            //_view.ShowMessageBox("Please select at least one cleaning option", "No options selected", MessageBoxButtons.OK);
            return false;
        }
        else return true;
    }

    private void UpdateModelSelectCleaningJobOptions(SelectCleaningJobOptionsPresenter presenter) {
        _model.CleaningJobOptions = [.. presenter.SelectedCleaningJobOptions.Select(x => {
            x.CostAtTime = x.UnitCost;
            return x;
        })];
    }
    #endregion

    #region Manage Cleaning Job Options
    private (IChildView childView, ICleanable childPresenter) GetManageOptions() {
        (ManageCleaningJobOptionsView view, ManageCleaningJobOptionsPresenter presenter) = CleaningJobFactory.CreateManageCleaningJobOptions();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesManageCleaningJobOptions(presenter);
        ValidateCurrent = () => ValidateInputsManageCleaningJobOptions(presenter);
        UpdateModelCurrent = () => UpdateModelManageCleaningJobOptions(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesManageCleaningJobOptions(ManageCleaningJobOptionsPresenter presenter) {
        presenter.Models = _model.CleaningJobOptions;
    }

    private bool ValidateInputsManageCleaningJobOptions(ManageCleaningJobOptionsPresenter presenter) => true;

    private void UpdateModelManageCleaningJobOptions(ManageCleaningJobOptionsPresenter presenter) {
        foreach (CleaningJobOptionModel model in _model.CleaningJobOptions) {
            model.Quantity = presenter.NewQuantities[model.Id];
        }
    }
    #endregion

    #region Select Cleaning Job Customer
    private (IChildView childView, ICleanable childPresenter) GetCustomer() {
        (SelectCleaningJobCustomerView view, SelectCleaningJobCustomerPresenter presenter) = CleaningJobFactory.CreateSelectCleaningJobCustomer();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesSelectCleaningJobCustomer(presenter);
        ValidateCurrent = () => ValidateInputsSelectCleaningJobCustomer(presenter);
        UpdateModelCurrent = () => UpdateModelSelectCleaningJobCustomer(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesSelectCleaningJobCustomer(SelectCleaningJobCustomerPresenter presenter) {
        presenter.SelectedId = _model.CustomerId;
    }

    private bool ValidateInputsSelectCleaningJobCustomer(SelectCleaningJobCustomerPresenter presenter) => presenter.SelectedId is not null;

    private void UpdateModelSelectCleaningJobCustomer(SelectCleaningJobCustomerPresenter presenter) {
        _model.CustomerId = (int)presenter.SelectedId!;
    }
    #endregion

    #region Select Cleaning Job Staff
    private (IChildView childView, ICleanable childPresenter) GetSelectStaff() {
        (SelectCleaningJobStaffView view, SelectCleaningJobStaffPresenter presenter) = CleaningJobFactory.CreateSelectCleaningJobStaff(CleaningJobDAL.GetAvailableCleaners(_model));

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesSelectCleaningJobStaff(presenter);
        ValidateCurrent = () => ValidateInputsSelectCleaningJobStaff(presenter);
        UpdateModelCurrent = () => UpdateModelSelectCleaningJobStaff(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesSelectCleaningJobStaff(SelectCleaningJobStaffPresenter presenter) {
        presenter.SelectedStaffIds = _model.StaffIds;
    }

    private bool ValidateInputsSelectCleaningJobStaff(SelectCleaningJobStaffPresenter presenter) {
        if (presenter.SelectedStaffIds.Count == 0) {
            //_view.ShowMessageBox("Please select at least one cleaning option", "No options selected", MessageBoxButtons.OK);
            return false;
        }
        else return true;
    }

    private void UpdateModelSelectCleaningJobStaff(SelectCleaningJobStaffPresenter presenter) {
        _model.StaffIds = presenter.SelectedStaffIds;
    }
    #endregion

    protected override void OnAddSuccessful() => NavigateBack();

    public override void CleanUp() {
        _view.Back -= OnBack;

        base.CleanUp();
    }
}
