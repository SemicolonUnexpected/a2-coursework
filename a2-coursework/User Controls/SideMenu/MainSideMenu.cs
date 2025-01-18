using a2_coursework.UserControls;
using a2_coursework.UserControls.SideMenu;

namespace a2_coursework.User_Controls.SideMenu;
public partial class MainSideMenu : UserControl {
    private SideMenuDropdown[] _dropdowns;

    public MainSideMenu() {
        InitializeComponent();

        DoubleBuffered = true;

        _dropdowns = [
            smdBooking,
            smdCustomers,
            smdOrders,
            smdSecurity,
            smdAnalytics,
            smdUsers,
            smdSettings
        ];

        foreach (SideMenuDropdown dropdown in _dropdowns) {
            foreach (SideMenuToggleButton sideMenuToggleButton in dropdown.ToggleButtons) {
                sideMenuToggleButton.ToggleButton.ToggleChanged += ToggleChanged;
            }
        }

        btnDashboard.ToggleChanged += ToggleChanged;
    }

    protected override void OnMouseWheel(MouseEventArgs e) {
        sb.Value -= e.Delta;
        Update();

        base.OnMouseWheel(e);
    }

    protected override void OnResize(EventArgs e) {
        SetupSizeAndScroll();

        base.OnResize(e);
    }

    private void DropdownToggleChanged(object? sender, EventArgs e) {
        SetupSizeAndScroll();
    }

    private void ToggleChanged(object? sender, EventArgs e) {
        if (sender is not ToggleButton btn) return;

        if (!btn.Toggled) return;

        foreach (SideMenuDropdown dropdown in _dropdowns) {
            foreach (SideMenuToggleButton sideMenuToggleButton in dropdown.ToggleButtons) {
                if (sideMenuToggleButton.ToggleButton != btn) sideMenuToggleButton.Toggled = false;
            }
        }

        if (btnDashboard.ToggleButton != btn) btnDashboard.Toggled = false;

        // Choose the event to fire
        InvokeToggledEvent(btn.Text);
    }

    private void sb_ValueChanged(object sender, EventArgs e) {
        pnlMenuHolder.Location = new Point(0, -sb.Value);
    }

    private void SetupSizeAndScroll() {
        SizeDropdownPanel();
        SetScrollOptions();
    }

    private void SizeDropdownPanel() {
        if (_dropdowns is null) return;

        int height = btnDashboard.Height;
        foreach (SideMenuDropdown dropdown in _dropdowns) {
            height += dropdown.Height;
        }

        pnlMenuHolder.Size = new(pnlHolder.Width, height);
        pnlHolder.Height = Height;
    }

    private void SetScrollOptions() {
        if (pnlHolder.Height < pnlMenuHolder.Height) {
            sb.Visible = true;
            sb.LargeChange = pnlHolder.Height;
            sb.Maximum = pnlMenuHolder.Height - pnlHolder.Height;
        }
        else {
            sb.Visible = false;
            sb.Value = 0;
        }
    }

    public event EventHandler? DashboardToggled;
    public event EventHandler? CalendarToggled;
    public event EventHandler? UpcomingBookingsToggled;
    public event EventHandler? RecentBookingsToggled;
    public event EventHandler? ViewLocationsToggled;
    public event EventHandler? ViewCustomersToggled;
    public event EventHandler? RecentCustomersToggled;
    public event EventHandler? StockUsageToggled;
    public event EventHandler? ManageStockToggled;
    public event EventHandler? PendingOrdersToggled;
    public event EventHandler? CurrentStockToggled;
    public event EventHandler? OverviewToggled;
    public event EventHandler? CleaningToggled;
    public event EventHandler? CleaningStockToggled;
    public event EventHandler? ViewStaffToggled;
    public event EventHandler? ChangePasswordToggled;
    public event EventHandler? BusinessClosureToggled;
    public event EventHandler? PasswordsToggled;
    public event EventHandler? LoginAttemptsToggled;
    public event EventHandler? AppearanceToggled;
    public event EventHandler? AccountStatisticsToggled;
    public event EventHandler? PersonalInformationToggled;

    private void InvokeToggledEvent(string name) {
         if (name == "Dashboard") DashboardToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "Calendar") CalendarToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "Upcoming bookings") UpcomingBookingsToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "Recent bookings") RecentBookingsToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "View locations") ViewLocationsToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "View customers") ViewCustomersToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "Recent customers") RecentCustomersToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "Stock usage") StockUsageToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "Manage stock") ManageStockToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "Pending orders") PendingOrdersToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "Current stock") CurrentStockToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "Overview") OverviewToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "Cleaning") CleaningToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "Cleaning stock") CleaningStockToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "View staff") ViewStaffToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "Change password") ChangePasswordToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "Business closure") BusinessClosureToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "Passwords") PasswordsToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "Login attempts") LoginAttemptsToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "Appearance") AppearanceToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "Account statistics") AccountStatisticsToggled?.Invoke(this, EventArgs.Empty);
         else if (name == "Personal information") PersonalInformationToggled?.Invoke(this, EventArgs.Empty);

        throw new NotImplementedException();
    }
}
