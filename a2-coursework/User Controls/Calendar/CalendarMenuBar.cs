using a2_coursework.Theming;

namespace a2_coursework.UserControls.Calendar; 
public partial class CalendarMenuBar : UserControl {
    public CalendarMenuBar() {
        InitializeComponent();
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        tbSearch.Theme();
        btnAdd.ThemeWeak();
        btnNavigate.ThemeWeak();
        btnBack.ThemeWeak();
        btnForward.ThemeWeak();

        btnAdd.Image = IconTheme.CurrentTheme.Plus;
        btnNavigate.Image = IconTheme.CurrentTheme.Navigation;
        btnForward.Image = IconTheme.CurrentTheme.ForwardArrow;
        btnBack.Image = IconTheme.CurrentTheme.BackArrow;
    }

    public event EventHandler<string>? Search;
    public event EventHandler? Add;
    public event EventHandler? Navigate;
    public event EventHandler? Forward;
    public event EventHandler? Backward;

    public bool BarEnabled {
        get => tbSearch.Enabled;
        set {
            tbSearch.Enabled = value;
            pbSearchBtn.Enabled = value;
            btnAdd.Enabled = value;
            btnNavigate.Enabled = value;
            btnForward.Enabled = value;
            btnBack.Enabled = value;
        }
    }

    private void tbSearch_KeyPress(object sender, KeyPressEventArgs e) {
        // If enter is pressed in the search box, invoke the search method
        if (e.KeyChar == (char)13) Search?.Invoke(sender, tbSearch.Text);
    }

    private void pbSearchBtn_Click(object sender, EventArgs e) {
        Search?.Invoke(sender, tbSearch.Text);
    }

    private void btnAdd_Click(object sender, EventArgs e) {
        Add?.Invoke(sender, e);
    }

    private void btnNavigate_Click(object sender, EventArgs e) {
        Navigate?.Invoke(sender, e);
    }

    private void btnBack_Click(object sender, EventArgs e) {
        Backward?.Invoke(sender, e);
    }

    private void btnForward_Click(object sender, EventArgs e) {
        Forward?.Invoke(sender, e);
    }
}
