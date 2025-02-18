using a2_coursework.Theming;
using a2_coursework.User_Controls.Menu;

namespace a2_coursework.UserControls;
public partial class TopMenu : UserControl {
    public event EventHandler? SelectedIndexChanged;
    public event EventHandler<ToggleEventArgs>? PreviewSelectedIndexChanged;

    public TopMenu() {
        InitializeComponent();
    }

    private string[] _menuItems = [];
    public string[] MenuItems {
        get => _menuItems;
        set {
            _menuItems = value;
            GenerateMenu();
        }
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;
        flp.BackColor = ColorScheme.Current.Background;

        foreach (TopMenuItem item in flp.Controls) {
            item.Theme();
        }
    }

    private void GenerateMenu() {
        if (_menuItems is null) return;

        flp.Controls.Clear();

        for (int i = 0; i < _menuItems.Length; i++) {
            string itemName = _menuItems[i];
            TopMenuItem menuItem = new() {
                Text = itemName,
                Width = Width / _menuItems.Length,
                Height = Height,
                Margin = new Padding(0, 0, 0, 0),
            };

            int valueToSelect = i;
            menuItem.Click += (s, e) => {
                SelectedIndex = valueToSelect;
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
            if (value == _selectedIndex) return;

            ToggleEventArgs e = new();
            PreviewSelectedIndexChanged?.Invoke(this, e);

            if (e.Handled) return;

            ((TopMenuItem)flp.Controls[_selectedIndex]).Selected = false;

            _selectedIndex = value;

            ((TopMenuItem)flp.Controls[_selectedIndex]).Selected = true;

            SelectedIndexChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
