using a2_coursework.Presenter;
using a2_coursework.Theming;
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

    public void GenerateMenu(string[][] menuItems) { 
        sideMenu.GenerateMenu(menuItems);
    }

    private Form? _childForm;
    public Form? ChildForm {
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

    public void DisplayChildForm(Form childForm) {
        // Remove the previous child form
        pnlHolder.Controls.Clear();
        if (ChildForm is not null) {
            ChildForm.MouseWheel -= OnChildMouseWheel;
            ChildForm.Dispose();
        }

        ChildForm = childForm;

        // Setup the child form to be displayed
        childForm.TopLevel = false;
        childForm.Width = pnlHolder.Width;
        childForm.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        ChildForm.MouseWheel += OnChildMouseWheel;

        // Display the form
        pnlHolder.Controls.Add(childForm);
        childForm.Show();

        SetScrollOptions();
    }

    private void SetScrollOptions() {
        if (ChildForm is null) return;

        if (pnlHolder.Height < ChildForm.Height) {
            sb.Visible = true;
            sb.LargeChange = pnlHolder.Height;
            sb.Maximum = ChildForm.Height - pnlHolder.Height;
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
        if (ChildForm is null) return;

        ChildForm.Location = new Point(0, -sb.Value);
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);
        SetScrollOptions();

        if (ChildForm is not null) topBar.UsernameText = $"{pnlHolder.Height}, {ChildForm.Height}";
    }

    protected override void OnDockChanged(EventArgs e) {
        SetScrollOptions();

        if (ChildForm is not null) topBar.UsernameText = $"{pnlHolder.Height}, {ChildForm.Height}";

        base.OnDockChanged(e);
    }

    private void MasterView_Shown(object sender, EventArgs e) {
        pnlCover.Visible = false;
    }
}
