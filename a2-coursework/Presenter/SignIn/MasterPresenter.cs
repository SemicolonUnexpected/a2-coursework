using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.SignIn;
using a2_coursework.Model.Reports;
using a2_coursework.Model.Staff;
using a2_coursework.UserControls;

namespace a2_coursework.Presenter.SignIn;
public class MasterPresenter : BasePresenter<IMasterView> {
    private readonly StaffModel _staff;
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

        _view.SetSideMenuToggledIndex(0, 0, true);
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
            ["Cleaning", "Book cleaning", "Manage customers", "Manage options"],
            ["Reports", "Staff", "Stock"],
            ["Settings", "Personal information", "Contact details", "Emergency contact", "Account security", "Appearance"] ],

        PrivilegeLevel.Admin => [
            ["Dashboard"],
            ["Security", "Manage staff", "Change password"],
            ["Reports", "Staff"],
            ["Settings", "Personal information", "Contact details", "Emergency contact", "Account security", "Appearance"] ],

        PrivilegeLevel.Manager => [
            ["Dashboard"],
            ["Reports", "Staff", "Stock"],
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
        "Manage customers" => GetDisplayCustomers(),
        "Manage options" => GetDisplayJobOptions(),
        "Staff" => GetStaffReport(),
        "Stock" => GetStockReport(),
        "Login attempts" => GetLoginAttempts(),
        "Book cleaning" => GetBookCleaning(),
        "Dashboard" => GetDashboardView(),
        _ => throw new NotImplementedException(),
    };


    private (IChildView view, IChildPresenter presenter) GetPersonalInformationSettings() => StaffFactory.CreatePersonalInformationSettings(_staff);
    private (IChildView view, IChildPresenter presenter) GetEmergencyContactSettings() => StaffFactory.CreateEmergencyContactSettings(_staff);
    private (IChildView view, IChildPresenter presenter) GetContactDetailsSettings() => StaffFactory.CreateContactDetailsSettingsView(_staff);
    private (IChildView view, IChildPresenter presenter) GetAppearanceSettings() => StaffFactory.CreateAppearanceSettings(_staff);
    private (IChildView view, IChildPresenter presenter) GetSecuritySettings() => StaffFactory.CreateSecuritySettings(_staff);
    private (IChildView view, IChildPresenter presenter) GetStockDisplayView() => StockFactory.CreateStockDisplay(_staff);
    private (IChildView view, IChildPresenter presenter) GetChangePasswordView() => StaffFactory.CreateChangeStaffPassword(_staff);
    private (IChildView view, IChildPresenter presenter) GetDisplayStockQuantityChangesView() => StockFactory.CreateDisplayStockQuantityChanges();
    private (IChildView view, IChildPresenter presenter) GetDisplayStaff() => StaffFactory.CreateDisplayStaff(_staff);
    private (IChildView view, IChildPresenter presenter) GetDisplayCustomers() => CustomerFactory.CreateDisplayCustomer();
    private (IChildView view, IChildPresenter presenter) GetDisplayJobOptions() => CleaningJobOptionFactory.CreateDisplayCleaningJobOption();
    private (IChildView view, IChildPresenter presenter) GetLoginAttempts() => SignInFactory.CreateDisplayLoginAttempt();
    private (IChildView view, IChildPresenter presenter) GetStaffReport() => ReportFactory.CreateReport("StaffReport", StaffReportGenerator.StaffSecurityReport());
    private (IChildView view, IChildPresenter presenter) GetStockReport() => ReportFactory.CreateReport("StockReport", StockReportGenerator.StockItemsReport());
    private (IChildView view, IChildPresenter presenter) GetBookCleaning() => CleaningJobFactory.CreateBookCleaningJob(_staff);
    private (IChildView view, IChildPresenter presenter) GetDashboardView() => SignInFactory.CreateDashboard(_staff);

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
