using a2_coursework.Model.Staff;
using a2_coursework.Model.Stock;
using a2_coursework.Presenter;
using a2_coursework.Presenter.StaffPresenters.ManageStaff;
using a2_coursework.Presenter.Stock.StockManagement;
using a2_coursework.Presenter.Stock.StockQuantityChanges;
using a2_coursework.Presenter.StockPresenter.StockQuantityChanges;
using a2_coursework.Presenter.Users;
using a2_coursework.Presenter.Users.Settings;
using a2_coursework.View.Settings;
using a2_coursework.View.Stock;
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

    public static MasterPresenter CreateMaster(StaffModel staff) {
        MasterView view = new();
        MasterPresenter presenter = new(view, staff);

        return presenter;
    }

    public static (PersonalInformationSettingsView view, PersonalInformationSettingsPresenter presenter) CreatePersonalInformationSettings(StaffModel staff) {
        PersonalInformationSettingsView view = new();
        PersonalInformationSettingsPresenter presenter = new(view, staff);

        return (view, presenter);
    }

    public static (ContactDetailsSettingsView view, ContactDetailsSettingsPresenter presenter) CreateContactDetailsSettingsView(StaffModel staff) {
        ContactDetailsSettingsView view = new();
        ContactDetailsSettingsPresenter presenter = new(view, staff);

        return (view, presenter);
    }

    public static (EmergencyContactSettingsView view, EmergencyContactSettingsPresenter presenter) CreateEmergencyContactSettings(StaffModel staff) {
        EmergencyContactSettingsView view = new();
        EmergencyContactSettingsPresenter presenter = new(view, staff);

        return (view, presenter);
    }

    public static (AppearanceSettingsView view, AppearanceSettingsPresenter presenter) CreateAppearanceSettings(StaffModel staff) {
        AppearanceSettingsView view = new();
        AppearanceSettingsPresenter presenter = new(view, staff);

        return (view, presenter);
    }

    public static (SecuritySettingsView view, SecuritySettingsPresenter presenter) CreateSecuritySettings(StaffModel staff) {
        SecuritySettingsView view = new();
        SecuritySettingsPresenter presenter = new(view, staff);

        return (view, presenter);
    }

    public static (DisplayStockView view, DisplayStockPresenter presenter) CreateStockDisplay(StaffModel staff) {
        DisplayStockView view = new();
        DisplayStockPresenter presenter = new(view, staff);

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

    public static (ChangePasswordView view, ChangePasswordPresenter presenter) CreateChangePassword(StaffModel staff) {
        ChangePasswordView view = new();
        ChangePasswordPresenter presenter = new(view, staff);
        view.SetPresenter(presenter);

        return (view, presenter);
    }

    public static (AddStockView view, AddStockPresenter presenter) CreateAddStock(StaffModel staff) {
        AddStockView view = new();
        AddStockPresenter presenter = new(view, staff);

        return (view, presenter);
    }

    public static (EditStockView view, EditStockPresenter presenter) CreateEditStock(StockModel stockItem, StaffModel staff) {
        EditStockView view = new();
        EditStockPresenter presenter = new(view, stockItem, staff);

        return (view, presenter);
    }

    public static (DisplayStockQuantityChangesView view, DisplayStockQuantityChangesPresenter presenter) CreateDisplayStockQuantityChanges() {
        DisplayStockQuantityChangesView view = new();
        DisplayStockQuantityChangesPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (ViewStockQuantityChangeView view, ViewStockQuantityChangePresenter presenter) CreateViewStockQuantityChange(StockQuantityChange stockQuantityChange) {
        ViewStockQuantityChangeView view = new();
        ViewStockQuantityChangePresenter presenter = new(view, stockQuantityChange);

        return (view, presenter);
    }

    public static (DisplayStaffView view, DisplayStaffPresenter presenter) CreateDisplayStaff() {
        DisplayStaffView view = new();
        DisplayStaffPresenter presenter = new(view);

        return (view, presenter);
    }
}
