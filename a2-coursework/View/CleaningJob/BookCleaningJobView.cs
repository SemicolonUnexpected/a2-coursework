using a2_coursework._Helpers;
using a2_coursework.CustomControls;
using a2_coursework.Interfaces.CleaningJob;
using a2_coursework.Theming;
using a2_coursework.View.Order;
using System.ComponentModel;

namespace a2_coursework.View.Users;
public partial class BookCleaningJobView : Form, IThemeable, IBookCleaningJobView {
    private readonly BindingSource _bindingSource = [];

    public event EventHandler? Search;
    public event EventHandler<SortRequestEventArgs>? SortRequested;
    public event EventHandler? DateChanged;
    public event EventHandler? Add;
    public event EventHandler? Edit;
    public event EventHandler? View;
    public event EventHandler? Delete;

    public BookCleaningJobView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        topBar.Search += (s, e) => Search?.Invoke(this, EventArgs.Empty);
        topBar.SearchTextChanged += (s, e) => Search?.Invoke(this, EventArgs.Empty);
        monthCalendar.DateChanged += (s, e) => DateChanged?.Invoke(this, EventArgs.Empty);
        topBar.Add += (s, e) => Add?.Invoke(this, EventArgs.Empty);
        topBar.Edit += (s, e) => Edit?.Invoke(this, EventArgs.Empty);
        topBar.View += (s, e) => View?.Invoke(this, EventArgs.Empty);
        topBar.Delete += (s, e) => Delete?.Invoke(this, EventArgs.Empty);

        SetupDataGrid();
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblCleaningJobs.ThemeTitle();
        lblError.ThemeSubtitle();

        topBar.Theme();
        pnlData.Theme();
        dataGridView.Theme();
        sb.Theme();
        dateInput.Theme();
        monthCalendar.Theme();
        pnlDate.Theme();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        foreach (DataGridViewColumn column in dataGridView.Columns) {
            column.ToolTipText = showToolTips ? "Left click to sort ascending\nRight click to sort descending" : "";
        }

        topBar.SetToolTipVisibility();
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        topBar.SetFontName(fontName);
        dataGridView.SetFontName(fontName);
        lblCleaningJobs.SetFontName(fontName);
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

        columnJobId.DataPropertyName = nameof(DisplayCleaningJobModel.Id);
        columnTime.DataPropertyName = nameof(DisplayCleaningJobModel.Times);
        columnAddress.DataPropertyName = nameof(DisplayCleaningJobModel.Address);
    }

    public string SearchText {
        get => topBar.SearchText;
        set => topBar.SearchText = value;
    }

    public DisplayCleaningJobModel? SelectedItem {
        get {
            try {
                return ((BindingList<DisplayCleaningJobModel>)_bindingSource.DataSource)[dataGridView.SelectedRows[0].Index];
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

    public DateTime Date {
        get => monthCalendar.Date;
        set {
            monthCalendar.Date = value;
            monthCalendar.DisplayedDate = value;
        }
    }

    public void DisplayItems(BindingList<DisplayCleaningJobModel> items) {
        dataGridView.SuspendLayout();
        _bindingSource.DataSource = items;
        dataGridView.ResumeLayout();
    }

    public bool AddEnabled {
        get => topBar.AddEnabled;
        set => topBar.AddEnabled = value;
    }

    public bool DeleteEnabled {
        get => topBar.DeleteEnabled;
        set => topBar.DeleteEnabled = value;
    }

    public bool ViewMode {
        get => topBar.ViewMode;
        set => topBar.ViewMode = value;
    }

    public void DisableAll() {
        topBar.Enabled = false;
        dataGridView.Enabled = false;
    }

    public void EnableAll() {
        topBar.Enabled = true;
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

                e.CellStyle!.ForeColor = isSuccess ? ColorScheme.Current.Info : ColorScheme.Current.Danger;
                e.CellStyle!.SelectionForeColor = isSuccess ? ColorScheme.Current.Info : ColorScheme.Current.Danger;
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

    private void customMonthCalendar_DateChanged(object? sender, EventArgs e) {
        dateInput.DateTextChanged -= dateInput_DateTextChanged;
        dateInput.Date = monthCalendar.Date;
        dateInput.DateTextChanged += dateInput_DateTextChanged;
    }

    private void dateInput_DateTextChanged(object? sender, EventArgs e) {
        if (!dateInput.DateValid) return;

        monthCalendar.DateChanged -= customMonthCalendar_DateChanged;
        monthCalendar.Date = (DateTime)dateInput.Date!;
        monthCalendar.DisplayedDate = (DateTime)dateInput.Date!;
        monthCalendar.DateChanged += customMonthCalendar_DateChanged;

        DateChanged?.Invoke(this, EventArgs.Empty);
    }

    private void dateInput_Leave(object sender, EventArgs e) {
        dateInput.DateTextChanged -= dateInput_DateTextChanged;
        dateInput.Date = monthCalendar.Date;
        dateInput.DateTextChanged += dateInput_DateTextChanged;
    }

    private void pnlData_Resize(object sender, EventArgs e) {
        topBar.Width = (pnlData.Width * 4) / 5;
        topBar.Location = new Point(pnlData.Location.X + (pnlData.Width - topBar.Width) / 2, topBar.Location.Y);
        Refresh();
    }
}
