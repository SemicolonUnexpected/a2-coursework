using a2_coursework.Theming;

namespace a2_coursework.User_Controls.CRUD;
public partial class BackNextDoneBar : UserControl, IThemeable {
    public event EventHandler? Back;
    public event EventHandler? Next;
    public event EventHandler? Done;

    public BackNextDoneBar() {
        InitializeComponent();

        Theme();
        SetToolTipVisibility();
        SetFont();
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        pnlSpacer1.BackColor = ColorScheme.CurrentTheme.Background;
        pnlSpacer2.BackColor = ColorScheme.CurrentTheme.Background;

        btnBack.ThemeWeak();
        btnNext.ThemeWeak();
        btnDone.ThemeWeak();
    }

    public void SetToolTipVisibility() {
        bool showToolTip = Theming.Theme.CurrentTheme.ShowToolTips;

        toolTip.Active = showToolTip;
    }

    public void SetFont() { }

    private void btnNext_Click(object sender, EventArgs e) => Next?.Invoke(this, EventArgs.Empty);
    private void btnBack_Click(object sender, EventArgs e) => Back?.Invoke(this, EventArgs.Empty);
    private void btnDone_Click(object sender, EventArgs e) => Done?.Invoke(this, EventArgs.Empty);

    public bool ShowBack {
        get => btnBack.Visible;
        set => btnBack.Visible = value;
    }

    public bool ShowNext {
        get => btnNext.Visible;
        set {
            btnNext.Visible = value;
            pnlSpacer1.Visible = value;
        }
    }

    public bool ShowDone {
        get => btnDone.Visible;
        set {
            btnDone.Visible = value;
            pnlSpacer2.Visible = value;
        }
    }
}
