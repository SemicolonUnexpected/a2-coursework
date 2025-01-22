using a2_coursework.Theming;

namespace a2_coursework.UserControls.SideMenu; 
public partial class SideMenu : UserControl {
    public SideMenu(string[][] items) {
        InitializeComponent();

        GenerateMenu(items);
    }

    public event EventHandler<string>? SideMenuToggleUpdated;
    public event EventHandler<string>? DropdownToggleChanged;
    public event EventHandler<SideMenuToggleButton>? SideMenuButtonToggleUpdated;

    public SideMenu() {
        InitializeComponent();
    }

    public void Theme() {
        foreach (Control control in pnlMenuHolder.Controls) {
            if (control is MenuDropdown dropdown) {
                dropdown.Theme();
            }
            else if (control is SideMenuToggleButton toggle) {
                toggle.Theme();
            }
        }

        BackColor = ColorScheme.CurrentTheme.Background;
        pnlHolder.BackColor = ColorScheme.CurrentTheme.Background;
        pnlMenuHolder.BackColor = ColorScheme.CurrentTheme.Background;
        pnlDecor.BackColor = ColorScheme.CurrentTheme.Primary;
        sb.Theme();
    }

    public void GenerateMenu(string[][] items) {
        for (int i = items.Length - 1; i >= 0; i--) {
            if (items[i].Length == 1) {
                SideMenuToggleButton btn = new() { Text = items[i][0], Dock = DockStyle.Top };
                btn.ToggleChanged += SideMenuToggleButtonChanged;
                pnlMenuHolder.Controls.Add(btn);
            }
            else {
                MenuDropdown dropDown = new(items[i][0], items[i][1..]) { Dock = DockStyle.Top };
                dropDown.DropDownItemToggleChanged += SideMenuToggleButtonChanged;
                dropDown.DropDownToggleChanged += OnDropdownToggleChanged;
                pnlMenuHolder.Controls.Add(dropDown);
            }
        }

        SetupSizeAndScroll();
    }


    private void OnDropdownToggleChanged(object? sender, EventArgs e) {
        DropdownToggleChanged?.Invoke(sender, ((MenuDropdown)sender!).ParentName);
        SetupSizeAndScroll() ;
    }

    private void SideMenuToggleButtonChanged(object? sender, EventArgs e) {
        ToggleButton btn = (ToggleButton)sender!;

        // Check if any have been changed
        bool anyToggled = false;
        foreach (Control control in pnlMenuHolder.Controls) {
            if (control is SideMenuToggleButton button) {
                anyToggled |= button.Toggled;
            }
            else if (control is MenuDropdown dropdown) {
                foreach (SideMenuToggleButton internalButton in dropdown.ToggleButtons) {
                    anyToggled |= internalButton.Toggled; 
                }
            }
            else throw new NotImplementedException("side menus can only contain toggles and dropdowns");
        }

        // If none are toggled retoggle the one that was just toggled while not firing the event
        if (!anyToggled) {
            btn.ToggleChanged -= SideMenuToggleButtonChanged;
            btn.Toggled = true;
            btn.ToggleChanged += SideMenuToggleButtonChanged;
            return;
        }

        // If a button is not toggled, exit
        if (!btn.Toggled) {
            return;
        }

        // Clear all toggled buttons
        foreach (Control control in pnlMenuHolder.Controls) {
            if (control is SideMenuToggleButton button) {
                if (button.ToggleButton != btn) {
                    button.Toggled = false;
                }
            }
            else if (control is MenuDropdown dropdown) {
                foreach (SideMenuToggleButton internalButton in dropdown.ToggleButtons) {
                    if (internalButton.ToggleButton != btn) {
                        internalButton.Toggled = false;
                    }
                }
            }
            else throw new NotImplementedException("side menus can only contain toggles and dropdowns");
        }

        SetupSizeAndScroll();
        SideMenuToggleUpdated?.Invoke(this, btn.Text);
    }

    public object this[int i] {
        get => pnlMenuHolder.Controls[pnlMenuHolder.Controls.Count - i - 1];
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
    
    protected override void OnMouseWheel(MouseEventArgs e) {
        sb.Value -= e.Delta;
        Update();

        base.OnMouseWheel(e);
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        SetupSizeAndScroll();
    }
}
