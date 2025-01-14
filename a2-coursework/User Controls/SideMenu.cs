using a2_coursework.User_Controls;
using System.ComponentModel;
using System.Drawing.Design;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace a2_coursework.UserControls;
public partial class SideMenu : UserControl {
    public SideMenu() {
        InitializeComponent();
    }

    private string[][] _menuItemData = Array.Empty<string[]>();
    [Browsable(false)]
    public string[][] MenuItemData {
        set => _menuItemData = value;
        get {
            return _menuItemData;
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(true)]
    public string MenuItemDataDesigner {
        get {
            if (_menuItemData is null) return "";

            string[] arrayStrings = new string[_menuItemData.Length];

            for (int i = 0; i <= _menuItemData.Length; i++) {
                arrayStrings[i] = string.Join(',', _menuItemData[i]);
            }

            return string.Join(';', arrayStrings);
        }
        set {
            value.Trim();

            if (value.Length == 0) {
                _menuItemData = Array.Empty<string[]>();
                return;
            }

            string[] arrays = value.Split(';');
            string[][] jaggedArray = new string[arrays.Length][];
            for (int i = 0; i < arrays.Length; i++) {
                jaggedArray[i] = arrays[i].Split(",");
            }

            _menuItemData = jaggedArray;
        }
    }
}
