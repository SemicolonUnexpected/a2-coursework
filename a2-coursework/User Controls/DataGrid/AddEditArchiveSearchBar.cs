using a2_coursework.Theming;
using System.ComponentModel;

namespace a2_coursework.User_Controls.DataGrid;
public partial class AddEditArchiveSearchBar : UserControl, IThemeable {
    public event EventHandler? SearchTextChanged;
    public event EventHandler? Search;
    public event EventHandler? Edit;
    public event EventHandler? ArchiveToggled;
    public event EventHandler? Add;
    public event EventHandler? ShowArchivedToggled;

    public AddEditArchiveSearchBar() {
        InitializeComponent();

        toolTip.SetToolTip(btnArchive, _restore ? "Restore" : "Archive");
        toolTip.SetToolTip(btnShowArchived, _showArchived ? "Hide archived" : "Show archived");

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
        btnArchive.Image = _restore ? IconTheme.CurrentTheme.Restore : IconTheme.CurrentTheme.Archive;
        btnShowArchived.ThemeWeak();
        btnShowArchived.Image = _showArchived ? IconTheme.CurrentTheme.OpenBox : IconTheme.CurrentTheme.ClosedBox;
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

    public bool ShowArchivedEnabled {
        get => btnShowArchived.Enabled;
        set => btnShowArchived.Enabled = value;
    }

    public bool SearchEnabled {
        get => tbSearch.Enabled;
        set {
            tbSearch.Enabled = value;
            pbSearchBtn.Enabled = value;
            btnClear.Enabled = value;
        }
    }

    private bool _restore = false;
    [DefaultValue(false)]
    public bool Restore {
        get => _restore;
        set {
            _restore = value;

            btnArchive.Image = _restore ? IconTheme.CurrentTheme.Restore : IconTheme.CurrentTheme.Archive;
            toolTip.SetToolTip(btnArchive, _restore ? "Restore" : "Archive");
        }
    }

    private bool _showArchived = false;
    [DefaultValue(false)]
    public bool ShowArchived {
        get => _showArchived;
        set {
            _showArchived = value;

            btnShowArchived.Image = _showArchived ? IconTheme.CurrentTheme.OpenBox : IconTheme.CurrentTheme.ClosedBox;
            toolTip.SetToolTip(btnShowArchived, _showArchived ? "Hide archived" : "Show archived");
        }
    }

    private void btnAdd_Click(object sender, EventArgs e) => Add?.Invoke(this, EventArgs.Empty);

    private void btnEdit_Click(object sender, EventArgs e) => Edit?.Invoke(this, EventArgs.Empty);

    private void btnArchive_Click(object sender, EventArgs e) {
        Restore = !Restore;
        ArchiveToggled?.Invoke(this, EventArgs.Empty);
    }

    private void btnShowArchived_Click(object sender, EventArgs e) {
        ShowArchived = !ShowArchived;
        ShowArchivedToggled?.Invoke(this, EventArgs.Empty);
    }

    private void tbSearch_TextChanged(object sender, EventArgs e) {
        SearchTextChanged?.Invoke(this, EventArgs.Empty);

        if (tbSearch.Text.Length > 0) {
            btnClear.Location = new Point(tbSearch.Width + Padding.Left - btnClear.Width - btnClear.Margin.Right, (Height - btnClear.Height) / 2);
            btnClear.Visible = true;
        }
        else btnClear.Visible = false;
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
