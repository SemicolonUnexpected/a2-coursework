using a2_coursework.Model;
using a2_coursework.UserControls;
using a2_coursework.View.Interfaces;

namespace a2_coursework.Presenter;
public class MasterPresenter {
    private IMaster _view;

    public MasterPresenter(IMaster view, Staff user) {
        _view = view;

        _view.UsernameText = user.Username;
        Theming.Theme.CurrentTheme = user.Theme;

        string[][] menuItems = user.PrivilegeLevel switch {
            PrivilegeLevel.User => [["Dashboard"], ["Settings", "Personal information", "Contact information", "Emergency Contacts"]],
            PrivilegeLevel.Admin => [["Dashboard"], ["Settings", "Personal information", "Contact information", "Emergency Contacts"]],
            PrivilegeLevel.Manager => [["Dashboard"], ["Settings", "Personal information", "Contact information", "Emergency Contacts"]],
        };

        _view.GenerateMenu(menuItems);
    }

    public void PrepareExit(ToggleEventArgs e) {

    }
}
