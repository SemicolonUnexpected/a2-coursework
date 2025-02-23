namespace a2_coursework.CustomControls;
public partial class DateInput : UserControl {
    public DateInput() {
        InitializeComponent();
    }

    // The date inputs should only accept numbers
    private void tbYear_KeyPress(object sender, KeyPressEventArgs e) {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
    }

    private void tbMonth_KeyPress(object sender, KeyPressEventArgs e) {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
    }

    private void tbDay_KeyPress(object sender, KeyPressEventArgs e) {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
    }

    // Insert leading zeros
    private void tbDay_Leave(object sender, EventArgs e) {
        if (tbDay.Text.Length == 1) {
            tbDay.Text = "0" + tbDay.Text;
        }
    }

    private void tbMonth_Leave(object sender, EventArgs e) {
        if (tbMonth.Text.Length == 1) {
            tbMonth.Text = "0" + tbMonth.Text;
        }
    }

    private void tbYear_Leave(object sender, EventArgs e) { }

    private void tbDay_TextChanged(object sender, EventArgs e) {
        SetAllBorderColor(!TryGetDate(out _));
        DateTextChanged?.Invoke(this, EventArgs.Empty);
    }

    private void tbMonth_TextChanged(object sender, EventArgs e) {
        SetAllBorderColor(!TryGetDate(out _));
        DateTextChanged?.Invoke(this, EventArgs.Empty);
    }

    private void tbYear_TextChanged(object sender, EventArgs e) {
        SetAllBorderColor(!TryGetDate(out _));
        DateTextChanged?.Invoke(this, EventArgs.Empty);
    }

    private bool TryGetDate(out DateTime? date) {
        date = null;

        if (NullValid && tbDay.Text.Length == 0 && tbMonth.Text.Length == 0 && tbYear.Text.Length == 0) {
            date = null;
            return true;
        }

        try {
            // Parse and validate the date
            int day = int.Parse(tbDay.Text);
            int month = int.Parse(tbMonth.Text);
            int year = int.Parse(tbYear.Text);

            // Attempt to create a DateTime object
            DateTime candidateDate = new(year, month, day);

            if (MaxDate is not null && MaxDate < candidateDate) return false;
            if (MinDate is not null && MinDate > candidateDate) return false;

            date = candidateDate;
            return true;
        }
        catch {
            return false;
        }
    }

    protected override void OnLeave(EventArgs e) {
        bool valid = TryGetDate(out DateTime? date);

        if (valid) {
            SetAllBorderColor(false);
        }
        else {
            SetAllBorderColor(true);
        }

        base.OnLeave(e);
    }

    // Helpers to set the border color on an error
    private void SetBorderColor(CustomTextBox textBox, bool isError) => textBox.BorderColor = isError ? BorderErrorColor : BorderColor;

    private void SetAllBorderColor(bool isError) {
        SetBorderColor(tbDay, isError);
        SetBorderColor(tbMonth, isError);
        SetBorderColor(tbYear, isError);
    }

    protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
        if (specified is BoundsSpecified.All or BoundsSpecified.Size) {
            BorderThickness *= factor.Width;
        }
        base.ScaleControl(factor, specified);
    }
}
