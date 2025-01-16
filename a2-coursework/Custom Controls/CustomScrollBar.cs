namespace a2_coursework.CustomControls; 
public partial class CustomScrollBar : Control {
    private int _channelHeight;
    private float _thumbHeight;
    private int _grabY;
    private float _thumbY;
    private Color _actualThumbColor;
    private bool _isDragging = false;

    public CustomScrollBar() {
        // Cache these to allow for faster painting
        _channelHeight = Height - Padding.Vertical;
        _thumbHeight = Math.Max(MinimumThumbHeight, (float)Maximum / LargeChange * _channelHeight);
    }

    protected override void OnPaint(PaintEventArgs e) {
        Graphics g = e.Graphics;

        ThumbPath = CustomControlHelpers.GetRoundedRectGraphicPath(new RectangleF(Padding.Left, _thumbY, Width - Padding.Horizontal, _thumbHeight), ThumbCorderRadii);
        g.FillPath(new SolidBrush(_actualThumbColor), ThumbPath);

        base.OnPaint(e);
    }

    private void CalculateThumbPosition(int mouseY) {
        int actualRange = _channelHeight - (int)_thumbHeight;

    }

    protected override void OnMouseDown(MouseEventArgs e) {
        if (e.Button == MouseButtons.Left) {
            _isDragging = true;
            _grabY = PointToClient(e.Location).Y;
        }

        base.OnMouseDown(e);
    }

    protected override void OnMouseUp(MouseEventArgs e) {
        _isDragging = false;


        base.OnMouseUp(e);
    }

    protected override void OnMouseMove(MouseEventArgs e) {
        if (ThumbPath is not null) {
            if  (ThumbPath.IsVisible(e.Location)) {
                if (_isDragging) _actualThumbColor = ThumbClickedColor;
                else _actualThumbColor = ThumbHoverColor;
            }
            else {
                _actualThumbColor = ThumbColor;
            }
        }

        if (_isDragging) {
            CalculateThumbPosition(PointToClient(e.Location).Y);
        }

        Invalidate();
        base.OnMouseMove(e);
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        // Cache these to allow for faster painting
        _channelHeight = Height - Padding.Vertical;
        _thumbHeight = Math.Max(MinimumThumbHeight, (int)((double)Maximum / LargeChange * _channelHeight));
    }
}
