using a2_coursework.Theming;

namespace a2_coursework.View;
public partial class DashboardView : Form, IThemeable {
    public event EventHandler? AttemptSignIn;
    public event EventHandler? UsernameChanged;
    public event EventHandler? PasswordChanged;

    public DashboardView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.FontNameChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;
    }

    public void Theme() {
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        toolTip.Active = showToolTips;
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.FontNameChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }

    private void flowLayoutPanel_Resize(object sender, EventArgs e) {
        flowLayoutPanel.Location = new Point(flowLayoutPanel.Location.X, (Width - flowLayoutPanel.Width) / 2);
    }
}
