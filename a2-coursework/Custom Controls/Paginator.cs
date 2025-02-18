using a2_coursework.Theming;

namespace a2_coursework.CustomControls;
public partial class Paginator : UserControl {
    public event EventHandler? PageChanged;

    public Paginator() {
        InitializeComponent();

        Theme();
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        btnFirst.ThemeWeak();
        btnLast.ThemeWeak();
        btnPrevious.ThemeWeak();
        btnNext.ThemeWeak();

        btnFirst.Image = IconTheme.CurrentTheme.DoubleBackArrow;
        btnLast.Image = IconTheme.CurrentTheme.DoubleForwardArrow;
        btnPrevious.Image = IconTheme.CurrentTheme.BackArrow;
        btnNext.Image = IconTheme.CurrentTheme.ForwardArrow;

        lblGoToPage.ThemeTitle();
        lblNumber.ThemeTitle();

        tbPage.Theme();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        toolTip.Active = showToolTips;
    }

    private int _numberOfPages = 1;
    public int NumberOfPages {
        get => _numberOfPages;
        set {
            _numberOfPages = Math.Max(value, 1);

            lblNumber.Text = "of " + _numberOfPages;
        }
    }

    private int _currentPage;
    public int CurrentPageNumber {
        get => _currentPage;
        set {
            if (_currentPage == value) return;

            _currentPage = Math.Clamp(value, 1, _numberOfPages);

            tbPage.Text = _currentPage.ToString();

            PageChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    private void btnFirst_Click(object sender, EventArgs e) {
        CurrentPageNumber = 1;
        ClearFocus();
    }

    private void btnPrevious_Click(object sender, EventArgs e) {
        CurrentPageNumber = Math.Max(1, CurrentPageNumber - 1);
        ClearFocus();
    }

    private void btnLast_Click(object sender, EventArgs e) {
        CurrentPageNumber = NumberOfPages;
        ClearFocus();
    }

    private void btnNext_Click(object sender, EventArgs e) {
        CurrentPageNumber = Math.Min(NumberOfPages, CurrentPageNumber + 1);
        ClearFocus();
    }

    private void tbPage_KeyPress(object sender, KeyPressEventArgs e) {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;

        if (e.KeyChar == 13) {
            bool valid = int.TryParse(tbPage.Text, out int page);

            if (!valid) tbPage.Text = _currentPage.ToString();

            CurrentPageNumber = Math.Clamp(1, NumberOfPages, page);
        }
    }

    private void tbPage_Leave(object sender, EventArgs e) {
        bool valid = int.TryParse(tbPage.Text, out int page);

        if (!valid) tbPage.Text = _currentPage.ToString();

        CurrentPageNumber = Math.Clamp(1, NumberOfPages, page);
    }

    private void Paginator_Click(object sender, EventArgs e) {
        ClearFocus();
    }

    public void ClearFocus() {
        tbFocusHolder.Focus();
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);
        pnlInfo.Location = new Point((Width - pnlInfo.Width) / 2, Padding.Top);
    }
}
