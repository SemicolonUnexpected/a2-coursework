using a2_coursework.Theming;

namespace a2_coursework.UserControls.SideMenu;
public partial class SideMenuDropDown : UserControl {
    private const int MENU_ITEM_HEIGHT = 40;
    public SideMenuDropDown() {
        InitializeComponent();

        GenerateMenuDropDown();
        Theme();
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;
        pnlChildHolder.BackColor = ColorScheme.CurrentTheme.Background;
        pnlSpacer.BackColor = ColorScheme.CurrentTheme.Background;
        pnlDropDown.BackColor = ColorScheme.CurrentTheme.Background;

        pnlDecor.BackColor = ColorScheme.CurrentTheme.Primary;

        btn.Theme();
        btn.IconImage = pnlDropDown.Visible ? IconTheme.CurrentTheme.Minus : IconTheme.CurrentTheme.Plus;

        foreach (SideMenuToggleButton sideMenuToggleButton in ToggleButtons) {
            sideMenuToggleButton.Theme();
        }
    }

    private string _parentName = "";
    public string ParentName {
        get => _parentName;
        set {
            _parentName = value;

            btn.Text = _parentName;
        }
    }

    private string[] _childNames = [];
    public string[] ChildNames {
        get => _childNames;
        set {
            _childNames = value;

            GenerateMenuDropDown();
        }
    }

    private SideMenuToggleButton[] _sideMenuItems = [];
    public SideMenuToggleButton[] ToggleButtons {
        get => _sideMenuItems;
    }

    private void GenerateMenuDropDown() {
        // Clear the current drop down menu
        if (_sideMenuItems is not null) {
            foreach (SideMenuToggleButton btn in _sideMenuItems) {
                pnlDropDown.Controls.Remove(btn);
                btn.Dispose();
            }
        }

        float scalingFactor = DeviceDpi / 96f;
        _sideMenuItems = new SideMenuToggleButton[ChildNames!.Length];

        pnlDropDown.Height = (int)(MENU_ITEM_HEIGHT * ChildNames.Length * scalingFactor);

        for (int i = 0; i < ChildNames.Length; i++) {
            SideMenuToggleButton button = new() {
                Text = ChildNames[i],
                Height = (int)(MENU_ITEM_HEIGHT * scalingFactor),
                Dock = DockStyle.Top,
            };

            pnlChildHolder.Controls.Add(button);
        }

        OnResize(EventArgs.Empty);
    }

    private void btn_Click(object sender, EventArgs e) {
        DropDownToggled = !DropDownToggled;
    }

    public bool DropDownToggled {
        get => pnlDropDown.Visible;
        set {
            pnlDropDown.Visible = value;
            btn.IconImage = pnlDropDown.Visible ? IconTheme.CurrentTheme.Minus : IconTheme.CurrentTheme.Plus;
            OnResize(EventArgs.Empty);
        }
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        Size = new Size(Width, pnlDropDown.Visible ? pnlDropDown.Height + btn.Height : btn.Height);
    }
}
