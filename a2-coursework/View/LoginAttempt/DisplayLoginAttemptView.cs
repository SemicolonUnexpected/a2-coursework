using a2_coursework._Helpers;
using a2_coursework.CustomControls;
using a2_coursework.Interfaces.Staff.StaffManagement;
using a2_coursework.Theming;
using a2_coursework.View.StaffView.StaffManagement;
using System.ComponentModel;

namespace a2_coursework.View.Users;
public partial class DisplayLoginAttemptView : Form, IThemeable {
    private readonly BindingSource _bindingSource = [];

    public event EventHandler? Search;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public DisplayLoginAttemptView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        searchBar.Search += (s, e) => Search?.Invoke(this, EventArgs.Empty);
        searchBar.SearchTextChanged += (s, e) => Search?.Invoke(this, EventArgs.Empty);

        SetupDataGrid();
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblLoginAttempt.ThemeTitle();
        lblError.ThemeSubtitle();

        searchBar.Theme();
        pnlData.Theme();
        dataGridView.Theme();
        sb.Theme();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        foreach (DataGridViewColumn column in dataGridView.Columns) {
            column.ToolTipText = showToolTips ? "Left click to sort ascending\nRight click to sort descending" : "";
        }

        searchBar.SetToolTipVisibility();
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        searchBar.SetFontName(fontName);
        dataGridView.SetFontName(fontName);
        lblLoginAttempt.SetFontName(fontName);
        lblError.SetFontName(fontName);
    }

    private void SetupDataGrid() {
        dataGridView.AutoGenerateColumns = false;

        float scalingFactor = DeviceDpi / 96f;
        dataGridView.ColumnHeadersHeight = (int)(40 * scalingFactor);
        dataGridView.RowTemplate.Height = (int)(30 * scalingFactor);

        dataGridView.MouseWheel += (s, e) => {
            sb.Value -= Math.Sign(e.Delta);
            sb.Refresh();
        };

        SetupDataBindings();
    }

    private void SetupDataBindings() {
        dataGridView.DataSource = _bindingSource;

        _bindingSource.ListChanged += (s, e) => {
            if (e.ListChangedType is ListChangedType.Reset or ListChangedType.ItemAdded or ListChangedType.ItemDeleted) {
                SetScrollOptions();
            }
        };

        columnUsername.DataPropertyName = nameof(DisplayStaffModel.Username);
        columnAttemptTime.DataPropertyName = nameof(DisplayStaffModel.Names);
        columnSuccessful.DataPropertyName = nameof(DisplayStaffModel.Id);
    }

    public string SearchText {
        get => searchBar.SearchText;
        set => searchBar.SearchText = value;
    }

    public DisplayStaffModel? SelectedItem {
        get {
            try {
                return ((BindingList<DisplayStaffModel>)_bindingSource.DataSource)[dataGridView.SelectedRows[0].Index];
            }
            catch (ArgumentOutOfRangeException) {
                return null;
            }
        }
    }
    public string DataGridText {
        get => lblError.Text;
        set {
            lblError.Text = value;
            lblError.Visible = lblError.Text != "";
        }
    }

    public void DisplayItems(BindingList<DisplayStaffModel> items) {
        dataGridView.SuspendLayout();
        _bindingSource.DataSource = items;
        dataGridView.ResumeLayout();
    }

    public void DisableAll() {
        searchBar.Enabled = false;
        dataGridView.Enabled = false;
    }

    public void EnableAll() {
        searchBar.Enabled = true;
        dataGridView.Enabled = true;
    }

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK) => CustomMessageBox.Show(text, caption, buttons);

    private void SetScrollOptions() {
        int numberOfVisibleRows = (dataGridView.Height - dataGridView.ColumnHeadersHeight) / dataGridView.RowTemplate.Height;

        if (dataGridView.RowCount < numberOfVisibleRows) {
            sb.Visible = false;
            return;
        }

        sb.Visible = true;
        sb.Maximum = dataGridView.RowCount - numberOfVisibleRows;
        sb.LargeChange = numberOfVisibleRows;
    }

    private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
        // Format the archived
        if (e.ColumnIndex == 2 && e.RowIndex >= 0) {
            if (e.Value is bool isSuccess) {
                e.Value = isSuccess ? "Yes" : "No";

                e.CellStyle = new DataGridViewCellStyle() {
                    ForeColor = isSuccess ? ColorScheme.Current.Info : ColorScheme.Current.Danger,
                };
            }
        }
    }

    private void sb_ValueChanged(object sender, EventArgs e) {
        if (sb.Visible && WindowState != FormWindowState.Minimized) dataGridView.FirstDisplayedScrollingRowIndex = sb.Value;
    }

    private void dataGridView_Resize(object sender, EventArgs e) {
        SetScrollOptions();
    }

    private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
        foreach (DataGridViewColumn column in dataGridView.Columns) {
            column.HeaderCell.SortGlyphDirection = SortOrder.None;
        }

        bool isAscending = e.Button == MouseButtons.Left;
        dataGridView.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = isAscending ? SortOrder.Ascending : SortOrder.Descending;

        SortRequestEventArgs sortRequestEventArgs = new(dataGridView.Columns[e.ColumnIndex].Name, isAscending);
        SortRequested?.Invoke(this, sortRequestEventArgs);
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
