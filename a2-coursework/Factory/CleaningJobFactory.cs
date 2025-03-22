using a2_coursework.Model.CleaningJob;
using a2_coursework.Model.CleaningJobOption;
using a2_coursework.Model.Staff;
using a2_coursework.Presenter.CleaningJob;
using a2_coursework.View.CleaningJob;
using a2_coursework.View.Order;
using a2_coursework.View.Users;

namespace a2_coursework.Factory;
public static class CleaningJobFactory {
    public static (BookCleaningJobView view, BookCleaningJobPresenter presenter) CreateBookCleaningJob(StaffModel staff) {
        BookCleaningJobView view = new();
        BookCleaningJobPresenter presenter = new(view, staff);

        return (view, presenter);
    }

    public static (ManageCleaningJobDetailsView view, ManageCleaningJobDetailsPresenter presenter) CreateManageCleaningJobDetails() {
        ManageCleaningJobDetailsView view = new();
        ManageCleaningJobDetailsPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (SelectCleaningJobOptionsView view, SelectCleaningJobOptionsPresenter presenter) CreateSelectCleaningJobOptions(Task<List<CleaningJobOptionModel>> getCleaningJobOptions) {
        SelectCleaningJobOptionsView view = new();
        SelectCleaningJobOptionsPresenter presenter = new(view, getCleaningJobOptions);

        return (view, presenter);
    }

    public static (ManageCleaningJobOptionsView view, ManageCleaningJobOptionsPresenter presenter) CreateManageCleaningJobOptions() {
        ManageCleaningJobOptionsView view = new();
        ManageCleaningJobOptionsPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (ManageCleaningJobDurationView view, ManageCleaningJobDurationPresenter presenter) CreateManageCleaningJobDuration() {
        ManageCleaningJobDurationView view = new();
        ManageCleaningJobDurationPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (SelectCleaningJobCustomerView view, SelectCleaningJobCustomerPresenter presenter) CreateSelectCleaningJobCustomer() {
        SelectCleaningJobCustomerView view = new();
        SelectCleaningJobCustomerPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (SelectCleaningJobStaffView view, SelectCleaningJobStaffPresenter presenter) CreateSelectCleaningJobStaff(Task<List<StaffModel>> getStaff) {
        SelectCleaningJobStaffView view = new();
        SelectCleaningJobStaffPresenter presenter = new(view, getStaff);

        return (view, presenter);
    }

    public static (EditCleaningJobView view, EditCleaningJobPresenter presenter) CreateEditCleaningJob(CleaningJobModel model, StaffModel staff) {
        EditCleaningJobView view = new();
        EditCleaningJobPresenter presenter = new(view, model, staff);

        return (view, presenter);
    }

    public static (ViewCleaningJobCustomerView view, ViewCleaningJobCustomerPresenter presenter) CreateViewCleaningJobCustomer(int id) {
        ViewCleaningJobCustomerView view = new();
        ViewCleaningJobCustomerPresenter presenter = new(view, id);

        return (view, presenter);
    }

    public static (ViewCleaningJobView view, ViewCleaningJobPresenter presenter) CreateViewCleaningJob(CleaningJobModel model, StaffModel staff, bool upcoming) {
        ViewCleaningJobView view = new();
        ViewCleaningJobPresenter presenter = new(view, model, staff, upcoming);

        return (view, presenter);
    }

    public static (DisplayUpcomingCleaningJobView view, DisplayUpcomingCleaningJobPresenter presenter) CreateDisplayUpcomingCleaningJob(StaffModel staff) {
        DisplayUpcomingCleaningJobView view = new();
        DisplayUpcomingCleaningJobPresenter presenter = new(view, staff);

        return (view, presenter);
    }
}