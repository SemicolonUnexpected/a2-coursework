using System.ComponentModel;

namespace a2_coursework.CustomControls; 
public partial class TimeInput {

    [TypeConverter(typeof(ColorConverter))]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Browsable(true)]
    [DefaultValue(typeof(Color), "250, 250, 250")]
    private Color _foreColor = Color.FromArgb(250, 250, 250);
    public new Color ForeColor {
        get => _foreColor;
        set {
            _foreColor = value;

            tbHour.ForeColor = _foreColor;
            tbMinute.ForeColor = _foreColor;
            lblDivider.ForeColor = _foreColor;
            base.ForeColor = _foreColor;
        }
    }

    [TypeConverter(typeof(ColorConverter))]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Browsable(true)]
    [DefaultValue(typeof(Color), "9, 9, 10")]
    private Color _backColor = Color.FromArgb(9, 9, 10);
    public new Color BackColor {
        get => _backColor;
        set {
            _backColor = value;

            tbHour.BackColor = _backColor;
            tbMinute.BackColor = _backColor;
            lblDivider.BackColor = _backColor;
            base.BackColor = _backColor;
        }
    }

    [TypeConverter(typeof(FontConverter))]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Browsable(true)]
    [DefaultValue(typeof(FontConverter), "Bahnschrift, 12pt")]
    private Font _font = new Font("Bahnschrift", 12, GraphicsUnit.Point);
    public new Font Font {
        get => _font;
        set {
            _font = value;

            tbHour.Font = value;
            tbMinute.Font = value;
            base.Font = Font;
        }
    }

    [DefaultValue(false)]
    private bool _readOnly = false;
    public bool ReadOnly {
        get => _readOnly;
        set {
            _readOnly = value;

            tbHour.ReadOnly = _readOnly;
            tbMinute.ReadOnly = _readOnly;
        }
    }

    private Color _placeholderColor;
    public Color PlaceholderColor {
        get => _placeholderColor;
        set {
            _placeholderColor = value;

            tbHour.PlaceholderTextColor = _placeholderColor;
            tbMinute.PlaceholderTextColor = _placeholderColor;
        }
    }

    [TypeConverter(typeof(ColorConverter))]
    [DefaultValue(typeof(Color), "39, 39, 42")]
    private Color _borderColor = Color.FromArgb(39, 39, 42);
    public Color BorderColor {
        get => _borderColor;
        set {
            _borderColor = value;

            if (HourValid) tbHour.BorderColor = _borderColor;
            if (MinuteValid) tbMinute.BorderColor = _borderColor;
        }
    }

    [TypeConverter(typeof(ColorConverter))]
    [DefaultValue(typeof(Color), "190, 18, 60")]
    private Color _borderErrorColor = Color.FromArgb(190, 18, 60);
    public Color BorderErrorColor {
        get => _borderErrorColor;
        set {
            _borderErrorColor = value;

            if (!HourValid) tbHour.BorderColor = _borderErrorColor;
            if (!MinuteValid) tbMinute.BorderColor = _borderErrorColor;
        }
    }

    public TimeOnly? Time {
        get {
            if (!TimeValid || !int.TryParse(tbHour.Text, out int hour) || !int.TryParse(tbMinute.Text, out int minute)) return null;
            else return new TimeOnly(hour, minute); 
        }
        set {
            if (value is not null) {
                tbHour.Text = ((TimeOnly)value).ToString("HH");
                tbMinute.Text = ((TimeOnly)value).ToString("mm");
            }
            else {
                tbHour.Text = "";
                tbMinute.Text = "";
            }
        }
    }

    public string Hour {
        get => tbHour.Text;
        set => tbHour.Text = value;
    }

    public string Minute {
        get => tbMinute.Text;
        set => tbMinute.Text = value;
    }

    public bool TimeValid => HourValid && MinuteValid;

    public bool HourValid {
        get {
            bool hourValid = int.TryParse(tbHour.Text, out int value);
            return hourValid && value >= 0 && value < 24;
        }
    }

    public bool MinuteValid {
        get {
            bool minuteValid = int.TryParse(tbMinute.Text, out int value);
            return minuteValid && value >= 0 && value < 60;
        }
    }
}
