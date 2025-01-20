namespace a2_coursework.UserControls.SideMenu; 
public partial class SideMenu : UserControl {
    public SideMenu(string[][] items) {
        InitializeComponent();

        GenerateMenu(items);
    }

    public SideMenu() {
        InitializeComponent();
    }

    public void GenerateMenu(string[][] items) {
        foreach (string[] item in items) {
            if (item.Length == 1) {
                SideMenuToggleButton btn = new() { Text = item[0], Dock = DockStyle.Top };
                pnlMenuHolder.Controls.Add(btn);
            }
            else {
                SideMenuDropdown dropDown = new(item[0], item[1..]) { Dock = DockStyle.Top };
                pnlMenuHolder.Controls.Add(dropDown);
            }
        }
    }

    public object this[int i] {
        get => pnlMenuHolder.Controls[i];
    }

    private void sb_ValueChanged(object sender, EventArgs e) {
        pnlMenuHolder.Location = new Point(0, -sb.Value);
    }

    private void SetupSizeAndScroll() {
        SizeDropdownPanel();
        SetScrollOptions();
    }

    private void SizeDropdownPanel() {
        if (pnlMenuHolder.Controls is null) return;

        int height = 0;
        foreach (Control menuItem in pnlMenuHolder.Controls) {
            height += menuItem.Height;
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
}
