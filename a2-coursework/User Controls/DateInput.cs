using a2_coursework.CustomControls;
using a2_coursework.Theming;
using System.ComponentModel;

namespace a2_coursework.User_Controls;
public partial class DateInput : UserControl {
    private float _borderThicknessNormal = 1;
    private float _borderThicknessError = 2;

    public DateInput() {
        InitializeComponent();

        float scalingFactor = DeviceDpi / 96f;
        _borderThicknessNormal *= scalingFactor;
        _borderThicknessError *= scalingFactor;
    }

    public event EventHandler? ErrorChanged;
    public string ErrorMessage {
        get => _errorMessage;
        private set {
            if (_errorMessage != value) {
                _errorMessage = value;
                ErrorChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }

    public event EventHandler? DateChanged;
    [DefaultValue(null)]
    public DateTime? Date {
        get => GetDate();
        set {
            if (value is not null) {
                tbDay.Text = value.Value.Day.ToString();
                tbMonth.Text = value.Value.Month.ToString();
                tbYear.Text = value.Value.Year.ToString();
            }
            else {
                tbDay.Text = "";
                tbMonth.Text = "";
                tbYear.Text = "";
            }

            DateChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        tbDay.Theme();
        tbMonth.Theme();
        tbYear.Theme();

        lblDay.ThemeSubtitle();
        lblMonth.ThemeSubtitle();
        lblYear.ThemeSubtitle();
    }

    private string _errorMessage = "";

    // The date inputs should only accept numbers
    private void tbYear_KeyPress(object sender, KeyPressEventArgs e) {
        if (!char.IsDigit(e.KeyChar)) e.Handled = true;
    }

    private void tbMonth_KeyPress(object sender, KeyPressEventArgs e) {
        if (!char.IsDigit(e.KeyChar)) e.Handled = true;
    }

    private void tbDay_KeyPress(object sender, KeyPressEventArgs e) {
        if (!char.IsDigit(e.KeyChar)) e.Handled = true;
    }

    // Insert leading zeros
    private void tbDay_Leave(object sender, EventArgs e) {
        if (tbDay.Text.Length == 1) {
            tbDay.Text = "0" + tbDay.Text;
        }
        else if (tbYear.Text.Length == 0) {
            SetBorderProperties(tbDay, true);
            _errorMessage = "Incomplete date";
        }
    }

    private void tbMonth_Leave(object sender, EventArgs e) {
        if (tbMonth.Text.Length == 1) {
            tbMonth.Text = "0" + tbMonth.Text;
        }
        else if (tbMonth.Text.Length == 0) {
            SetBorderProperties(tbMonth, true);
            _errorMessage = "Incomplete date";
        }
    }

    private void tbYear_Leave(object sender, EventArgs e) {
        if (tbYear.Text.Length == 0) {
            SetBorderProperties(tbYear, true);
            _errorMessage = "Incomplete date";
        }
    }

    // Clear the error if the text is filled in
    private void tbDay_TextChanged(object sender, EventArgs e) {
        if (tbDay.Text.Length != 0) {
            SetBorderProperties(tbDay, false);
        }
    }

    private void tbMonth_TextChanged(object sender, EventArgs e) {
        if (tbDay.Text.Length != 0) {
            SetBorderProperties(tbDay, false);
        }
    }

    private void tbYear_TextChanged(object sender, EventArgs e) {
        if (tbDay.Text.Length != 0) {
            SetBorderProperties(tbDay, false);
        }
    }

    private bool IsDateInvalid() {
        if (tbDay.Text == "" || tbMonth.Text == "" || tbYear.Text == "") return false;
        try {
            // Parse and validate the date
            int day = int.Parse(tbDay.Text);
            int month = int.Parse(tbMonth.Text);
            int year = int.Parse(tbYear.Text);

            // Attempt to create a DateTime object
            DateTime date = new(year, month, day);

            return false;
        }
        catch {
            return true;
        }
    }

    private DateTime? GetDate() {
        try {
            // Parse and validate the date
            int day = int.Parse(tbDay.Text);
            int month = int.Parse(tbMonth.Text);
            int year = int.Parse(tbYear.Text);

            // Attempt to create a DateTime object
            DateTime date = new(year, month, day);

            return date;
        }
        catch {
            return null;
        }
    }

    protected override void OnLeave(EventArgs e) {
        // Set the error for any empty fields
        SetBorderProperties(tbDay, tbDay.Text.Length == 0);
        SetBorderProperties(tbMonth, tbMonth.Text.Length == 0);
        SetBorderProperties(tbYear, tbYear.Text.Length == 0);
        if (tbDay.Text.Length == 0 || tbMonth.Text.Length == 0 || tbYear.Text.Length == 0) ErrorMessage = "Incomplete date";

        if (IsDateInvalid()) {
            SetAllBorderProperties(true);
            ErrorMessage = "Invalid date";
        }

        base.OnLeave(e);
    }

    // Helpers to set the border color on an error
    private void SetBorderProperties(CustomTextBox textBox, bool isError) {
        textBox.BorderColor = isError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
        textBox.BorderThickness = isError ? _borderThicknessError : _borderThicknessNormal;
    }

    private void SetAllBorderProperties(bool isError) {
        SetBorderProperties(tbDay, isError);
        SetBorderProperties(tbMonth, isError);
        SetBorderProperties(tbYear, isError);
    }
}
