using a2_coursework.Model;
using a2_coursework.View.Interfaces;

namespace a2_coursework.Presenter;
internal class MasterPresenter {
    private IMaster _view;

    public MasterPresenter(IMaster view, User user) {
        _view = view;

        _view.FormClosed += CloseApplication;

        _view.UsernameText = user.Username;
        Theming.Theme.CurrentTheme = user.Theme;

        _view.Theme();

        string[][] menuItems = user.PrivilegeLevel switch {
            PrivilegeLevel.User => [["Dashboard"], ["Settings", "Personal information", "Contact information", "Emergency Contacts"]],
            PrivilegeLevel.Admin => [["Dashboard"], ["Settings", "Personal information", "Contact information", "Emergency Contacts"]],
            PrivilegeLevel.Manager => [["Dashboard"], ["Settings", "Personal information", "Contact information", "Emergency Contacts"]],
        };

        _view.GenerateMenu(menuItems);
    }

    private void CloseApplication(object? sender, EventArgs e) => Application.Exit();

    public void Show() => _view.Show();
}
