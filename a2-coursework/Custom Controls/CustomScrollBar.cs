namespace a2_coursework.CustomControls; 
public partial class CustomScrollBar : Control {
    private int _channelWorkingHeight;
    private float _thumbHeight;
    private int _thumbGrabYOffset;
    private float _thumbY;
    private Color _actualThumbColor;
    private bool _isDragging = false;
    private bool _mouseDown = false;
    private CustomScrollBarThumbState _thumbState = CustomScrollBarThumbState.Normal;

    public CustomScrollBar() {
        // Cache these to allow for faster painting
        CalculateChannelWorkingHeight();
        CalculateThumbHeight();

        DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e) {
        Graphics g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        ThumbPath = CustomControlHelpers.GetRoundedRectGraphicPath(new RectangleF(Padding.Left, _thumbY, Width - Padding.Horizontal, _thumbHeight), ThumbCorderRadii);
        g.FillPath(new SolidBrush(_actualThumbColor), ThumbPath);

        base.OnPaint(e);
    }

    protected override void OnMouseDown(MouseEventArgs e) {
        if (e.Button == MouseButtons.Left) {
            _mouseDown = true;
            
            if (ThumbContainsMouse(e.Location)) {
                _isDragging = true;

                _actualThumbColor = ThumbClickedColor;
                _thumbState = CustomScrollBarThumbState.Clicked;

                _thumbGrabYOffset = e.Location.Y - (int)_thumbY;

                Invalidate();
            }
        }

        base.OnMouseDown(e);
    }

    protected override void OnMouseUp(MouseEventArgs e) {
        if (e.Button == MouseButtons.Left) {
            _mouseDown = false;
            _isDragging = false;
            _thumbGrabYOffset = 0;

            if (ThumbContainsMouse(e.Location)) {
                _actualThumbColor = ThumbHoverColor;
                _thumbState = CustomScrollBarThumbState.Hover;
            }
            else {
                _actualThumbColor = ThumbColor;
                _thumbState = CustomScrollBarThumbState.Normal;
            }

            Invalidate();
        }

        base.OnMouseUp(e);
    }

    protected override void OnMouseMove(MouseEventArgs e) {
        if (ThumbContainsMouse(e.Location) && !_mouseDown) {
            _actualThumbColor = ThumbHoverColor;
            _thumbState = CustomScrollBarThumbState.Hover;
        }
        else if (!_isDragging) {
            _actualThumbColor = ThumbColor;
            _thumbState = CustomScrollBarThumbState.Normal;
        }

        if (_isDragging) {
            SetThumbY(e.Location.Y);
        }

        Invalidate();
        base.OnMouseMove(e);
    }

    protected override void OnMouseLeave(EventArgs e) {
        if (!_mouseDown) {
            _actualThumbColor = ThumbColor;
            _thumbState = CustomScrollBarThumbState.Normal;

            Invalidate();
        }

        base.OnMouseLeave(e);
    }

    protected override void OnMouseClick(MouseEventArgs e) {
        _thumbGrabYOffset = (int)_thumbHeight / 2;
        SetThumbY(e.Location.Y);
        base.OnMouseClick(e);
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        // Cache these to allow for faster painting
        CalculateChannelWorkingHeight();
        CalculateThumbHeight();
    }

    private void SetThumbY(int y) {
        int thumbY = y - _thumbGrabYOffset;
        if (thumbY < 0) _thumbY = 0;
        else if (thumbY > _channelWorkingHeight) _thumbY = _channelWorkingHeight;
        else _thumbY = thumbY;

        float fractionScrolled = _thumbY / _channelWorkingHeight;
        int value = (int)((Maximum - Minimum) * fractionScrolled + Minimum);
        if (value != Value) {
            Value = value;
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }

        Scroll?.Invoke(this, EventArgs.Empty);
    }

    private void CalculateThumbHeight() => _thumbHeight = Math.Max(MinimumThumbHeight, (int)(Maximum / (double)LargeChange * _channelWorkingHeight));
    private void CalculateChannelWorkingHeight() => _channelWorkingHeight = Height - (Padding.Vertical + (int)_thumbHeight);
    private bool ThumbContainsMouse(Point mouseClientLocation) => ThumbPath is not null && ThumbPath.IsVisible(mouseClientLocation);
}
