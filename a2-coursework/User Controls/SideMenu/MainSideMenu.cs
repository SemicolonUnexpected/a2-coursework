using a2_coursework.Theming;

namespace a2_coursework.User_Controls.SideMenu;
public partial class MainSideMenu : UserControl {
    public MainSideMenu() {
        InitializeComponent();
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        btnDashboard.Theme();
        smdBooking.Theme();
        smdCustomers.Theme();
        smdOrders.Theme();
        smdSecurity.Theme();
        smdAnalytics.Theme();
        smdUsers.Theme();
        smdSettings.Theme();
    }
}
