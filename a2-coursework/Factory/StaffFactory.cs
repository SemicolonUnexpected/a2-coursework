﻿using a2_coursework.Model.Staff;
using a2_coursework.Presenter.Staff;
using a2_coursework.Presenter.Staff.Settings;
using a2_coursework.Presenter.Staff.StaffManagement;
using a2_coursework.View;
using a2_coursework.View.Settings;
using a2_coursework.View.Staff.StaffManagement;
using a2_coursework.View.StaffView;
using a2_coursework.View.Stock;
using a2_coursework.View.Users;

namespace a2_coursework.Factory;
public static class StaffFactory {
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

    public static (ChangeStaffPasswordView view, ChangeStaffPasswordPresenter presenter) CreateChangeStaffPassword(StaffModel staff) {
        ChangeStaffPasswordView view = new();
        ChangeStaffPasswordPresenter presenter = new(view, staff);
        view.SetPresenter(presenter);

        return (view, presenter);
    }

    public static (DisplayStaffView view, DisplayStaffPresenter presenter) CreateDisplayStaff(StaffModel staff) {
        DisplayStaffView view = new();
        DisplayStaffPresenter presenter = new(view, staff);

        return (view, presenter);
    }

    public static (ManageStaffAppearanceSettingsView view, ManageStaffAppearanceSettingsPresenter presenter) CreateManageStaffAppearanceSettings() {
        ManageStaffAppearanceSettingsView view = new();
        ManageStaffAppearanceSettingsPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (EditStaffView view, EditStaffPresenter presenter) CreateEditStaff(StaffModel model, StaffModel staff) {
        EditStaffView view = new();
        EditStaffPresenter presenter = new(view, model, staff);

        return (view, presenter);
    }

    public static (ManageStaffPersonalDetailsView view, ManageStaffPersonalDetailsPresenter presenter) CreateManageStaffPersonalInformation() {
        ManageStaffPersonalDetailsView view = new();
        ManageStaffPersonalDetailsPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (ManageStaffContactDetailsView view, ManageStaffContactDetailsPresenter presenter) CreateManageStaffContactDetails() {
        ManageStaffContactDetailsView view = new();
        ManageStaffContactDetailsPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (ManageStaffEmergencyContactDetailsView view, ManageStaffEmergencyContactDetailsPresenter presenter) CreateManageStaffEmergencyContactDetails() {
        ManageStaffEmergencyContactDetailsView view = new();
        ManageStaffEmergencyContactDetailsPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (ManageStaffCredentialsView view, ManageStaffCredentialsPresenter presenter) CreateManageStaffCredentials() {
        ManageStaffCredentialsView view = new();
        ManageStaffCredentialsPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (ManageStaffPasswordView view, ManageStaffPasswordPresenter presenter) CreateManageStaffPassword() {
        ManageStaffPasswordView view = new();
        ManageStaffPasswordPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (AddStaffView view, AddStaffPresenter presenter) CreateAddStaff(StaffModel staff) {
        AddStaffView view = new();
        AddStaffPresenter presenter = new(view, staff);

        return (view, presenter);
    }
}
