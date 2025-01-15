using System.ComponentModel;

namespace a2_coursework.UserControls.SideMenu;
public partial class SideMenuDropDown : UserControl {
    private SideMenuToggleButton[] sideMenuItems;
    public SideMenuDropDown() {
        InitializeComponent();

    }

    private MenuItemData _menuItemData = new();
    [TypeConverter(typeof(MenuItemDataConverter))]
    public MenuItemData Data {
        get => _menuItemData;
        set {
            _menuItemData = value;
            GenerateMenuDropDown();
        }
    }

    private void GenerateMenuDropDown() {
        if (Data.ChildNames is null || Data.ChildNames.Length == 0) {
            pnlDropDown.Visible = false;
            
        }
        else {
            pnlDropDown.Visible = true;
        }
    }

    private bool _dropDownToggled = false;
    public bool DropDownToggled {
        get => _dropDownToggled;
        set {
            _dropDownToggled = value;
        }
    }

    private void ShowDropDown() {
        pnlDecor.Visible = true;
    }

    protected override void OnResize(EventArgs e) {

        base.OnResize(e);
    }
}
