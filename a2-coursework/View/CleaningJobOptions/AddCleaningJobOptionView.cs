using a2_coursework._Helpers;
using a2_coursework.CustomControls;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.CleaningJobOption;
using a2_coursework.Theming;

namespace a2_coursework.View.CleaningJob; 
public partial class AddCleaningJobOptionView : Form, IAddCleaningJobOptionView, IThemeable, IChildView {
    public event EventHandler? Next;
    public event EventHandler? Previous;
    public event EventHandler? Done;
    public event EventHandler? Back;

    public AddCleaningJobOptionView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        btnBack.Click += (s, e) => Back?.Invoke(this, EventArgs.Empty);
        previousNextDoneBar.Next += (s, e) => Next?.Invoke(this, EventArgs.Empty);
        previousNextDoneBar.Previous += (s, e) => Previous?.Invoke(this, EventArgs.Empty);
        previousNextDoneBar.Done += (s, e) => Done?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;
        pnlHolder.BackColor = ColorScheme.Current.Background;
        pnlTop.BackColor = ColorScheme.Current.Background;
        lblTitle.ThemeTitle();
        previousNextDoneBar.Theme();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        previousNextDoneBar.SetToolTipVisibility();
        toolTip.Active = showToolTips;
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblTitle.SetFontName(fontName);
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
        lblTitle.Text = _childView.Text;

        // Display the form
        pnlHolder.Controls.Add(_childView as Form);
        _childView.Show();
    }

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK) => CustomMessageBox.Show(text, caption, buttons);

    private bool _isLoading = false;
    public bool IsLoading {
        get => _isLoading;
        set {
            _isLoading = value;

            previousNextDoneBar.Enabled = !_isLoading;
            pnlHolder.Enabled = !_isLoading;
        }
    }

    public bool NextVisible {
        get => previousNextDoneBar.NextVisible;
        set => previousNextDoneBar.NextVisible = value;
    }

    public bool PreviousVisible {
        get => previousNextDoneBar.PreviousVisible;
        set => previousNextDoneBar.PreviousVisible = value;
    }

    public bool DoneVisible {
        get => previousNextDoneBar.DoneVisible;
        set => previousNextDoneBar.DoneVisible = value;
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.FontNameChanged -= SetFont;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
    }
}
