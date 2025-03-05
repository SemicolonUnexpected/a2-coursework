namespace a2_coursework.CustomControls;
public partial class TimeInput : UserControl {
    public event EventHandler? TimeTextChanged;
    public TimeInput() {
        InitializeComponent();
    }

    // The time inputs should only accept numbers
    private void tbHour_KeyPress(object sender, KeyPressEventArgs e) {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
    }

    private void tbMinute_KeyPress(object sender, KeyPressEventArgs e) {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
    }

    private void tbHour_Leave(object sender, EventArgs e) {
        if (tbHour.Text.Length == 1) {
            tbHour.Text = "0" + tbHour.Text;
        }
    }

    private void tbMinute_Leave(object sender, EventArgs e) {
        if (tbMinute.Text.Length == 1) {
            tbMinute.Text = "0" + tbMinute.Text;
        }
    }

    private void tbHour_TextChanged(object sender, EventArgs e) {
        tbHour.BorderColor = HourValid ? BorderColor : BorderErrorColor;
        TimeTextChanged?.Invoke(this, EventArgs.Empty);
    }

    private void tbMinute_TextChanged(object sender, EventArgs e) {
        tbMinute.BorderColor = MinuteValid ? BorderColor : BorderErrorColor;
        TimeTextChanged?.Invoke(this, EventArgs.Empty);
    }
}
