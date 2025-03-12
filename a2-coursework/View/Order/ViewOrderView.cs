using a2_coursework._Helpers;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Order;
using a2_coursework.Theming;
using a2_coursework.UserControls;

namespace a2_coursework.View.Order;
public partial class ViewOrderView : Form, IThemeable, IViewOrderView {
    public event EventHandler<string>? SelectedMenuItemChanged;
    public event EventHandler<ToggleEventArgs>? PreviewSelectedMenuItemChanged;
    public event EventHandler? Back;

    public ViewOrderView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        topMenu.PreviewSelectedIndexChanged += (s, e) => PreviewSelectedMenuItemChanged?.Invoke(this, e);
        topMenu.SelectedIndexChanged += (s, e) => SelectedMenuItemChanged?.Invoke(this, topMenu.MenuItems[topMenu.SelectedIndex]);
        btnBack.Click += (s, e) => Back?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;
        pnlHolder.BackColor = ColorScheme.Current.Background;
        pnlMenu.BackColor = ColorScheme.Current.Background;

        topMenu.Theme();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        toolTip.Active = showToolTips;
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        topMenu.SetFontName(fontName);
    }

    private IChildView? _childView;
    public void DisplayChildView(IChildView childView) {
        // Remove the previous child form
        pnlHolder.Controls.Clear();

        _childView = childView;

        // Setup the child form to be displayed
        _childView.TopLevel = false;
        _childView.Width = pnlHolder.Width;
        _childView.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        _childView.Dock = DockStyle.Fill;

        // Display the form
        pnlHolder.Controls.Add(_childView as Form);
        _childView.Show();
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.FontNameChanged -= SetFont;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        topMenu.Location = new Point(Math.Max(btnBack.Width + btnBack.Location.X + btnBack.Margin.Right, (pnlMenu.Width - topMenu.Width) / 2), 0);
        topMenu.Height = pnlMenu.Height;
    }
}
