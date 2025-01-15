using System.Drawing.Drawing2D;

namespace a2_coursework.CustomControls;
public partial class CustomScrollBar {
    private int _maximum;
    public int Maximum {
        get => _maximum;
        set {
            _maximum = value;
            Invalidate();
        }
    }

    private int _minimum;
    public int Minimum {
        get => _minimum;
        set {
            _minimum = value;
            Invalidate();
        }
    }

    private int _largeChange;
    public int LargeChange {
        get => _largeChange;
        set {
            _largeChange = value;
            Invalidate();
        }
    }

    private int _smallChange;
    public int SmallChange {
        get => _smallChange;
        set {
            _smallChange = value;
            Invalidate();
        }
    }

    private int _value;
    public int Value {
        get => _value;
        set {
            _value = value;
            Invalidate();
        }
    }

    private int _minimumThumbSize;
    public int MinimumThumbHeight {
        get => _minimumThumbSize;
        set {
            _minimumThumbSize = value;
            Invalidate();
        }
    }

    private Color _thumbColor;
    public Color ThumbColor {
        get => _thumbColor;
        set {
            _thumbColor = value;
            Invalidate();
        }
    }

    private Color _thumbHoverColor;
    public Color ThumbHoverColor {
        get => _thumbHoverColor;
        set {
            _thumbHoverColor = value;
            Invalidate();
        }
    }

    private Color _thumbClickedColor;
    public Color ThumbClickedColor {
        get => _thumbClickedColor;
        set {
            _thumbClickedColor = value;
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
    public new Padding Padding {
        get => _padding;
        set {
            _padding = value;
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



    public event EventHandler? Scroll;
    public event EventHandler? ValueChanged;
}
