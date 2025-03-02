using a2_coursework.Presenter.CleaningJob;
using a2_coursework.View.Users;

namespace a2_coursework.Factory; 
public class CleaningJobFactory {
    public static (BookCleaningJobView view, BookCleaningJobPresenter presenter) CreateBookCleaningJob() {
        BookCleaningJobView view = new();
        BookCleaningJobPresenter presenter = new(view);

        return (view, presenter);
    }

}
