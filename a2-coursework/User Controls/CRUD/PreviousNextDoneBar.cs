using a2_coursework.Theming;

namespace a2_coursework.User_Controls.CRUD;
public partial class PreviousNextDoneBar : UserControl, IThemeable {
    public event EventHandler? Previous;
    public event EventHandler? Next;
    public event EventHandler? Done;

    public PreviousNextDoneBar() {
        InitializeComponent();

        Theme();
        SetToolTipVisibility();
        SetFont();
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        pnlSpacer1.BackColor = ColorScheme.Current.Background;
        pnlSpacer2.BackColor = ColorScheme.Current.Background;

        btnBack.ThemeWeak();
        btnBack.Image = IconTheme.Current.BackArrow;

        btnNext.ThemeWeak();
        btnNext.Image = IconTheme.Current.ForwardArrow;

        btnDone.ThemeWeak();
        btnDone.Image = IconTheme.Current.Tick;
    }

    public void SetToolTipVisibility() {
        bool showToolTip = Theming.Theme.Current.ShowToolTips;

        toolTip.Active = showToolTip;
    }

    public void SetFont() { }

    private void btnNext_Click(object sender, EventArgs e) => Next?.Invoke(this, EventArgs.Empty);
    private void btnBack_Click(object sender, EventArgs e) => Previous?.Invoke(this, EventArgs.Empty);
    private void btnDone_Click(object sender, EventArgs e) => Done?.Invoke(this, EventArgs.Empty);

    public bool PreviousVisible {
        get => btnBack.Visible;
        set => btnBack.Visible = value;
    }

    public bool NextVisible {
        get => btnNext.Visible;
        set {
            btnNext.Visible = value;
            pnlSpacer1.Visible = value;
        }
    }

    public bool DoneVisible {
        get => btnDone.Visible;
        set {
            btnDone.Visible = value;
            pnlSpacer2.Visible = value;
        }
    }
}
