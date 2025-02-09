using a2_coursework.Presenter;
using a2_coursework.Model;
using a2_coursework.View.Settings;
using a2_coursework.Presenter.Settings;

namespace a2_coursework.View;
public static class ViewFactory {
    public static (SplashView view, SplashPresenter presenter) CreateSplash() {
        SplashView view = new();
        SplashPresenter presenter = new(view);
        view.SetPresenter(presenter);

        return (view, presenter);
    }

    public static (LoginView view, LoginPresenter presenter) CreateLogin() {
        LoginView view = new();
        LoginPresenter presenter = new(view);
        view.SetPresenter(presenter);

        return (view, presenter);
    }

    public static (MasterView view, MasterPresenter presenter) CreateMaster(Staff staff) {
        MasterView view = new();
        MasterPresenter presenter = new(view, staff);
        view.SetPresenter(presenter);

        return (view, presenter);
    }

    public static (PersonalInformationSettingsView view, PersonalInformationSettingsPresenter presenter) CreatePersonalInformationSettings(Staff staff) {
        PersonalInformationSettingsView view = new();
        PersonalInformationSettingsPresenter presenter = new(view, staff);
        view.SetPresenter(presenter);

        return (view, presenter);
    }

    public static (ContactDetailsSettingsView view, ContactDetailsSettingsPresenter presenter) CreateContactDetailsSettingsView(Staff staff) {
        ContactDetailsSettingsView view = new();
        ContactDetailsSettingsPresenter presenter = new(view, staff);
        view.SetPresenter(presenter);

        return (view, presenter);        
    }

    public static (EmergencyContactSettingsView view, EmergencyContactSettingsPresenter presenter) CreateEmergencyContactSettings(Staff staff) {
        EmergencyContactSettingsView view = new();
        EmergencyContactSettingsPresenter presenter = new(view, staff);
        view.SetPresenter(presenter);

        return (view, presenter);
    }
    
    public static (AppearanceSettingsView view, AppearanceSettingsPresenter presenter) CreateAppearanceSettings(Staff staff) {
        AppearanceSettingsView view = new();
        AppearanceSettingsPresenter presenter = new(view, staff);
        view.SetPresenter(presenter);

        return (view, presenter);
    }

    public static (SecuritySettingsView view, SecuritySettingsPresenter presenter) CreateSecuritySettings(Staff staff) {
        SecuritySettingsView view = new();
        SecuritySettingsPresenter presenter = new(view, staff);
        view.SetPresenter(presenter);

        return (view, presenter);
    }

    //public static (StockDisplayView view, StockDisplayPresenter presenter) CreateStockDisplay(Stock stock) {
    //    StockDisplayView view = new();
    //    StockDisplayPresenter presenter = new(view, staff);
    //    view.SetPresenter(presenter);

    //    return (view, presenter);
    //}

    //public static (StockAddView view, StockAddPresenter presenter) CreateStockAdd(Staff staff) {
    //    StockAddView view = new();
    //    StockAddPresenter presenter = new(view, staff);
    //    view.SetPresenter(presenter);

    //    return (view, presenter);
    //}

    //public static (StockEditView view, StockEditPresenter presenter) CreateStockEdit(Staff staff) {
    //    StockEditView view = new();
    //    StockEditPresenter presenter = new(view, staff);
    //    view.SetPresenter(presenter);

    //    return (view, presenter);
    //}
}
