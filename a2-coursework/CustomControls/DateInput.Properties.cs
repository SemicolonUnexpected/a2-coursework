using System.ComponentModel;

namespace a2_coursework.CustomControls;
public partial class DateInput {
    public event EventHandler? DateTextChanged;

    public string DayText => tbDay.Text;

    public string MonthText => tbMonth.Text;

    public string YearText => tbYear.Text;

    public int? Day {
        get {
            if (int.TryParse(tbDay.Text, out int day)) return day;
            else return null;
        }
        set {
            if (value is null) tbDay.Text = "";
            else if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));
            else if (value < 10) tbDay.Text = "0" + value.ToString();
            else tbDay.Text = value.ToString() ?? "";
        }
    }

    public bool DateValid => TryGetDate(out _);

    public int? Month {
        get {
            if (int.TryParse(tbMonth.Text, out int month)) return month;
            else return null;
        }
        set {
            if (value is null) tbMonth.Text = "";
            else if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));
            else if (value < 10) tbMonth.Text = "0" + value.ToString();
            else tbMonth.Text = value.ToString() ?? "";
        }
    }

    public int? Year {
        get {
            if (int.TryParse(tbYear.Text, out int year)) return year;
            else return null;
        }
        set {
            if (value is null) tbYear.Text = "";
            else if (value < 0) throw new ArgumentOutOfRangeException("value");
            else tbYear.Text = value.ToString() ?? "";
        }
    }

    public DateTime? MinDate { get; set; }
    public DateTime? MaxDate { get; set; }

    private Color _backColor = Color.FromArgb(9, 9, 10);
    [Category("Appearance")]
    [TypeConverter(typeof(ColorConverter))]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [DefaultValue(typeof(Color), "9, 9, 10")]
    public new Color BackColor {
        get => _backColor;
        set {
            _backColor = value;

            base.BackColor = value;

            tbDay.BackColor = value;
            tbMonth.BackColor = value;
            tbYear.BackColor = value;

            lblDay.BackColor = value;
            lblMonth.BackColor = value;
            lblYear.BackColor = value;
        }
    }

    private Color _foreColor = Color.White;
    [Category("Appearance")]
    [TypeConverter(typeof(ColorConverter))]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [DefaultValue(typeof(Color), "255, 255, 255")]
    public new Color ForeColor {
        get => _foreColor;
        set {
            _foreColor = value;

            base.ForeColor = value;

            tbDay.ForeColor = value;
            tbMonth.ForeColor = value;
            tbYear.ForeColor = value;

            lblDay.ForeColor = value;
            lblMonth.ForeColor = value;
            lblYear.ForeColor = value;
        }
    }

    public Color PlaceholderTextColor {
        get => tbDay.PlaceholderTextColor;
        set {
            tbDay.PlaceholderTextColor = value;
            tbMonth.PlaceholderTextColor = value;
            tbYear.PlaceholderTextColor = value;
        }
    }

    private Color _borderColor;
    [Category("Appearance")]
    public Color BorderColor {
        get => _borderColor;
        set {
            _borderColor = value;

            if (ErrorState == DateErrorState.None) {
                tbDay.BorderColor = value;
                tbMonth.BorderColor = value;
                tbYear.BorderColor = value;
            }
        }
    }

    private Color _borderErrorColor = Color.Red;
    [Category("Appearance")]
    public Color BorderErrorColor {
        get => _borderErrorColor;
        set {
            _borderErrorColor = value;

            if (ErrorState == DateErrorState.Incomplete) {
                if (string.IsNullOrEmpty(tbDay.Text)) tbDay.BorderColor = _borderErrorColor;
                if (string.IsNullOrEmpty(tbMonth.Text)) tbMonth.BorderColor = _borderErrorColor;
                if (string.IsNullOrEmpty(tbYear.Text)) tbYear.BorderColor = _borderErrorColor;
            }
            else if (ErrorState == DateErrorState.Invalid) {
                tbDay.BorderColor = _borderErrorColor;
                tbMonth.BorderColor = _borderErrorColor;
                tbYear.BorderColor = _borderErrorColor;
            }
        }
    }

    private float _borderThickness = 1;
    [Category("Appearance")]
    public float BorderThickness {
        get => _borderThickness;
        set {
            _borderThickness = value;

            tbDay.BorderThickness = value;
            tbMonth.BorderThickness = value;
            tbYear.BorderThickness = value;
        }
    }

    [DefaultValue(null)]
    public DateTime? Date {
        get {
            TryGetDate(out DateTime? date);
            return date;
        }
        set {
            if (value is not null) {
                Day = value.Value.Day;
                Month = value.Value.Month;
                Year = value.Value.Year;
            }
            else {
                tbDay.Text = "";
                tbMonth.Text = "";
                tbYear.Text = "";
            }
        }
    }

    private DateErrorState _errorState = DateErrorState.None;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public DateErrorState ErrorState {
        get => _errorState;
        private set => _errorState = value;
    }

    private bool _nullValid = false;
    [DefaultValue(false)]
    public bool NullValid {
        get => _nullValid;
        set => _nullValid = value;
    }

    private bool _showPlaceholder = true;
    [DefaultValue(true)]
    public bool ShowPlaceholder {
        get => _showPlaceholder;
        set {
            _showPlaceholder = value;

            if (_showPlaceholder) {
                tbDay.PlaceholderText = "14";
                tbMonth.PlaceholderText = "09";
                tbYear.PlaceholderText = "2006";
            }
            else {
                tbDay.PlaceholderText = "";
                tbMonth.PlaceholderText = "";
                tbYear.PlaceholderText = "";
            }
        }
    }

    public enum DateErrorState { None, Incomplete, Invalid }

    public new bool Enabled {
        get => tbDay.Enabled;
        set {
            tbDay.Enabled = value;
            tbMonth.Enabled = value;
            tbYear.Enabled = value;
        }
    }

    public string DayToolTip {
        get => tbDay.ToolTipText;
        set => tbDay.ToolTipText = value;
    }

    public string MonthToolTip {
        get => tbMonth.ToolTipText;
        set => tbMonth.ToolTipText = value;
    }

    public string YearToolTip {
        get => tbYear.ToolTipText;
        set => tbYear.ToolTipText = value;
    }

    public bool ToolTipsActive {
        get => tbDay.ToolTipsActive;
        set {
            tbDay.ToolTipsActive = value;
            tbMonth.ToolTipsActive = value;
            tbYear.ToolTipsActive = value;
        }
    }

    public bool ReadOnly {
        get => tbDay.ReadOnly;
        set {
            tbDay.ReadOnly = value;
            tbMonth.ReadOnly = value;
            tbYear.ReadOnly = value;
        }
    }
}
