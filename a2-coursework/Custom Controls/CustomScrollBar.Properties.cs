using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace a2_coursework.CustomControls;
public partial class CustomScrollBar {
    private int _maximum;
    public int Maximum {
        get => _maximum;
        set {
            _maximum = value;
            CalculateThumbHeight();
            Invalidate();
        }
    }

    private int _minimum;
    public int Minimum {
        get => _minimum;
        set {
            _minimum = value;
            CalculateThumbHeight();
            Invalidate();
        }
    }

    private int _largeChange;
    public int LargeChange {
        get => _largeChange;
        set {
            _largeChange = value;
            CalculateThumbHeight();
            Invalidate();
        }
    }

    private int _smallChange;
    public int SmallChange {
        get => _smallChange;
        set {
            _smallChange = value;
            CalculateThumbHeight();
            Invalidate();
        }
    }

    private int _value;
    public int Value {
        get => _value;
        set {
            value = Math.Clamp(value, Minimum, Maximum);
            if (value != _value) {
                _thumbY = _channelWorkingHeight * (float)_value / (Maximum - Minimum);
                _value = value;
                Invalidate();

                ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }

    private int _minimumThumbSize;
    public int MinimumThumbHeight {
        get => _minimumThumbSize;
        set {
            _minimumThumbSize = value;
            CalculateThumbHeight();
            Invalidate();
        }
    }

    private Color _thumbColor;
    public Color ThumbColor {
        get => _thumbColor;
        set {
            _thumbColor = value;

            if (_thumbState == CustomScrollBarThumbState.Normal) {
                _actualThumbColor = _thumbColor;
            }

            Invalidate();
        }
    }

    private Color _thumbHoverColor;
    public Color ThumbHoverColor {
        get => _thumbHoverColor;
        set {
            _thumbHoverColor = value;

            if (_thumbState == CustomScrollBarThumbState.Hover) {
                _actualThumbColor = _thumbHoverColor;
            }

            Invalidate();
        }
    }

    private Color _thumbClickedColor;
    public Color ThumbClickedColor {
        get => _thumbClickedColor;
        set {
            _thumbClickedColor = value;

            if (_thumbState == CustomScrollBarThumbState.Clicked) {
                _actualThumbColor = _thumbClickedColor;
            }

            Invalidate();
        }
    }

    private CornerRadiiF _thumbCornerRadii;
    public CornerRadiiF ThumbCorderRadii {
        get => _thumbCornerRadii;
        set {
            _thumbCornerRadii = value;
            Invalidate();
        }
    }

    private Padding _padding;
    [TypeConverter(typeof(PaddingConverter))]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Browsable(true)]
    [DefaultValue(typeof(Padding), "0,0,0,0")]
    public new Padding Padding {
        get => _padding;
        set {
            _padding = value;
            if (_thumbY < _padding.Top) {
                _thumbY = _padding.Top;
            }
            else if (_thumbY + _thumbHeight > _padding.Bottom) {
                _thumbY = Height - (_padding.Bottom + _thumbHeight);
            }

            CalculateChannelWorkingHeight();
            CalculateThumbHeight();

            Invalidate();
        }
    }

    private GraphicsPath? _thumbPath;
    private GraphicsPath? ThumbPath {
        get => _thumbPath;
        set {
            _thumbPath?.Dispose();
            _thumbPath = value;
        }
    }

    private enum CustomScrollBarThumbState { Normal, Hover, Clicked }

    public event EventHandler? Scroll;
    public event EventHandler? ValueChanged;
}
