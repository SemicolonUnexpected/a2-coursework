using a2_coursework.Theming;
using a2_coursework.User_Controls.Menu;

namespace a2_coursework.UserControls; 
public partial class TopMenu : UserControl {
    public TopMenu() {
        InitializeComponent();
    }

    private string[] _menuItems;
    public string[] MenuItems {
        get => _menuItems;
        set {
            _menuItems = value;
            GenerateMenu();
        }
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;
        flp.BackColor = ColorScheme.CurrentTheme.Background;
    }

    private void GenerateMenu() {
        if (_menuItems is null) return;

        flp.Controls.Clear();

        foreach (string itemName in _menuItems) {
            TopMenuItem menuItem = new() {
                Text = itemName,
                Width = Width / _menuItems.Length,
                Height = Height,
                Margin = new Padding(0, 0, 0, 0),
            };

            flp.Controls.Add(menuItem);
        }
            
        ((TopMenuItem)flp.Controls[_selectedIndex]).Selected = true;
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        foreach (Control ctrl in flp.Controls) {
            ctrl.Width = Width / _menuItems.Length;
            ctrl.Height = Height;
        }
    }

    private int _selectedIndex;
    public int SelectedIndex {
        get => _selectedIndex;
        set {
            ((TopMenuItem)flp.Controls[_selectedIndex]).Selected = false;

            _selectedIndex = value;

            ((TopMenuItem)flp.Controls[_selectedIndex]).Selected = true;
        }
    }
}
