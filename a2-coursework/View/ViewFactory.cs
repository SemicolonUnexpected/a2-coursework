using a2_coursework.Presenter;
using a2_coursework.Model;
using a2_coursework.View.Settings;
using a2_coursework.Presenter.Stock;
using a2_coursework.View.Stock;
using a2_coursework.Presenter.Users.Settings;
using a2_coursework.Presenter.Users;
using a2_coursework.View.Users;

namespace a2_coursework.View;
public static class ViewFactory {
    public static SplashPresenter CreateSplash() {
        SplashView view = new();
        SplashPresenter presenter = new(view);

        return presenter;
    }

    public static SignInPresenter CreateSignIn() {
        SignInView view = new();
        SignInPresenter presenter = new(view);

        return presenter;
    }

    public static MasterPresenter  CreateMaster(Staff staff) {
        MasterView view = new();
        MasterPresenter presenter = new(view, staff);

        return presenter;
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

    public static (StockDisplayView view, StockDisplayPresenter presenter) CreateStockDisplay() {
        StockDisplayView view = new();
        StockDisplayPresenter presenter = new(view);
        view.SetPresenter(presenter);

        return (view, presenter);
    }

    public static (ManageStockQuantityView view, ManageStockQuantityPresenter presenter) CreateManageStockQuantity() {
        ManageStockQuantityView view = new();
        ManageStockQuantityPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (ManageStockDetailsView view, ManageStockDetailsPresenter presenter) CreateManageStockDetails() {
        ManageStockDetailsView view = new();
        ManageStockDetailsPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (ManageStockWarningView view, ManageStockWarningPresenter presenter) CreateManageStockWarning() {
        ManageStockWarningView view = new();
        ManageStockWarningPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (ChangePasswordView view, ChangePasswordPresenter presenter) CreateChangePassword(Staff staff) {
        ChangePasswordView view = new();
        ChangePasswordPresenter presenter = new(view, staff);
        view.SetPresenter(presenter);

        return (view, presenter);
    }

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
