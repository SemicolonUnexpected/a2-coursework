using a2_coursework.Theming;
using System.ComponentModel;

namespace a2_coursework.UserControls.SideMenu;
public partial class MenuDropdown : UserControl {
    public event EventHandler? DropDownToggleChanged;
    public event EventHandler? DropDownItemToggleChanged;
    public MenuDropdown() {
        InitializeComponent();
    }

    public MenuDropdown(string parentName, string[] childNames) {
        InitializeComponent();

        ParentName = parentName;
        ChildNames = childNames.Reverse().ToArray();

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

        foreach (MenuToggleButton sideMenuToggleButton in ToggleButtons) {
            sideMenuToggleButton.Theme();
        }
    }

    private string _parentName = "";
    [DefaultValue("")]
    [Category("Drop Down")]
    public string ParentName {
        get => _parentName;
        set {
            _parentName = value;

            btn.Text = _parentName;
        }
    }

    private string[] _childNames = [];
    [Category("Drop Down")]
    public string[] ChildNames {
        get => _childNames;
        set {
            _childNames = value;

            GenerateMenuDropDown();
        }
    }

    private MenuToggleButton[] _sideMenuItems = [];
    public MenuToggleButton[] ToggleButtons {
        get => _sideMenuItems;
    }

    private void GenerateMenuDropDown() {
        // Clear the current drop down menu
        if (_sideMenuItems is not null) {
            foreach (MenuToggleButton btn in _sideMenuItems) {
                pnlDropDown.Controls.Remove(btn);
                btn.Dispose();
            }
        }

        _sideMenuItems = new MenuToggleButton[ChildNames!.Length];

        pnlDropDown.Height = btn.Height * ChildNames.Length;

        for (int i = 0; i < ChildNames.Length; i++) {
            MenuToggleButton button = new() {
                Text = ChildNames[i],
                Height = btn.Height,
                Dock = DockStyle.Top,
            };

            button.ToggleChanged += (s, e) => {
                DropDownItemToggleChanged?.Invoke(s, e);
            };

            pnlChildHolder.Controls.Add(button);
            _sideMenuItems[i] = button;
        }

        ResizeDropDown();
    }

    private void btn_Click(object sender, EventArgs e) {
        DropDownToggled = !DropDownToggled;
    }

    private void btn_DoubleClick(object sender, EventArgs e) {
        DropDownToggled = !DropDownToggled;
    }

    public bool DropDownToggled {
        get => pnlDropDown.Visible;
        set {
            pnlDropDown.Visible = value;
            btn.IconImage = pnlDropDown.Visible ? IconTheme.CurrentTheme.Minus : IconTheme.CurrentTheme.Plus;

            ResizeDropDown();
            DropDownToggleChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        ResizeDropDown();
    }

    private void ResizeDropDown() => Size = new Size(Width, pnlDropDown.Visible ? pnlDropDown.Height + btn.Height : btn.Height);
}
