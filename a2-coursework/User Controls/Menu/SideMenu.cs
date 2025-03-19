using a2_coursework._Helpers;
using a2_coursework.Theming;

namespace a2_coursework.UserControls.SideMenu;
public partial class SideMenu : UserControl {
    public SideMenu(string[][] items) {
        InitializeComponent();

        GenerateMenu(items);
    }

    public event EventHandler<ToggleEventArgs>? PreviewSideMenuToggleChanged;
    public event EventHandler? SideMenuToggleChanged;
    public event EventHandler? DropdownToggleChanged;
    public event EventHandler<MenuToggleButton>? SideMenuButtonToggleUpdated;

    public SideMenu() {
        InitializeComponent();
    }

    public void Theme() {
        foreach (Control control in pnlMenuHolder.Controls) {
            if (control is MenuDropdown dropdown) {
                dropdown.Theme();
            }
            else if (control is MenuToggleButton toggle) {
                toggle.Theme();
            }
        }

        BackColor = ColorScheme.Current.Background;
        pnlHolder.BackColor = ColorScheme.Current.Background;
        pnlMenuHolder.BackColor = ColorScheme.Current.Background;
        pnlDecor.BackColor = ColorScheme.Current.Primary;
        sb.Theme();
    }

    public void GenerateMenu(string[][] items) {
        for (int i = items.Length - 1; i >= 0; i--) {
            if (items[i].Length == 1) {
                MenuToggleButton btn = new() { Text = items[i][0], Dock = DockStyle.Top };
                btn.ToggleChanged += SideMenuToggleButtonChanged;
                btn.PreviewToggleChanged += (s, e) => PreviewSideMenuToggleChanged?.Invoke(s, e);
                pnlMenuHolder.Controls.Add(btn);
            }
            else {
                MenuDropdown dropDown = new(items[i][0], items[i][1..]) { Dock = DockStyle.Top };
                dropDown.DropDownItemToggleChanged += SideMenuToggleButtonChanged;
                dropDown.DropDownToggleChanged += OnDropdownToggleChanged;
                dropDown.PreviewDropDownItemToggleChanged += (s, e) => PreviewSideMenuToggleChanged?.Invoke(s, e);
                pnlMenuHolder.Controls.Add(dropDown);
            }
        }

        SetupSizeAndScroll();
    }

    public void SetToggledName(string name, bool toggled) {
        foreach (Control ctrl in pnlMenuHolder.Controls) {
            if (ctrl is MenuToggleButton button) {
                if (button.Text == name) {
                    button.Toggled = toggled;
                    return;
                }
            }
            else if (ctrl is MenuDropdown dropdown) {
                foreach (MenuToggleButton internalButton in dropdown.ToggleButtons) {
                    if (internalButton.Text == name) {
                        internalButton.Toggled = toggled;
                        return;
                    }
                }
            }
            else throw new NotImplementedException("side menus can only contain toggles and dropdowns");
        }
    }

    private void OnDropdownToggleChanged(object? sender, EventArgs e) {
        DropdownToggleChanged?.Invoke(sender, e);
        SetupSizeAndScroll();
    }

    private void SideMenuToggleButtonChanged(object? sender, EventArgs e) {
        ToggleButton btn = (ToggleButton)sender!;

        // Check if any have been changed
        bool anyToggled = false;
        foreach (Control control in pnlMenuHolder.Controls) {
            if (control is MenuToggleButton button) {
                anyToggled |= button.Toggled;
            }
            else if (control is MenuDropdown dropdown) {
                foreach (MenuToggleButton internalButton in dropdown.ToggleButtons) {
                    anyToggled |= internalButton.Toggled;
                }
            }
            else throw new NotImplementedException("side menus can only contain toggles and dropdowns");
        }

        // If none are toggled toggle the one that was just toggled while not firing the event
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
            if (control is MenuToggleButton button) {
                if (button.ToggleButton != btn) {
                    button.Toggled = false;
                }
            }
            else if (control is MenuDropdown dropdown) {
                foreach (MenuToggleButton internalButton in dropdown.ToggleButtons) {
                    if (internalButton.ToggleButton != btn) {
                        internalButton.Toggled = false;
                    }
                }
            }
            else throw new NotImplementedException("side menus can only contain toggles and dropdowns");
        }

        SetupSizeAndScroll();
        SideMenuToggleChanged?.Invoke(btn, EventArgs.Empty);
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
        if (pnlHolder.Height < pnlMenuHolder.Height) sb.Value -= e.Delta;
        Update();

        base.OnMouseWheel(e);
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        SetupSizeAndScroll();
    }

    protected override void OnFontChanged(EventArgs e) {
        base.OnFontChanged(e);

        foreach (Control ctrl in pnlMenuHolder.Controls) {
            ctrl.SetFontName(Font.Name);
        }
    }
}


