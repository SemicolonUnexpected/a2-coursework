using a2_coursework.Model;
using a2_coursework.UserControls;
using a2_coursework.View;
using a2_coursework.View.Interfaces;

namespace a2_coursework.Presenter;
public class MasterPresenter {
    private IMaster _view;
    private Staff _staff;

    public MasterPresenter(IMaster view, Staff staff) {
        _view = view;
        _staff = staff;

        _view.UsernameText = staff.Username;
        Theming.Theme.CurrentTheme = staff.Theme;

        string[][] menuItems = staff.PrivilegeLevel switch {
            PrivilegeLevel.User => [["Dashboard"], ["Settings", "Personal information",    "Contact details", "Emergency contact"]],
            PrivilegeLevel.Admin => [["Dashboard"], ["Settings", "Personal information",   "Contact details", "Emergency contact"]],
            PrivilegeLevel.Manager => [["Dashboard"], ["Settings", "Personal information", "Contact details", "Emergency contact"]],
            _ => throw new NotImplementedException(),
        };

        _view.GenerateMenu(menuItems);
    }

    public IChildView GetToggledView(string menuItemName) => menuItemName switch {
        "Personal information" => GetPersonalInformationSettings(),
        "Emergency contact" => GetEmergencyContactSettings(),
        "Contact details" => GetContactDetailsSettings(),
        _ => throw new NotImplementedException(),
    };

    private IChildView GetDashboard() {
        throw new NotImplementedException();
    }

    public IChildView GetPersonalInformationSettings() => ViewFactory.CreatePersonalInformationSettings(_staff).view;
    public IChildView GetEmergencyContactSettings() => ViewFactory.CreateEmergencyContactSettings(_staff).view;
    public IChildView GetContactDetailsSettings() => ViewFactory.CreateContactDetailsSettingsView(_staff).view;
}
