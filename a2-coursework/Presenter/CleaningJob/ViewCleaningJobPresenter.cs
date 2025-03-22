using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.CleaningJob;
using a2_coursework.Model.CleaningJob;
using a2_coursework.Model.Staff;
using a2_coursework.View.Order;

namespace a2_coursework.Presenter.CleaningJob;
public class ViewCleaningJobPresenter : ParentViewPresenter<IViewCleaningJobView, CleaningJobModel>, IChildPresenter, INavigatingPresenter {
    private readonly bool _upcoming;
    private readonly StaffModel _staff;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public ViewCleaningJobPresenter(IViewCleaningJobView view, CleaningJobModel model, StaffModel staff, bool upcoming) : base(view, model) {
        _upcoming = upcoming;
        _staff = staff;

        _view.Back += OnBack;

        Navigate(GetDetails());
    }

    private void OnBack(object? sender, EventArgs e) => NavigateBack();

    private void NavigateBack() {
        if (!CanExit()) return;

        (IChildView view, IChildPresenter presenter) viewPresenter;
        if (!_upcoming) viewPresenter = CleaningJobFactory.CreateBookCleaningJob(_staff);
        else viewPresenter = CleaningJobFactory.CreateDisplayUpcomingCleaningJob(_staff);

        NavigationRequest?.Invoke(this, new NavigationEventArgs(viewPresenter.view, viewPresenter.presenter));
    }

    protected override (IChildView childView, ICleanable childPresenter) GetView(string selectedItem) => selectedItem switch {
        "Details" => GetDetails(),
        "Times" => GetDuration(),
        "Staff" => GetSelectStaff(),
        "Quantity" => GetManageOptions(),
        "Customer" => GetCustomer(),
        _ => throw new NotImplementedException(),
    };

    #region Cleaning Job Details
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetDetails() {
        (ManageCleaningJobDetailsView view, ManageCleaningJobDetailsPresenter presenter) = CleaningJobFactory.CreateManageCleaningJobDetails();

        presenter.ReadOnly = true;

        presenter.Address = _model.Address;

        return (view, presenter);
    }
    #endregion

    #region Manage Cleaning Job Times
    private (IChildView childView, ICleanable childPresenter) GetDuration() {
        (ManageCleaningJobDurationView view, ManageCleaningJobDurationPresenter presenter) = CleaningJobFactory.CreateManageCleaningJobDuration();

        presenter.ReadOnly = true;

        presenter.StartDate = _model.StartDate;
        presenter.EndDate = _model.EndDate;

        return (view, presenter);
    }
    #endregion

    #region Manage Cleaning Job Options
    private (IChildView childView, ICleanable childPresenter) GetManageOptions() {
        (ManageCleaningJobOptionsView view, ManageCleaningJobOptionsPresenter presenter) = CleaningJobFactory.CreateManageCleaningJobOptions();

        presenter.ReadOnly = true;

        presenter.Models = _model.CleaningJobOptions;

        return (view, presenter);
    }
    #endregion

    #region Select Cleaning Job Customer
    private (IChildView childView, ICleanable childPresenter) GetCustomer() {
        (ViewCleaningJobCustomerView view, ViewCleaningJobCustomerPresenter presenter) = CleaningJobFactory.CreateViewCleaningJobCustomer(_model.CustomerId);

        return (view, presenter);
    }
    #endregion

    #region Select Cleaning Job Staff
    private (IChildView childView, ICleanable childPresenter) GetSelectStaff() {
        (SelectCleaningJobStaffView view, SelectCleaningJobStaffPresenter presenter) = CleaningJobFactory.CreateSelectCleaningJobStaff(CleaningJobDAL.GetCleaningJobCleaningStaff(_model.Id));

        presenter.ReadOnly = true;

        presenter.SelectedStaffIds = _model.StaffIds;

        return (view, presenter);
    }
    #endregion

    public override void CleanUp() {
        _view.Back -= OnBack;

        base.CleanUp();
    }
}
