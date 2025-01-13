using System.ComponentModel;

namespace a2_coursework.CustomControls; 
public partial class CustomToggleButton : CustomPanel {
    private ToggleButtonState _buttonState = ToggleButtonState.Normal;

    private bool _toggled = false;
    public bool Toggled {
        get => _buttonState == ToggleButtonState.Toggled;
        set {

            Invalidate();
        }
    }

    private Color _backColor;
    [Category("Appearance")]
    public new Color BackColor {
        get => _backColor;
        set {
            _backColor = value;
            if (Enabled && _buttonState == ToggleButtonState.Normal) {
                base.BackColor = _backColor;
            }
        }
    }

    private Color _foreColor;
    [Category("Appearance")]
    public new Color ForeColor {
        get => _foreColor;
        set {
            base.ForeColor = value;
        }
    }

    private Color _hoverColor;
    [Category("Appearance")]
    public Color HoverColor {
        get => _hoverColor;
        set {
            _hoverColor = value;
            if (_buttonState == ToggleButtonState.Hover) {
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
            if (_buttonState == ToggleButtonState.Toggled) {
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

    protected override void OnMouseEnter(EventArgs e) {
        _buttonState = ToggleButtonState.Hover;

        if (Enabled) {
            base.BackColor = HoverColor;
            base.OnMouseEnter(e);
        }
    }

    protected override void OnMouseLeave(EventArgs e) {
        _buttonState = ToggleButtonState.Normal;

        if (Enabled) {
            base.BackColor = BackColor;
            base.OnMouseLeave(e);
        }
    }

    protected override void OnMouseClick(MouseEventArgs e) {
        Toggled = !Toggled;
        
        if (Enabled) {
            base.BackColor = Toggled ? 
            base.OnMouseClick(e);
    }

    protected override void OnClick(EventArgs e) {
        if (Enabled) base.OnClick(e);
    }

    private enum ToggleButtonState {
        Normal,
        Toggled,
        Hover
    }
}

