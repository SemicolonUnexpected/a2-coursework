using a2_coursework.CustomControls;
using a2_coursework.Theming;

namespace a2_coursework.UserControls;
public partial class SideMenuTwo : UserControl {
    private readonly ToggleButton[] _toggleButtons;
    private readonly Panel[] _backgroundPanels;
    private readonly CustomButton[] _customButtons;
    private readonly Panel[] _decorPanels;
    public SideMenuTwo() {
        InitializeComponent();

        _toggleButtons = [
            btnDashboard,
            btnRecentBookings,
            btnUpcomingBookings,
            btnCalendar
        ];

        _backgroundPanels = [
            pnlMenu,
            pnlDashboard,
            pnlBookings,
            pnlDiaryDropDown,
            pnlUpcomingBookings,
            pnlSpacer1,
            ];

        _customButtons = [
            btnBookings,
            ];

        _decorPanels = [
            pnlSideDecor1,
            pnlSideDecor2
            ];

        Theme();
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        foreach (Panel pnl in _backgroundPanels) {
            pnl.BackColor = ColorScheme.CurrentTheme.Background;
        }

        foreach (Panel pnl in _decorPanels) {
            pnl.BackColor = ColorScheme.CurrentTheme.Primary;
        }

        foreach (CustomButton btn in _customButtons) {
            btn.BackColor = ColorScheme.CurrentTheme.Background;
            btn.HoverColor = ColorScheme.CurrentTheme.Primary;
            btn.ClickedColor = ColorScheme.CurrentTheme.Primary;
            btn.ForeColor = ColorScheme.CurrentTheme.Foreground;
        }

        foreach (ToggleButton btn in _toggleButtons) {
            btn.BackColor = ColorScheme.CurrentTheme.Background;
            btn.HoverColor = ColorScheme.CurrentTheme.Primary;
            btn.ToggledColor = ColorScheme.CurrentTheme.Primary;
            btn.ForeColor = ColorScheme.CurrentTheme.Foreground;
        }

        btnBookings.Image = pnlDiaryDropDown.Visible ? IconTheme.CurrentTheme.Minus : IconTheme.CurrentTheme.Plus;
    }

    private void SideMenu_Load(object sender, EventArgs e) {

    }

    private void ToggleChanged(object sender, EventArgs e) {
        ToggleButton button = (ToggleButton)sender;

        if (button.Toggled) {
            foreach (ToggleButton toggle in _toggleButtons) {
                if (toggle != button) toggle.Toggled = false;
            }
        }
    }

    private void btnDiary_Click(object sender, EventArgs e) {
        pnlDiaryDropDown.Visible = !pnlDiaryDropDown.Visible;
        btnBookings.Image = pnlDiaryDropDown.Visible ? IconTheme.CurrentTheme.Minus : IconTheme.CurrentTheme.Plus;
    }

    private void btnDiary_Resize(object sender, EventArgs e) {

        if (_customButtons is null) return;
        foreach (CustomButton btn in _customButtons) {
            btn.ImageRectangle = new Rectangle(btn.Width - (btn.ImageRectangle.Width + btn.Padding.Right), (btn.Height - btn.ImageRectangle.Height) / 2, btn.ImageRectangle.Width, btn.ImageRectangle.Height);
        }
    }
}
