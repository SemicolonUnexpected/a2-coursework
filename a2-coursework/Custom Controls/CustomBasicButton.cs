using System.ComponentModel;
using static a2_coursework.CustomControls.CustomControlHelpers;

namespace a2_coursework.CustomControls; 
public partial class CustomBasicButton : CustomPanel {
    private bool _isMouseInside = false;

    #region Appearance Properties
    [Category("Appearance")]
    public Color HoverColor { get; set; }

    [Category("Appearance")]
    public Color ClickedColor { get; set; } 

    [Category("Appearance")]
    public Color BorderHoverColor { get; set; }

    [Category("Appearance")]
    public Color BorderClickedColor { get; set; }

    private Color _backColor;
    [Category("Appearance")]
    public new Color BackColor {
        get {
            return _backColor;
        }
        set {
            _backColor = value;
            // The PointToClient method is required as the ClientRectangle is given in client coordinates
            if (!_isMouseInside || DesignMode) {
                base.BackColor = value;
            }
        }
    }

    public override string Text { get => base.Text; set { base.Text = value; Invalidate(); } }

    private ButtonTextAlign _textAlign;

    public ButtonTextAlign TextAlign {
        get => _textAlign;
        set {
            _textAlign = value;
            Invalidate();
        }
    }

    private Point _textPosition;
    public Point TextPosition {
        get => _textPosition;
        set {
            _textPosition = value;
            Invalidate();
        }
    }

    #endregion

    public CustomBasicButton() {
        DoubleBuffered = true;

        BackColor = base.BackColor;

        MouseDown += ControlMouseDown;
        MouseUp += ControlMouseUp;
        MouseClick += ControlMouseClick;
        Click += ControlClick;
        MouseEnter += ControlMouseEnter;
        MouseLeave += ControlMouseLeave;
    }

    protected override void OnControlAdded(ControlEventArgs e) {
        ExecuteRecursive(ctrl => {
            ctrl.MouseDown += ControlMouseDown;
            ctrl.MouseUp += ControlMouseUp;
            ctrl.MouseClick += ControlMouseClick;
            ctrl.Click += ControlClick;
            ctrl.MouseEnter += ControlMouseEnter;
            ctrl.MouseLeave += ControlMouseLeave;
        },
            e.Control);

        base.OnControlAdded(e);
    }

    protected override void OnControlRemoved(ControlEventArgs e) {
        ExecuteRecursive((ctrl) => {
            ctrl.MouseDown -= ControlMouseDown;
            ctrl.MouseUp -= ControlMouseUp;
            ctrl.MouseClick -= ControlMouseClick;
            ctrl.Click -= ControlClick;
            ctrl.MouseEnter -= ControlMouseEnter;
            ctrl.MouseLeave -= ControlMouseLeave;
        },
            e.Control);

        base.OnControlRemoved(e);
    }

    private void ControlMouseEnter(object? sender, EventArgs e) {
        _isMouseInside = true;
        base.BackColor = HoverColor;

        foreach (Control? ctrl in Controls) {
            if (ctrl is not null) ctrl.BackColor = HoverColor;
        }
    }

    private void ControlClick(object? sender, EventArgs e) { }

    private void ControlMouseDown(object? sender, MouseEventArgs e) {
        base.BackColor = ClickedColor;

        foreach (Control? ctrl in Controls) {
            if (ctrl is not null) ctrl.BackColor = ClickedColor;
        }
    }

    private void ControlMouseClick(object? sender, MouseEventArgs e) { }

    private void ControlMouseUp(object? sender, MouseEventArgs e) {
        base.BackColor = HoverColor;

        foreach (Control? ctrl in Controls) {
            if (ctrl is not null) ctrl.BackColor = HoverColor;
        }
    }

    private void ControlMouseLeave(object? sender, EventArgs e) {
        _isMouseInside = false;
        base.BackColor = BackColor;

        foreach (Control? ctrl in Controls) {
            if (ctrl is not null) ctrl.BackColor = BackColor;
        }
    }

    protected override void OnPaint(PaintEventArgs e) {
        Size measurement = TextRenderer.MeasureText(Text, Font);
        int center = (Width - measurement.Width) / 2;
        int middle = (Height - measurement.Height) / 2;

        Point textPosition = TextAlign switch {
            //ButtonTextAlign.TopLeft => new Point(Padding.Left, Padding.Top),
            //ButtonTextAlign.TopCenter => new Point(center, Padding.Top),
            ButtonTextAlign.MiddleCenter => new Point(center, middle),
            ButtonTextAlign.Point => TextPosition,
            _ => throw new NotImplementedException(),
        };

        Graphics graphics = e.Graphics;
        graphics.DrawString(Text, Font, new SolidBrush(ForeColor), textPosition);

        base.OnPaint(e);
    }
}

public enum ButtonTextAlign {
    //TopLeft,
    //TopCenter, 
    //TopRight,
    //MiddleLeft,
    MiddleCenter,
    //MiddleRight,
    //BottomLeft,
    //BottomCenter,
    //BottomRight,
    Point
}
