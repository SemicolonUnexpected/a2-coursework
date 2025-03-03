using a2_coursework.Presenter.CleaningJob;
using a2_coursework.View.CleaningJob;
using a2_coursework.View.Users;

namespace a2_coursework.Factory; 
public class CleaningJobFactory {
    public static (BookCleaningJobView view, BookCleaningJobPresenter presenter) CreateBookCleaningJob() {
        BookCleaningJobView view = new();
        BookCleaningJobPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (ManageCleaningJobDetailsView view, ManageCleaningJobDetailsPresenter presenter) CreateManageCleaningJobDetails() {
        ManageCleaningJobDetailsView view = new();
        ManageCleaningJobDetailsPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (SelectCleaningJobOptionsView view, SelectCleaningJobOptionsPresenter presenter) CreateSelectCleaningJobOptions() {
        SelectCleaningJobOptionsView view = new();
        SelectCleaningJobOptionsPresenter presenter = new(view);

        return (view, presenter);
    }

}
