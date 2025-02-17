using a2_coursework._Helpers;
using a2_coursework.CustomControls;
using a2_coursework.Interfaces;
using a2_coursework.Theming;
using a2_coursework.UserControls;
using a2_coursework.UserControls.SideMenu;

namespace a2_coursework.View;
public partial class MasterView : Form, IMasterView, IThemeable {
    public event EventHandler<ToggleEventArgs>? PreviewToggleChanged;
    public event EventHandler<string>? ToggleChanged;
    public event EventHandler? SignOut;

    public MasterView() {
        InitializeComponent();

        pnlCover.BackColor = ColorScheme.CurrentTheme.Background;

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        topBar.SignOut += (s, e) => SignOut?.Invoke(this, EventArgs.Empty);
        sideMenu.SideMenuToggleChanged += (s, e) => ToggleChanged?.Invoke(this, ((ToggleButton)s!).Text);
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        sideMenu.Theme();
        topBar.Theme();
    }

    public void SetToolTipVisibility() { }

    public void SetFont() {
        string fontName = Theming.Theme.CurrentTheme.FontName;

        topBar.SetFontName(fontName);
        sideMenu.SetFontName(fontName);
    }

    private void MasterView_Shown(object sender, EventArgs e) {
        pnlCover.Visible = false;
    }

    public void GenerateMenu(string[][] menuItems) => sideMenu.GenerateMenu(menuItems);

    private IChildView? _childView;
    public IChildView? ChildView {
        get => _childView;
        set => _childView = value;
    }

    public string UsernameText {
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


    public void DisplayChildView(IChildView childView) {
        // Remove the previous child form
        pnlHolder.Controls.Clear();

        ChildView = childView;

        // Setup the child form to be displayed
        ChildView.TopLevel = false;
        ChildView.Width = pnlHolder.Width;
        ChildView.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        ChildView.Dock = DockStyle.Fill;

        // Display the form
        pnlHolder.Controls.Add(ChildView as Form);
        ChildView.Show();
    }

    private void sideMenu_PreviewSideMenuToggleChanged(object sender, ToggleEventArgs e) {
        if (((ToggleButton)sender).Toggled == true) {
            e.Handled = true;
            return;
        }

        PreviewToggleChanged?.Invoke(this, e);
    }

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK) {
        return CustomMessageBox.Show(text, caption, buttons);
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
