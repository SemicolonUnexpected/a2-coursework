using a2_coursework.Model;
using a2_coursework.UserControls;
using a2_coursework.View;
using a2_coursework.View.Interfaces;

namespace a2_coursework.Presenter;
public class MasterPresenter : BasePresenter<IMasterView> {
    private Staff _staff;
    private IMasterChildPresenter? _childPresenter;

    public event EventHandler? FormClosed;

    public MasterPresenter(IMasterView view, Staff staff) : base(view) {
        _staff = staff;

        _view.GenerateMenu(GetMenuItems(_staff.PrivilegeLevel));
        _view.UsernameText = staff.Username;
        Theming.Theme.CurrentTheme = staff.Theme;

        _view.PreviewToggleChanged += OnPreviewToggleChanged;
        _view.ToggleChanged += OnToggleChanged;
        _view.SignOut += OnSignOut;
        _view.FormClosed += OnFormClosed;
    }

    private void OnFormClosed(object? sender, EventArgs e) => FormClosed?.Invoke(this, EventArgs.Empty);
    private void OnToggleChanged(object? sender, string selectedItem) => Navigate(selectedItem);
    private void OnSignOut(object? sender, EventArgs e) => SignOut();
    private void OnPreviewToggleChanged(object? sender, ToggleEventArgs e) => e.Handled = !CanNavigate();

    private string[][] GetMenuItems(PrivilegeLevel staffPrivilegeLevel) => staffPrivilegeLevel switch {
        PrivilegeLevel.User => [
            ["Dashboard"],
            ["Cleaning", "Manage cleaning", "Manage customers"],
            ["Settings", "Personal information", "Contact details", "Emergency contact", "Account security", "Appearance"]],

        PrivilegeLevel.Cleaner => [
            ["Dashboard"],
            ["Cleaning", "Upcoming jobs", "File report"],
            ["Settings", "Personal information", "Contact details", "Emergency contact", "Account security", "Appearance"]],

        PrivilegeLevel.CleaningManager => [
            ["Dashboard"],
            ["Stock", "Manage stock", "Request stock", "Upcoming deliveries"],
            ["Settings", "Personal information", "Contact details", "Emergency contact", "Account security", "Appearance"] ],

        PrivilegeLevel.Admin => [
            ["Dashboard"],
            ["Security", "Manage Staff", "Login attempts", "Change password"],
            ["Settings", "Personal information", "Contact details", "Emergency contact", "Account security", "Appearance"] ],

        PrivilegeLevel.Manager => [
            ["Dashboard"],
            ["Reports", "Stock usage", "Cleaning"],
            ["Settings", "Personal information", "Contact details", "Emergency contact", "Account security", "Appearance"]],

        _ => throw new NotImplementedException(),
    };

    public (IChildView view, IMasterChildPresenter presenter) GetToggledView(string menuItemName) => menuItemName switch {
        "Personal information" => GetPersonalInformationSettings(),
        "Emergency contact" => GetEmergencyContactSettings(),
        "Contact details" => GetContactDetailsSettings(),
        "Appearance" => GetAppearanceSettings(),
        "Account security" => GetSecuritySettings(),
        "Manage stock" => GetStockDisplayView(),
        "Change password" => GetChangePasswordView(),
        _ => throw new NotImplementedException(),
    };

    private (IChildView view, IMasterChildPresenter presenter) GetPersonalInformationSettings() => ViewFactory.CreatePersonalInformationSettings(_staff);
    private (IChildView view, IMasterChildPresenter presenter) GetEmergencyContactSettings() => ViewFactory.CreateEmergencyContactSettings(_staff);
    private (IChildView view, IMasterChildPresenter presenter) GetContactDetailsSettings() => ViewFactory.CreateContactDetailsSettingsView(_staff);
    private (IChildView view, IMasterChildPresenter presenter) GetAppearanceSettings() => ViewFactory.CreateAppearanceSettings(_staff);
    private (IChildView view, IMasterChildPresenter presenter) GetSecuritySettings() => ViewFactory.CreateSecuritySettings(_staff);
    private (IChildView view, IMasterChildPresenter presenter) GetStockDisplayView() => ViewFactory.CreateStockDisplay();
    private (IChildView view, IMasterChildPresenter presenter) GetChangePasswordView() => ViewFactory.CreateChangePassword(_staff);

    private void SignOut() {
        if (_view.ShowMessageBox("Are you sure you want to sign out?", "Sign out", MessageBoxButtons.OKCancel) == DialogResult.OK) {
            Application.Restart();
        }
    }

    private bool CanNavigate() => _childPresenter is null || _childPresenter.CanExit();

    private void Navigate(string toggledItem) {
        (IChildView nextView, IMasterChildPresenter presenter) = GetToggledView(toggledItem);

        _view.DisplayChildForm(nextView);

        _childPresenter?.CleanUp();
        _childPresenter = presenter;
    }

    public void Show() => _view.Show();

    public override void CleanUp() {
        _view.PreviewToggleChanged -= OnPreviewToggleChanged;
        _view.ToggleChanged -= OnToggleChanged;
        _view.SignOut -= OnSignOut;
        _view.FormClosed -= OnFormClosed;

        base.CleanUp();
    }
}
