using a2_coursework._Helpers;
using a2_coursework.CustomControls;
using a2_coursework.Interfaces;
using a2_coursework.Theming;

namespace a2_coursework.View.Order;
public partial class ViewCleaningJobView : Form, IThemeable, IViewCleaningJobView {
    public event EventHandler<string>? SelectedMenuItemChanged;

    public event EventHandler? Back;

    public ViewCleaningJobView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

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

    private bool _isLoading = false;
    public bool IsLoading {
        get => _isLoading;
        set {
            _isLoading = value;

            topMenu.Enabled = !_isLoading;
            pnlHolder.Enabled = !_isLoading;
        }
    }

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK) => CustomMessageBox.Show(text, caption, buttons);

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
