using a2_coursework._Helpers;
using a2_coursework.Theming;
using System.ComponentModel;

namespace a2_coursework.CustomControls;
public partial class CustomNumericUpDown : UserControl, IThemeable {
    public event EventHandler? ValueChanged;

    public CustomNumericUpDown() {
        InitializeComponent();

        Theme();
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        btnIncrement.ThemeWeak();
        btnDecrement.ThemeWeak();
        tbValue.Theme();
    }

    private void tbValue_KeyPress(object sender, KeyPressEventArgs e) {
        if (!char.IsAsciiDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
    }

    private void tbValue_Leave(object sender, EventArgs e) {
        bool validNumber = long.TryParse(tbValue.Text, out long number);

        if (!validNumber) tbValue.Text = Value.ToString();
        else Value = (int)Math.Clamp(number, Minimum, Maximum);
    }

    private void tbValue_TextChanged(object sender, EventArgs e) {
        bool validNumber = int.TryParse(tbValue.Text, out int number);

        if (validNumber) Value = number;
    }

    private void tbValue_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Up) {
            Increment();
            e.Handled = true;
        }

        if (e.KeyCode == Keys.Down) {
            Decrement();
            e.Handled = true;
        }
    }

    private int _minimum = 0;
    [DefaultValue(0)]
    public int Minimum {
        get => _minimum;
        set {
            _minimum = value;

            if (Value < _minimum) Value = _minimum;
        }
    }

    private int _maximum = 10;
    [DefaultValue(10)]
    public int Maximum {
        get => _maximum;
        set {
            _maximum = value;

            if (Value > _maximum) Value = _maximum;
        }
    }

    private int _value = 0;
    [DefaultValue(0)]
    public int Value {
        get => _value;
        set {
            _value = Math.Clamp(value, Minimum, Maximum);
            tbValue.Text = _value.ToString();
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    public void Increment(int i = 1) => Value += i;
    public void Decrement(int i = 1) => Value -= i;

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        tbValue.Width = Width - btnIncrement.Width - btnDecrement.Width;
        int inset = (Height - tbValue.InnerTextboxHeight) / 2;
        tbValue.TextBoxInset = new Padding(tbValue.TextBoxInset.Left, inset, tbValue.TextBoxInset.Right, inset);
        tbValue.Location = new Point(btnIncrement.Width, (Height - tbValue.Height) / 2);
    }

    private void btnIncrement_Click(object sender, EventArgs e) {
        Increment();
    }

    private void btnDecrement_Click(object sender, EventArgs e) {
        Decrement();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        toolTip.Active = showToolTips;
        tbValue.ToolTipsActive = showToolTips;
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        tbValue.SetFontName(fontName);
    }
}
