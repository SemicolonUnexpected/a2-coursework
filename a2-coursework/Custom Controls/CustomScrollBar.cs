using System.ComponentModel;

namespace a2_coursework.CustomControls;
public partial class CustomScrollBar : Control {
    private int _channelHeight;
    private float _thumbHeight;
    private float _channelWorkingHeight;
    private int _thumbGrabYOffset;
    private float _thumbY;

    public CustomScrollBar() {
        // Cache these to allow for faster painting
        CalculateHeights();

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
        if (ThumbPath is not null && !ThumbPath.IsVisible(e.Location)) {
            _thumbGrabYOffset = (int)_thumbHeight / 2;
            SetThumbY(e.Location.Y);
        }
        base.OnMouseClick(e);
    }

    protected override void OnResize(EventArgs e) {
        // Cache these to allow for faster painting
        CalculateHeights();

        base.OnResize(e);

        Invalidate();
    }

    protected override void OnMouseWheel(MouseEventArgs e) {
        SetThumbY((int)_thumbY - e.Delta);
        Refresh();

        base.OnMouseWheel(e);
    }

    private void SetThumbY(int y) {
        int thumbY = y - _thumbGrabYOffset;
        _thumbY = Math.Clamp(thumbY, 0, _channelWorkingHeight);

        float fractionScrolled = (_thumbY - Padding.Top) / _channelWorkingHeight;
        int value = (int)((Maximum - Minimum) * fractionScrolled + Minimum);
        if (value != _value) {
            _value = value;
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }

        Scroll?.Invoke(this, EventArgs.Empty);
    }

    protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
        ThumbCorderRadii = new CornerRadiiF(ThumbCorderRadii.TopLeft * factor.Width, ThumbCorderRadii.TopRight * factor.Width, ThumbCorderRadii.BottomLeft * factor.Width, ThumbCorderRadii.BottomRight * factor.Width);
        base.ScaleControl(factor, specified);
    }

    private void CalculateHeights() {
        int value = Math.Clamp(Value, Minimum, Maximum);
        if (value != _value) {
            _value = value;
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }

        _channelHeight = Height - Padding.Vertical;
        _thumbHeight = Math.Min(_channelHeight, Math.Max(MinimumThumbHeight, (int)(LargeChange / (float)(Maximum + LargeChange) * _channelHeight)));
        _channelWorkingHeight = _channelHeight - _thumbHeight;
        _thumbY = _channelWorkingHeight * _value / (Maximum - Minimum) + Padding.Top;
    }

    private bool ThumbContainsMouse(Point mouseClientLocation) => ThumbPath is not null && ThumbPath.IsVisible(mouseClientLocation);
}
