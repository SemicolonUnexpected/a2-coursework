using System.ComponentModel;

namespace a2_coursework.CustomControls;

public partial class CustomButton {
    private ButtonState _buttonState = ButtonState.Normal;

    private Color _backColor;
    [Category("Normal Appearance")]
    public new Color BackColor {
        get => _backColor;
        set {
            _backColor = value;
            if (Enabled && _buttonState == ButtonState.Normal) {
                base.BackColor = _backColor;
            }
        }
    }

    private Color _borderColor;
    [Category("Normal Appearance")]
    public override Color BorderColor {
        get => _borderColor;
        set {
            _borderColor = value;
            if (Enabled && _buttonState == ButtonState.Normal) {
                base.BorderColor = _borderColor;
            }
        }
    }

    private Color _hoverColor;
    [Category("Hover Appearance")]
    public Color HoverColor {
        get => _hoverColor;
        set {
            _hoverColor = value;
            if (Enabled && _buttonState == ButtonState.Hover) {
                base.BackColor = _hoverColor;
            }
        }
    }

    private Color _borderHoverColor;
    [Category("Hover Appearance")]
    public Color HoverBorderColor {
        get => _borderHoverColor;
        set {
            _borderHoverColor = value;
            if (Enabled && _buttonState == ButtonState.Hover) {
                BorderColor = _borderHoverColor;
            }
        }
    }

    private Color _clickedColor;
    [Category("Clicked Appearance")]
    public Color ClickedColor {
        get => _clickedColor;
        set {
            _clickedColor = value;
            if (Enabled && _buttonState == ButtonState.Clicked) {
                base.BackColor = _hoverColor;
            }
        }
    }

    private Color _borderClickedColor;
    [Category("Clicked Appearance")]
    public Color ClickedBorderColor {
        get => _borderClickedColor;
        set {
            _borderClickedColor = value;
            if (Enabled && _buttonState == ButtonState.Clicked) {
                base.BorderColor = _borderHoverColor;
            }
        }
    }

    private Color _disabledColor;
    [Category("Disabled Appearance")]
    public Color DisabledColor {
        get => _disabledColor;
        set {
            _disabledColor = value;
            if (!Enabled) {
                base.BackColor = _disabledColor;
            }
        }
    }

    private Color _disabledBorderColor;
    [Category("Disabled Appearance")]
    public Color DisabledBorderColor {
        get => _disabledBorderColor;
        set {
            _disabledBorderColor = value;
            if (!Enabled) {
                base.BorderColor = _disabledBorderColor;
            }
        }
    }

    private string _text;
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [DefaultValue("")]
    [TypeConverter(typeof(StringConverter))]
    public new string Text {
        get => _text;
        set {
            _text = value;
            CalculateTextPosition();
            Invalidate();
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

    private CustomButtonAlign _textAlign;

    public CustomButtonAlign TextAlign {
        get => _textAlign;
        set {
            _textAlign = value;
            CalculateTextPosition();
            Invalidate();
        }
    }

    private Point _textPosition;
    public Point TextPosition {
        get => _textPosition;
        set {
            _textPosition = value;
            CalculateTextPosition();
            Invalidate();
        }
    }

    private Image _backgroundImage;
    public new Image BackgroundImage {
        get => _backgroundImage;
        set {
            _backgroundImage = value;
            Invalidate();
        }
    }

    private Rectangle _imageRectangle;
    public Rectangle ImageRectangle {
        get => _imageRectangle;
        set {
            _imageRectangle = value;
            Invalidate();
        }
    }

    private enum ButtonState {
        Normal,
        Clicked,
        Hover
    }
}

[Flags]
public enum CustomButtonAlign {
    TopLeft,
    TopCenter,
    TopRight,
    MiddleLeft,
    MiddleCenter,
    MiddleRight,
    BottomLeft,
    BottomCenter,
    BottomRight,
    Point
}
