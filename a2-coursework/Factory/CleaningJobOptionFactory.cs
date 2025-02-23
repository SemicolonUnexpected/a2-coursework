using a2_coursework.Presenter.CleaningJobOption;
using a2_coursework.Presenter.Customer;
using a2_coursework.View;
using a2_coursework.View.JobOption;

namespace a2_coursework.Factory; 
public static class CleaningJobOptionFactory {
    public static (DisplayJobOptionView view, DisplayJobOptionPresenter presenter) CreateDisplayCleaningJobOption() {
        DisplayJobOptionView view = new();
        DisplayJobOptionPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (ManageCleaningJobOptionView view, ManageJobOptionPresenter presenter) CreateManageCleaningJobOption() {
        ManageCleaningJobOptionView view = new();
        ManageJobOptionPresenter presenter = new(view);

        return (view, presenter);
    }
}
