using a2_coursework.Interfaces;
using a2_coursework.Model.Staff;
using a2_coursework.UserControls;
using a2_coursework.View;

namespace a2_coursework.Presenter;
public class MasterPresenter : BasePresenter<IMasterView> {
    private StaffModel _staff;
    private IChildPresenter? _childPresenter;

    public event EventHandler? FormClosed;

    public MasterPresenter(IMasterView view, StaffModel staff) : base(view) {
        _staff = staff;

        _view.GenerateMenu(GetMenuItems(_staff.PrivilegeLevel));
        _view.UsernameText = staff.Username;
        Theming.Theme.Current = staff.Theme;

        _view.PreviewToggleChanged += OnPreviewToggleChanged;
        _view.ToggleChanged += OnToggleChanged;
        _view.SignOut += OnSignOut;
        _view.FormClosed += OnFormClosed;
        _view.FormClosing += OnFormClosing;
    }

    private void OnFormClosing(object? sender, FormClosingEventArgs e) {
        if (_childPresenter is null) return;

        e.Cancel = !_childPresenter.CanExit();
    }

    private void OnFormClosed(object? sender, FormClosedEventArgs e) => FormClosed?.Invoke(this, EventArgs.Empty);
    private void OnToggleChanged(object? sender, string selectedItem) {
        (IChildView view, IChildPresenter presenter) = GetView(selectedItem);
        Navigate(view, presenter);
    }
    private void OnNavigateRequested(object? sender, NavigationEventArgs e) => Navigate(e.View, e.Presenter);
    private void OnSignOut(object? sender, EventArgs e) => SignOut();
    private void OnPreviewToggleChanged(object? sender, ToggleEventArgs e) => e.Handled = !CanNavigate();

    private string[][] GetMenuItems(PrivilegeLevel staffPrivilegeLevel) => staffPrivilegeLevel switch {
        PrivilegeLevel.Office => [
            ["Dashboard"],
            ["Cleaning", "Manage cleaning", "Manage customers"],
            ["Settings", "Personal information", "Contact details", "Emergency contact", "Account security", "Appearance"]],

        PrivilegeLevel.Cleaner => [
            ["Dashboard"],
            ["Cleaning", "Upcoming jobs", "File report"],
            ["Settings", "Personal information", "Contact details", "Emergency contact", "Account security", "Appearance"]],

        PrivilegeLevel.CleaningManager => [
            ["Dashboard"],
            ["Stock", "Manage stock", "Request stock", "Quantity changes", "Upcoming deliveries"],
            ["Security", "Manage staff", "Login attempts", "Change password"],
            ["Settings", "Personal information", "Contact details", "Emergency contact", "Account security", "Appearance"] ],

        PrivilegeLevel.Admin => [
            ["Dashboard"],
            ["Security", "Manage staff", "Login attempts", "Change password"],
            ["Settings", "Personal information", "Contact details", "Emergency contact", "Account security", "Appearance"] ],

        PrivilegeLevel.Manager => [
            ["Dashboard"],
            ["Reports", "Stock usage", "Cleaning"],
            ["Settings", "Personal information", "Contact details", "Emergency contact", "Account security", "Appearance"]],

        _ => throw new NotImplementedException(),
    };

    public (IChildView view, IChildPresenter presenter) GetView(string menuItemName) => menuItemName switch {
        "Personal information" => GetPersonalInformationSettings(),
        "Emergency contact" => GetEmergencyContactSettings(),
        "Contact details" => GetContactDetailsSettings(),
        "Appearance" => GetAppearanceSettings(),
        "Account security" => GetSecuritySettings(),
        "Manage stock" => GetStockDisplayView(),
        "Change password" => GetChangePasswordView(),
        "Quantity changes" => GetDisplayStockQuantityChangesView(),
        "Manage staff" => GetDisplayStaff(),
        _ => throw new NotImplementedException(),
    };

    private (IChildView view, IChildPresenter presenter) GetPersonalInformationSettings() => ViewFactory.CreatePersonalInformationSettings(_staff);
    private (IChildView view, IChildPresenter presenter) GetEmergencyContactSettings() => ViewFactory.CreateEmergencyContactSettings(_staff);
    private (IChildView view, IChildPresenter presenter) GetContactDetailsSettings() => ViewFactory.CreateContactDetailsSettingsView(_staff);
    private (IChildView view, IChildPresenter presenter) GetAppearanceSettings() => ViewFactory.CreateAppearanceSettings(_staff);
    private (IChildView view, IChildPresenter presenter) GetSecuritySettings() => ViewFactory.CreateSecuritySettings(_staff);
    private (IChildView view, IChildPresenter presenter) GetStockDisplayView() => ViewFactory.CreateStockDisplay(_staff);
    private (IChildView view, IChildPresenter presenter) GetChangePasswordView() => ViewFactory.CreateChangePassword(_staff);
    private (IChildView view, IChildPresenter presenter) GetDisplayStockQuantityChangesView() => ViewFactory.CreateDisplayStockQuantityChanges();
    private (IChildView view, IChildPresenter presenter) GetDisplayStaff() => ViewFactory.CreateDisplayStaff();

    private void SignOut() {
        if (_view.ShowMessageBox("Are you sure you want to sign out?", "Sign out", MessageBoxButtons.OKCancel) == DialogResult.OK) {
            Application.Restart();
        }
    }

    private bool CanNavigate() => _childPresenter is null || _childPresenter.CanExit();

    private void Navigate(IChildView view, IChildPresenter presenter) {
        // Display the next view
        _view.DisplayChildView(view);

        // If the view can request to navigate to another view, listen for the request
        if (_childPresenter is INavigatingPresenter oldNavigatingPresenter) oldNavigatingPresenter.NavigationRequest -= OnNavigateRequested;
        if (presenter is INavigatingPresenter navigatingPresenter) navigatingPresenter.NavigationRequest += OnNavigateRequested;

        _childPresenter?.CleanUp();
        _childPresenter = presenter;
    }

    public void Show() => _view.Show();

    public override void CleanUp() {
        _view.PreviewToggleChanged -= OnPreviewToggleChanged;
        _view.ToggleChanged -= OnToggleChanged;
        _view.SignOut -= OnSignOut;
        _view.FormClosed -= OnFormClosed;
        _view.FormClosing -= OnFormClosing;

        base.CleanUp();
    }
}
