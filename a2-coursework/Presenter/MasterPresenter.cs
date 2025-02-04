using a2_coursework.Model;
using a2_coursework.View;
using a2_coursework.View.Interfaces;

namespace a2_coursework.Presenter;
public class MasterPresenter {
    private IMaster _view;
    private Staff _staff;

    public MasterPresenter(IMaster view, Staff staff) {
        _view = view;
        _staff = staff;

        string[][] menuItems = staff.PrivilegeLevel switch {
            PrivilegeLevel.User =>      [["Dashboard"], ["Settings", "Personal information", "Contact details", "Emergency contact", "Security", "Appearance"]],
            PrivilegeLevel.Admin =>     [["Dashboard"], ["Settings", "Personal information", "Contact details", "Emergency contact", "Security", "Appearance"]],
            PrivilegeLevel.Manager =>   [["Dashboard"], ["Settings", "Personal information", "Contact details", "Emergency contact", "Security", "Appearance"]],
            _ => throw new NotImplementedException(),
        };

        _view.GenerateMenu(menuItems);

        _view.UsernameText = staff.Username;
        Theming.Theme.CurrentTheme = staff.Theme;
    }

    public IChildView GetToggledView(string menuItemName) => menuItemName switch {
        "Personal information" => GetPersonalInformationSettings(),
        "Emergency contact" => GetEmergencyContactSettings(),
        "Contact details" => GetContactDetailsSettings(),
        "Appearance" => GetAppearanceSettings(),
        "Security" => GetSecuritySettings(),
        _ => throw new NotImplementedException(),
    };

    private IChildView GetDashboard() {
        throw new NotImplementedException();
    }

    private IChildView GetPersonalInformationSettings() => ViewFactory.CreatePersonalInformationSettings(_staff).view;
    private IChildView GetEmergencyContactSettings() => ViewFactory.CreateEmergencyContactSettings(_staff).view;
    private IChildView GetContactDetailsSettings() => ViewFactory.CreateContactDetailsSettingsView(_staff).view;
    private IChildView GetAppearanceSettings() => ViewFactory.CreateAppearanceSettings(_staff).view;
    private IChildView GetSecuritySettings() => ViewFactory.CreateSecuritySettings(_staff).view;
}
