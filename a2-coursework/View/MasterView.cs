using a2_coursework.Presenter;
using a2_coursework.Theming;
using a2_coursework.UserControls;
using a2_coursework.UserControls.SideMenu;
using a2_coursework.View.Interfaces;

namespace a2_coursework.View;
public partial class MasterView : Form, IMaster {
    private MasterPresenter? _presenter;

    public MasterView() {
        InitializeComponent();

        pnlCover.BackColor = ColorScheme.CurrentTheme.Background;

        Theme();
        Theming.Theme.AppearanceThemeChanged += (s, e) => Theme();
    }

    public void SetPresenter(MasterPresenter presenter) {
        _presenter = presenter;
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        sideMenu.Theme();
        topBar.Theme();
        sb.Theme();
    }

    private void MasterView_Shown(object sender, EventArgs e) {
        pnlCover.Visible = false;
    }

    #region Interface members
    public void GenerateMenu(string[][] menuItems) {
        sideMenu.GenerateMenu(menuItems);
    }

    private IChildView? _childForm;
    public IChildView? ChildView {
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

    #endregion

    #region Scrolling

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
        sb.Value -= e.Delta;
        Update();
    }

    private void sb_ValueChanged(object sender, EventArgs e) {
        if (ChildView is null) return;

        ChildView.Location = new Point(0, -sb.Value);
    }

    #endregion

    #region Sizing

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);
        SetScrollOptions();

        if (ChildView is not null) ChildView.Width = pnlHolder.Width;
    }

    protected override void OnDockChanged(EventArgs e) {
        SetScrollOptions();
        base.OnDockChanged(e);
    }

    #endregion

    #region Navigation

    public void DisplayChildForm(IChildView childView) {
        // Remove the previous child form
        pnlHolder.Controls.Clear();
        if (ChildView is not null) {
            ChildView.MouseWheel -= OnChildMouseWheel;
            ChildView.Dispose();
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
        if (((ToggleButton)sender).Toggled == true) return;

        if (!ChildView?.CanExit() ?? false) e.Handled = true;
    }

    private void sideMenu_SideMenuToggleChanged(object sender, EventArgs e) {
        IChildView nextView = _presenter!.GetToggledView(((ToggleButton)sender).Text);

        DisplayChildForm(nextView);
    }

    #endregion
}
