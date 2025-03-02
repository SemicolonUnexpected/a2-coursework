namespace a2_coursework.CustomControls;
public partial class CustomMonthCalendar : UserControl {
    public event EventHandler? DateChanged;

    public CustomMonthCalendar() {
        InitializeComponent();

        DoubleBuffered = true;
    }

    private void OnDateChanged() {
        SetMonth();
        AssignDays();
    }

    private void SetMonth() => lblMonth.Text = DisplayedDate.ToString("MMMM yyyy");

    private void AssignDays() {
        tableLayoutPanel.SuspendLayout();

        int startOfMonth = (int)new DateTime(DisplayedDate.Year, DisplayedDate.Month, 1).DayOfWeek;

        DateTime previousMonth = DisplayedDate.AddMonths(-1);
        int daysInPreviousMonth = DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
        int previousMonthStartDay = daysInPreviousMonth - startOfMonth + 1;

        int daysInMonth = DateTime.DaysInMonth(DisplayedDate.Year, DisplayedDate.Month);

        int filledCells = startOfMonth + daysInMonth;
        int excessDays = 42 - filledCells; // 42 = 6 rows * 7 days

        DateTime today = DateTime.Today;

        for (int row = 1; row < 7; row++) {
            for (int col = 0; col < 7; col++) {
                CustomButton button = (CustomButton)tableLayoutPanel.GetControlFromPosition(col, row)!;
                int position = (row - 1) * 7 + col;

                bool hideRow = (excessDays >= 7 && row == 6) || (excessDays == 14 && row == 5);
                button.Visible = !hideRow;

                if (hideRow) continue;

                if (position < startOfMonth) {
                    int day = previousMonthStartDay + position;
                    ConfigureButton(button, day, false);
                }
                else if (position < startOfMonth + daysInMonth) {
                    int day = position - startOfMonth + 1;

                    bool isSelectedDate = Date.Year == DisplayedDate.Year && Date.Month == DisplayedDate.Month && Date.Day == day;

                    ConfigureButton(button, day, true, isSelectedDate);
                }
                else {
                    int day = position - (startOfMonth + daysInMonth) + 1;
                    ConfigureButton(button, day, false);
                }
            }
        }

        tableLayoutPanel.ResumeLayout();
    }

    private void ConfigureButton(CustomButton button, int day, bool enabled, bool isSelectedDate = false) {
        button.Text = day.ToString();
        button.Enabled = enabled;
        button.ForeColor = enabled ? ForeColor : DisabledForeColor;
        button.HoverColor = HoverColor;
        button.ClickedColor = ClickedColor;

        if (isSelectedDate) button.BackColor = SelectedDateBackColor;
        else button.BackColor = BackColor;
    }

    private void OnButtonClicked(object? sender, EventArgs e) {
        CustomButton button = (CustomButton)sender!;

        _date = new DateTime(DisplayedDate.Year, _displayedDate.Month, int.Parse(button.Text));
        DateChanged?.Invoke(this, EventArgs.Empty);
        OnDateChanged();
    }

    protected override void OnForeColorChanged(EventArgs e) {
        base.OnForeColorChanged(e);

        for (int i = 0; i < 7; i++) tableLayoutPanel.GetControlFromPosition(i, 0)!.ForeColor = ForeColor;


        lblMonth.ForeColor = ForeColor;

        OnDateChanged();
    }

    protected override void OnBackColorChanged(EventArgs e) {
        base.OnBackColorChanged(e);

        pnl.BackColor = BackColor;
        btnNext.BackColor = BackColor;
        btnPrevious.BackColor = BackColor;
        tableLayoutPanel.BackColor = BackColor;

        OnDateChanged();
    }

    private void btnNext_Click(object sender, EventArgs e) {
        DisplayedDate = _displayedDate.AddMonths(1);
        OnDateChanged();
    }

    private void btnPrevious_Click(object sender, EventArgs e) {
        DisplayedDate = _displayedDate.AddMonths(-1);
        OnDateChanged();
    }
}
