using System.ComponentModel;

namespace a2_coursework.CustomControls; 
public partial class CustomButton : CustomPanel {
    private ButtonState _buttonState = ButtonState.Normal;

    #region Properties
    private Color _hoverColor;
    [Category("Appearance")]
    public Color HoverColor {
        get => _hoverColor;
        set {
            _hoverColor = value;
            if (_buttonState == ButtonState.Hover) {
                base.BackColor = _hoverColor;
            }
        }
    }

    private Color _clickedColor; 
    [Category("Appearance")]
    public Color ClickedColor {
        get => _clickedColor;
        set {
            _clickedColor = value;
            if (_buttonState == ButtonState.Clicked) {
                base.BackColor = _hoverColor;
            }
        }
    } 

    private Color _borderHoverColor; 
    [Category("Appearance")]
    public Color BorderHoverColor {
        get =>  _borderHoverColor;
        set {
            _borderHoverColor = value;
            if (_buttonState == ButtonState.Hover) {
                BorderColor = _borderHoverColor;
            }
        }

    }

    private Color _borderClickedColor; 
    [Category("Appearance")]
    public Color BorderClickedColor {
        get =>  _borderClickedColor;
        set {
              _borderClickedColor = value;
            if (_buttonState == ButtonState.Clicked) {
                BorderColor = _borderHoverColor;
            }
        }
    }

    private Color _backColor;
    [Category("Appearance")]
    public new Color BackColor {
        get {
            return _backColor;
        }
        set {
            _backColor = value;
            // The PointToClient method is required as the ClientRectangle is given in client coordinates
            if (_buttonState == ButtonState.Normal) {
                base.BackColor = value;
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

    #endregion

    public CustomButton() {
        DoubleBuffered = true;
        BackColor = base.BackColor;
    }

    protected override void OnMouseEnter(EventArgs e) {
        _buttonState = ButtonState.Hover;
        base.BackColor = HoverColor;
    }

    protected override void OnMouseLeave(EventArgs e) {
        _buttonState = ButtonState.Normal;
        base.BackColor = BackColor;
    }

    protected override void OnMouseDown(MouseEventArgs e) {
        _buttonState = ButtonState.Clicked;
        base.BackColor = ClickedColor;
    }

    protected override void OnMouseUp(MouseEventArgs e) {
        _buttonState = ButtonState.Clicked;
        base.BackColor = HoverColor;
    }

    protected override void OnPaint(PaintEventArgs e) {
        if (!string.IsNullOrWhiteSpace(Text))TextRenderer.DrawText(e.Graphics, Text, Font, _textPosition, ForeColor);
        if (BackgroundImage is not null) e.Graphics.DrawImage(BackgroundImage, ImageRectangle);

        base.OnPaint(e);
    }

    protected override void OnResize(EventArgs e) {
        CalculateTextPosition();
        base.OnResize(e);
    }

    protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
        ImageRectangle = new((int)(ImageRectangle.Location.X * factor.Width), (int)(ImageRectangle.Location.Y * factor.Height), (int)(ImageRectangle.Width * factor.Width), (int)(ImageRectangle.Height * factor.Height));
        base.ScaleControl(factor, specified);
    }

    private void CalculateTextPosition() {
        Size measurement = TextRenderer.MeasureText(Text, Font);
        int center = (Width - measurement.Width) / 2;
        int middle = (Height - measurement.Height) / 2;

        _textPosition = TextAlign switch {
            CustomButtonAlign.TopLeft => new Point(Padding.Left, Padding.Top),
            CustomButtonAlign.TopCenter => new Point(center, Padding.Top),
            CustomButtonAlign.MiddleCenter => new Point(center, middle),
            CustomButtonAlign.Point => TextPosition,
            _ => throw new NotImplementedException(),
        };
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
