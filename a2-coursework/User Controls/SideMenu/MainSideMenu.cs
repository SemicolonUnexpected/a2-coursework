using a2_coursework.Theming;
using a2_coursework.UserControls.SideMenu;

namespace a2_coursework.User_Controls.SideMenu;
public partial class MainSideMenu : UserControl {
    private SideMenuDropDown[] _dropDowns;

    public MainSideMenu() {
        InitializeComponent();

        _dropDowns = [
            smdBooking,
            smdCustomers,
            smdOrders,
            smdSecurity,
            smdAnalytics,
            smdUsers,
            smdSettings
        ];

        DoubleBuffered = true;

        SizeMenu();

        pnlMenuHolder.Location = Point.Empty;
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        foreach (SideMenuDropDown dropdown in _dropDowns) {
            dropdown.Theme();
        }

        btnDashboard.Theme();
    }

    private void DropDownToggleChanged(object? sender, EventArgs e) {
        SizeMenu();
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        SizeMenu();
    }

    protected override void OnMouseWheel(MouseEventArgs e) {
        base.OnMouseWheel(e);

        pnlMenuHolder.Location = new Point(0, pnlMenuHolder.Location.Y + e.Delta);
        Invalidate();
    }

    private void SizeMenu() {
        if (_dropDowns is null) return;

        int height = btnDashboard.Height;
        foreach (SideMenuDropDown dropdown in _dropDowns) {
            height += dropdown.Height;
        }

        pnlMenuHolder.Size = new Size(pnlHolder.Width, height);
    }
}
