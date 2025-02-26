using a2_coursework._Helpers;
using a2_coursework.Theming;
using System.ComponentModel;

namespace a2_coursework.User_Controls.DataGrid;
public partial class AddEditDeleteSearchBar : UserControl, IThemeable {
    public event EventHandler? SearchTextChanged;
    public event EventHandler? Search;
    public event EventHandler? Edit;
    public event EventHandler? Add;
    public event EventHandler? Delete;

    public AddEditDeleteSearchBar() {
        InitializeComponent();

        Theme();
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        tbSearch.Theme();

        btnAdd.ThemeWeak();
        btnAdd.Image = IconTheme.Current.Plus;
        btnEdit.ThemeWeak();
        btnEdit.Image = IconTheme.Current.Edit;
        btnDelete.ThemeWeak();
        btnDelete.Image = IconTheme.Current.Delete;
        btnClear.ThemeWeak();
        btnClear.Image = IconTheme.Current.Cross;
        pbSearchBtn.Image = IconTheme.Current.Search;
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

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

    public bool DeleteEnabled {
        get => btnDelete.Enabled;
        set => btnDelete.Enabled = value;
    }

    public bool SearchEnabled {
        get => tbSearch.Enabled;
        set {
            tbSearch.Enabled = value;
            pbSearchBtn.Enabled = value;
            btnClear.Enabled = value;
        }
    }

    private void btnAdd_Click(object sender, EventArgs e) => Add?.Invoke(this, EventArgs.Empty);

    private void btnEdit_Click(object sender, EventArgs e) => Edit?.Invoke(this, EventArgs.Empty);

    private void btnArchive_Click(object sender, EventArgs e) => Delete?.Invoke(this, EventArgs.Empty);

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

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        tbSearch.SetFontName(fontName);
    }
}
