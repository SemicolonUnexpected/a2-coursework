using a2_coursework.Theming;
using System.ComponentModel;

namespace a2_coursework.CustomControls; 
public partial class CustomNumericUpDown : UserControl, IThemeable {
    public event EventHandler? ValueChanged;

    public CustomNumericUpDown() {
        InitializeComponent();

        Theme();

        btnIncrement.Click += (s, e) => Increment();
        btnDecrement.Click += (s, e) => Decrement();
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        btnIncrement.ThemeWeak();
        btnDecrement.ThemeWeak();
        tbValue.Theme();
    }

    private void tbValue_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
        //if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) e.IsInputKey = true;
    }

    private void tbValue_KeyPress(object sender, KeyPressEventArgs e) {
        if (e.KeyChar == 13) SetValue();
        if (!char.IsAsciiDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
    }

    private void tbValue_Leave(object sender, EventArgs e) {
        SetValue();
    }

    private void tbValue_TextChanged(object sender, EventArgs e) {
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

    private void SetValue() {
        bool validNumber = int.TryParse(tbValue.Text, out int number);

        if (!validNumber) tbValue.Text = Value.ToString();
        else Value = number;
    }
}
