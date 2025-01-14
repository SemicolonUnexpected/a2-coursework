using System.ComponentModel;

namespace a2_coursework.CustomControls; 
public partial class CustomToggleButton : CustomPanel {
    private ToggleButtonState _buttonState = ToggleButtonState.Normal;

    public event EventHandler? ToggleChanged;
    private bool _toggled = false;
    public bool Toggled {
        get => _toggled;
        set {
            if (!Enabled) return;

            _toggled = value;

            if (_toggled) {
                base.BackColor = ToggledColor;
                Font = new Font(Font, FontStyle.Bold);
            }
            else if (_buttonState == ToggleButtonState.Normal) {
                base.BackColor = BackColor;
                Font = new Font(Font, FontStyle.Regular);
            }

            ToggleChanged?.Invoke(this, EventArgs.Empty);

            Invalidate();
        }
    }

    private Color _backColor;
    [Category("Appearance")]
    public new Color BackColor {
        get => _backColor;
        set {
            _backColor = value;
            if (_buttonState == ToggleButtonState.Normal && Enabled && !Toggled) {
                base.BackColor = _backColor;
            }
        }
    }

    private Color _foreColor;
    [Category("Appearance")]
    public new Color ForeColor {
        get => _foreColor;
        set {
            _foreColor = value;
            if (Enabled) base.ForeColor = _foreColor;
        }
    }

    private Color _hoverColor;
    [Category("Appearance")]
    public Color HoverColor {
        get => _hoverColor;
        set {
            _hoverColor = value;
            if (_buttonState == ToggleButtonState.Hover && Enabled && !Toggled) {
                base.BackColor = _hoverColor;
                Invalidate();
            }
        }
    }

    private Color _toggledColor;
    [Category("Appearance")]
    public Color ToggledColor {
        get => _toggledColor;
        set {
            _toggledColor = value;
            if (Toggled && Enabled) {
                base.BackColor = _toggledColor;
                Invalidate();
            }
        }
    }

    private bool _enabled = true;
    public new event EventHandler? EnabledChanged;
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [DefaultValue(true)]
    [TypeConverter(typeof(BooleanConverter))]
    public new bool Enabled {
        get => _enabled;
        set {
            _enabled = value;
            OnEnabledChanged(EventArgs.Empty);
        }
    }

    private string _text = "";
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [DefaultValue("")]
    [TypeConverter(typeof(StringConverter))]
    public new string Text {
        get => _text;
        set {
            _text = value;
            Invalidate();
        } 
    }

    public new Padding Padding {
        get => base.Padding;
        set {
            base.Padding = value;
            Invalidate();
        }
    }

    protected override void OnMouseEnter(EventArgs e) {
        _buttonState = ToggleButtonState.Hover;
        if (!Enabled) return;

        if (!Toggled) {
            base.BackColor = HoverColor;
        }
        base.OnMouseEnter(e);
    }

    protected override void OnMouseLeave(EventArgs e) {
        _buttonState = ToggleButtonState.Normal;
        if (!Enabled) return;

        if (!Toggled) {
            base.BackColor = BackColor;
        }

        base.OnMouseLeave(e);
    }

    protected override void OnMouseClick(MouseEventArgs e) {
        if (!Enabled) return;

        Toggled = !Toggled;

        if (Toggled) {
            Font = new Font(Font, FontStyle.Bold);
            base.BackColor = ToggledColor;
        }
        else {
            Font = new Font(Font, FontStyle.Regular);
            base.BackColor = HoverColor;
        }
        
        base.OnMouseClick(e);
    }

    protected override void OnClick(EventArgs e) {
        if (Enabled) base.OnClick(e);
    }

    protected override void OnPaint(PaintEventArgs e) {
        Size textSize = TextRenderer.MeasureText(Text, Font);
        TextRenderer.DrawText(e.Graphics, Text, Font, new Point(Padding.Left, (Height - textSize.Height) / 2), ForeColor);
        base.OnPaint(e);
    }

    private enum ToggleButtonState {
        Normal,
        Hover
    }
}

