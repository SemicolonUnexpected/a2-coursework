﻿using a2_coursework.Model.CleaningJobOption;
using a2_coursework.Presenter.CleaningJobOption;
using a2_coursework.Presenter.Customer;
using a2_coursework.View;
using a2_coursework.View.CleaningJob;
using a2_coursework.View.JobOption;

namespace a2_coursework.Factory; 
public static class CleaningJobOptionFactory {
    public static (DisplayCleaningJobOptionView view, DisplayCleaningJobOptionPresenter presenter) CreateDisplayCleaningJobOption() {
        DisplayCleaningJobOptionView view = new();
        DisplayCleaningJobOptionPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (ManageCleaningJobOptionView view, ManageJobCleaningOptionPresenter presenter) CreateManageCleaningJobOption() {
        ManageCleaningJobOptionView view = new();
        ManageJobCleaningOptionPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (EditCleaningJobOptionView view, EditCleaningJobOptionPresenter presenter) CreateEditCleaningJobOption(CleaningJobOptionModel model) {
        EditCleaningJobOptionView view = new();
        EditCleaningJobOptionPresenter presenter = new(view, model);

        return (view, presenter);
    }

    public static (AddCleaningJobOptionView view, AddCleaningJobOptionPresenter presenter) CreateAddCleaningJobOption() {
        AddCleaningJobOptionView view = new();
        AddCleaningJobOptionPresenter presenter = new(view);

        return (view, presenter);
    }
}
