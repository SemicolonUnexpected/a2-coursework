using a2_coursework.Theming;

namespace a2_coursework.User_Controls.DataGrid;
public partial class AddEditArchiveSearchBar : UserControl, IThemeable {
    public event EventHandler? SearchTextChanged;
    public event EventHandler? Search;
    public event EventHandler? Edit;
    public event EventHandler? Archive;
    public event EventHandler? Add;

    public AddEditArchiveSearchBar() {
        InitializeComponent();

        Theme();
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        tbSearch.Theme();

        btnAdd.ThemeWeak();
        btnAdd.Image = IconTheme.CurrentTheme.Plus;
        btnEdit.ThemeWeak();
        btnEdit.Image = IconTheme.CurrentTheme.Edit;
        btnArchive.ThemeWeak();
        btnArchive.Image = IconTheme.CurrentTheme.Archive;
        btnClear.ThemeWeak();
        btnClear.Image = IconTheme.CurrentTheme.Cross;
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.CurrentTheme.ShowToolTips;

        toolTip.Active = showToolTips;
        tbSearch.ToolTipsActive = showToolTips;
    }

    public string SearchText {
        get => tbSearch.Text;
        set => tbSearch.Text = value;
    }

    public bool AddEnabled {
        get => btnAdd.Enabled;
        set => btnAdd.Enabled = value;
    }

    public bool EditEnabled {
        get => btnEdit.Enabled;
        set => btnEdit.Enabled = value;
    }

    public bool ArchiveEnabled {
        get => btnArchive.Enabled;
        set => btnArchive.Enabled = value;
    }

    private void btnAdd_Click(object sender, EventArgs e) => Add?.Invoke(this, EventArgs.Empty);

    private void btnEdit_Click(object sender, EventArgs e) => Edit?.Invoke(this, EventArgs.Empty);

    private void btnArchive_Click(object sender, EventArgs e) => Archive?.Invoke(this, EventArgs.Empty);

    private void tbSearch_TextChanged(object sender, EventArgs e) {
        SearchTextChanged?.Invoke(this, EventArgs.Empty);
        btnClear.Visible = tbSearch.Text.Length > 0;
    }

    private void btnClear_Click(object sender, EventArgs e) => tbSearch.Text = "";

    private void pbSearchBtn_Click(object sender, EventArgs e) => Search?.Invoke(this, EventArgs.Empty);

    private void tbSearch_KeyPress(object sender, KeyPressEventArgs e) {
        if (e.KeyChar == 13) {
            e.Handled = true;
            Search?.Invoke(this, EventArgs.Empty);
        }
    }
}
