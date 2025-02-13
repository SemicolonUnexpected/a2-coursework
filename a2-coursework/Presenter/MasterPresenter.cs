using a2_coursework.Model;
using a2_coursework.UserControls;
using a2_coursework.View;
using a2_coursework.View.Interfaces;

namespace a2_coursework.Presenter;
public class MasterPresenter : BasePresenter<IMasterView> {
    private Staff _staff;
    private IMasterPresenter? _presenter;

    public MasterPresenter(IMasterView view, Staff staff) : base(view) {
        _staff = staff;

        _view.GenerateMenu(GetMenuItems(_staff.PrivilegeLevel));
        _view.UsernameText = staff.Username;
        Theming.Theme.CurrentTheme = staff.Theme;

        _view.PreviewToggleChanged += PreNavigate;
        _view.ToggleChanged += Navigate;
        _view.SignOut += SignOut;
    }

    private string[][] GetMenuItems(PrivilegeLevel staffPrivilegeLevel) => staffPrivilegeLevel switch {
        PrivilegeLevel.User => [
            ["Dashboard"],
            ["Settings", "Personal information", "Contact details", "Emergency contact", "Security", "Appearance"]],

        PrivilegeLevel.Admin => [
            ["Dashboard"],
            ["Stock", "Manage stock", "Request stock", "Upcoming deliveries"],
            ["Security", "Manage Staff", "Login attempts", "Change password"],
            ["Settings", "Personal information", "Contact details", "Emergency contact", "Security", "Appearance"] ],

        PrivilegeLevel.Manager => [
            ["Dashboard"],
            ["Settings", "Personal information", "Contact details", "Emergency contact", "Security", "Appearance"]],

        _ => throw new NotImplementedException(),
    };


    public (IChildView view, IMasterPresenter presenter) GetToggledView(string menuItemName) => menuItemName switch {
        "Personal information" => GetPersonalInformationSettings(),
        "Emergency contact" => GetEmergencyContactSettings(),
        "Contact details" => GetContactDetailsSettings(),
        "Appearance" => GetAppearanceSettings(),
        "Security" => GetSecuritySettings(),
        "Manage stock" => GetStockDisplayView(),
        "Change password" => GetChangePasswordView(),
        _ => throw new NotImplementedException(),
    };

    private (IChildView view, IMasterPresenter presenter) GetPersonalInformationSettings() => ViewFactory.CreatePersonalInformationSettings(_staff);
    private (IChildView view, IMasterPresenter presenter) GetEmergencyContactSettings() => ViewFactory.CreateEmergencyContactSettings(_staff);
    private (IChildView view, IMasterPresenter presenter) GetContactDetailsSettings() => ViewFactory.CreateContactDetailsSettingsView(_staff);
    private (IChildView view, IMasterPresenter presenter) GetAppearanceSettings() => ViewFactory.CreateAppearanceSettings(_staff);
    private (IChildView view, IMasterPresenter presenter) GetSecuritySettings() => ViewFactory.CreateSecuritySettings(_staff);
    private (IChildView view, IMasterPresenter presenter) GetStockDisplayView() => ViewFactory.CreateStockDisplay();
    private (IChildView view, IMasterPresenter presenter) GetChangePasswordView() => ViewFactory.CreateChangePassword(_staff);

    private void SignOut(object? sender, EventArgs e) {
        if (_view.ShowMessageBox("Are you sure you want to sign out?", "Sign out", MessageBoxButtons.OKCancel) == DialogResult.OK) {
            Application.Restart();
        }
    }
    private void PreNavigate(object? sender, ToggleEventArgs e) {
        if (_presenter is null) return;
        else if (!_presenter.CanExit()) e.Handled = true;
    }

    private void Navigate(object? sender, string toggledItem) {
        (IChildView nextView, IMasterPresenter presenter) = GetToggledView(toggledItem);

        _view.DisplayChildForm(nextView);

        _presenter?.CleanUp();
        _presenter = presenter;
    }

    public override void CleanUp() {
        _view.ToggleChanged -= Navigate;
        _view.SignOut -= SignOut;

        base.CleanUp();
    }
}
