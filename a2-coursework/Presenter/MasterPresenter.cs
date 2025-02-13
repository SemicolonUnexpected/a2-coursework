using a2_coursework.Model;
using a2_coursework.View;
using a2_coursework.View.Interfaces;

namespace a2_coursework.Presenter;
public class MasterPresenter : BasePresenter<IMasterView> {
    private Staff _staff;

    public MasterPresenter(IMasterView view, Staff staff) : base(view) {
        _staff = staff;

        string[][] menuItems = staff.PrivilegeLevel switch {
            PrivilegeLevel.User =>      [["Dashboard"], ["Settings", "Personal information", "Contact details", "Emergency contact", "Security", "Appearance"]],
            PrivilegeLevel.Admin =>     [
              ["Dashboard"],
              ["Stock",
              "Manage stock",
              "Request stock",
              "Upcoming deliveries"],
              ["Security",
              "Manage Staff",
              "Login attempts",
              "Change password"],
              ["Settings",
              "Personal information",
              "Contact details",
              "Emergency contact",
              "Security",
              "Appearance"]
            ],

            PrivilegeLevel.Manager =>   [["Dashboard"], ["Settings", "Personal information", "Contact details", "Emergency contact", "Security", "Appearance"]],
            _ => throw new NotImplementedException(),
        };

        _view.GenerateMenu(menuItems);

        _view.UsernameText = staff.Username;
        Theming.Theme.CurrentTheme = staff.Theme;

        _view.ToggleChanged += (s, e) => Navigate(e);
        _view.SignOut += (s, e) => SignOut();

        BasePresenter p = ViewFactory.CreateSignIn().presenter;
    }

    public IMasterChildView GetToggledView(string menuItemName) => menuItemName switch {
        "Personal information" => GetPersonalInformationSettings(),
        "Emergency contact" => GetEmergencyContactSettings(),
        "Contact details" => GetContactDetailsSettings(),
        "Appearance" => GetAppearanceSettings(),
        "Security" => GetSecuritySettings(),
        "Manage stock" => GetStockDisplayView(),
        "Change password" => GetChangePasswordView(),
        _ => throw new NotImplementedException(),
    };

    private IMasterChildView GetDashboard() {
        throw new NotImplementedException();
    }

    private (IMasterChildView view, BasePresenter presenter) GetPersonalInformationSettings() => ViewFactory.CreatePersonalInformationSettings(_staff);
    private IMasterChildView GetEmergencyContactSettings() => ViewFactory.CreateEmergencyContactSettings(_staff).view;
    private IMasterChildView GetContactDetailsSettings() => ViewFactory.CreateContactDetailsSettingsView(_staff).view;
    private IMasterChildView GetAppearanceSettings() => ViewFactory.CreateAppearanceSettings(_staff).view;
    private IMasterChildView GetSecuritySettings() => ViewFactory.CreateSecuritySettings(_staff).view;
    private IMasterChildView GetStockDisplayView() => ViewFactory.CreateStockDisplay().view;
    private IMasterChildView GetChangePasswordView() => ViewFactory.CreateChangePassword(_staff).view;

    private void SignOut() {
        Application.Restart();
    }

    private void Navigate(string toggledItem) {
        IMasterChildView nextView = GetToggledView(toggledItem);

        _view.DisplayChildForm(nextView);
    }

    public override void CleanUp() {
        base.CleanUp();
    }
}
