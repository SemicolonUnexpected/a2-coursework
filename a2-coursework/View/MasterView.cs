using a2_coursework._Helpers;
using a2_coursework.Presenter;
using a2_coursework.Theming;
using a2_coursework.UserControls;
using a2_coursework.UserControls.SideMenu;
using a2_coursework.View.Interfaces;

namespace a2_coursework.View;
public partial class MasterView : Form, IMasterView {
    public event EventHandler<string>? ToggleChanged;
    public event EventHandler? SignOut;

    public MasterView() {
        InitializeComponent();

        pnlCover.BackColor = ColorScheme.CurrentTheme.Background;

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += (s, e) => SetFont();

        topBar.SignOut += (s, e) => SignOut?.Invoke(this, EventArgs.Empty);
        sideMenu.SideMenuToggleChanged += (s, e) => ToggleChanged?.Invoke(this, ((ToggleButton)s!).Text);

    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        sideMenu.Theme();
        topBar.Theme();
        sb.Theme();
    }

    private void SetFont() {
        string fontName = Theming.Theme.CurrentTheme.FontName;

        topBar.SetFontName(fontName);
        sideMenu.SetFontName(fontName);
    }

    private void MasterView_Shown(object sender, EventArgs e) {
        pnlCover.Visible = false;
    }

    public void GenerateMenu(string[][] menuItems) => sideMenu.GenerateMenu(menuItems);

    private IMasterChildView? _childForm;
    public IMasterChildView? ChildView {
        get => _childForm;
        set => _childForm = value;
    }

    public string UsernameText {
        get => topBar.UsernameText;
        set => topBar.UsernameText = value;
    }

    public void SetSideMenuToggledIndex(int i, int j, bool toggled) {
        if (sideMenu[i] is MenuToggleButton menuToggleButton) {
            menuToggleButton.Toggled = toggled;
        }
        else if (sideMenu[i] is MenuDropdown dropdown) {
            dropdown.ToggleButtons[j].Toggled = toggled;
        }
    }

    private void SetScrollOptions() {
        if (ChildView is null) return;

        if (pnlHolder.Height < ChildView.Height) {
            sb.Visible = true;
            sb.LargeChange = pnlHolder.Height;
            sb.Maximum = ChildView.Height - pnlHolder.Height;
        }
        else {
            sb.Visible = false;
            sb.Value = 0;
        }
    }

    private void OnChildMouseWheel(object? sender, MouseEventArgs e) {
        if (ChildView is null) return;

        if (pnlHolder.Height < ChildView.Height) sb.Value -= e.Delta;
        Update();
    }

    private void sb_ValueChanged(object sender, EventArgs e) {
        if (ChildView is null) return;

        ChildView.Location = new Point(0, -sb.Value);
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);
        SetScrollOptions();

        if (ChildView is not null) ChildView.Width = pnlHolder.Width;
    }

    public void DisplayChildForm(IMasterChildView childView) {
        // Remove the previous child form
        pnlHolder.Controls.Clear();
        if (ChildView is not null) {
            ChildView.MouseWheel -= OnChildMouseWheel;
        }

        ChildView = childView;

        // Setup the child form to be displayed
        ChildView.TopLevel = false;
        ChildView.Width = pnlHolder.Width;
        ChildView.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        ChildView.MouseWheel += OnChildMouseWheel;
        if (ChildView.DockInParent) ChildView.Dock = DockStyle.Fill;

        // Display the form
        pnlHolder.Controls.Add(ChildView as Form);
        ChildView.Show();

        SetScrollOptions();
    }

    private void sideMenu_PreviewSideMenuToggleChanged(object sender, ToggleEventArgs e) {
        if (((ToggleButton)sender).Toggled == true) {
            e.Handled = true;
            return;
        }

        if (!ChildView?.CanExit() ?? false) e.Handled = true;
    }
}
