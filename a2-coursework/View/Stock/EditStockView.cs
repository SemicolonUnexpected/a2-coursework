using a2_coursework._Helpers;
using a2_coursework.CustomControls;
using a2_coursework.Theming;
using a2_coursework.UserControls;
using a2_coursework.View.Interfaces;
using a2_coursework.View.Interfaces.Stock;

namespace a2_coursework.View.Stock; 
public partial class EditStockView : Form, IEditStockView {
    public event EventHandler? SelectedMenuItemChanged;
    public event EventHandler<ToggleEventArgs>? PreviewSelectedMenuItemChanged;
    public event EventHandler? Save;
    public event EventHandler? Cancel;

    public EditStockView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        topMenu.SelectedIndexChanged += (s, e) => SelectedMenuItemChanged?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;
        pnlHolder.BackColor = ColorScheme.CurrentTheme.Background;
        pnlMenu.BackColor = ColorScheme.CurrentTheme.Background;
        topMenu.Theme();
        approveChangesBar.Theme();
    }

    public void SetFont() {
        string fontName = Theming.Theme.CurrentTheme.FontName;

        approveChangesBar.SetFontName(fontName);
        topMenu.SetFontName(fontName);
    }

    private IChildView? _childView;
    public void DisplayView(IChildView childView) {
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

    public string SelectedMenuItem => topMenu.MenuItems[topMenu.SelectedIndex];

    private bool _isLoading = false;
    public bool IsLoading {
        get => _isLoading;
        set {
            _isLoading = value;

            topMenu.Enabled = !_isLoading;
            approveChangesBar.IsLoading = _isLoading;
        }
    }

    public bool SaveCancelVisible {
        get => approveChangesBar.Visible;
        set => approveChangesBar.Visible = value;
    }

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK) {
        return CustomMessageBox.Show(text, caption, buttons);
    }
}
