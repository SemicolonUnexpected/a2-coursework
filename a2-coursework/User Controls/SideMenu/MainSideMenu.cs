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
    }

    private void DropdownToggleChanged(object? sender, EventArgs e) {
        SetupSizeAndScroll();
    }

    protected override void OnResize(EventArgs e) {
        SetupSizeAndScroll();

        base.OnResize(e);

        int value = pnlMenuHolder.Height + pnlHolder.Height;
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

    public string Debug => $"{pnlHolder.Height}, {pnlMenuHolder.Height}";
}
