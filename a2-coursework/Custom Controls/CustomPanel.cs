using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms.Design;

namespace AS_Coursework.Custom_Controls;
// Allow the control to have children
[Designer(typeof(ParentControlDesigner))]
// Inherit from the Control class for a more lightweight control
// Inheriting from control instead of panel also removes any nasty flickering
public partial class CustomPanel : Control {
    [Category("Appearance")]
    public Color? HoverColor { get; set; } = null;

    [Category("Appearance")]
    public Color? ClickedColor { get; set; } = null;

    private Color _borderColor;
    [Category("Appearance")]
    public Color BorderColor {
        get => _borderColor;
        set {
            _borderColor = value;
            Invalidate();
        }
    }
    
    private int _cornerRadius;
    [Category("Appearance")]
    public int CornerRadius {
        get => _cornerRadius;
        set {
            _cornerRadius = value;
            Invalidate();
        }
    }

    private int _borderWidth;
    [Category("Appearance")]
    public int BorderWidth {
        get => _borderWidth;
        set {
            _borderWidth = value;
            Invalidate();
        }
    }

    private Color _backColor;
    [Category("Appearance")]
    public override Color BackColor {
        get {
            return _backColor;
        }
        set {

        }
    }

    public CustomPanel() {
        _defaultBackColor = BackColor;
    }

    protected override void OnPaint(PaintEventArgs e) {
        Graphics graphics = e.Graphics;

        // Scale the corners based on DPI
        float scalingFactor = DeviceDpi / 96f;

        // The rectangle of the control which is drawn
        Rectangle rectangleSurface = DisplayRectangle;
        // Get the correct size for the border
        Rectangle borderRectangle = Rectangle.Inflate(rectangleSurface, -BorderWidth, -BorderWidth);

        // The size of the border to prevent a jagged edge
        int smoothSize = BorderWidth > 0 ? BorderWidth : 2;

        if (CornerRadius > 2) {
            using GraphicsPath pathSurface = CustomControlGraphics.GetRoundedRectGraphicPath(rectangleSurface, CornerRadius * scalingFactor);
            using GraphicsPath pathBorder = CustomControlGraphics.GetRoundedRectGraphicPath(borderRectangle, (CornerRadius - BorderWidth) * scalingFactor);
            using Pen penSurface = new(Parent!.BackColor, smoothSize);
            using Pen penBorder = new(BorderColor, BorderWidth);

            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Set the actual space of the control in which graphics can be drawn to the rounded rectangle path
            Region = new Region(pathSurface);

            graphics.DrawPath(penSurface, pathSurface);

            if (BorderWidth >= 1) graphics.DrawPath(penBorder, pathBorder);
        }
        else {
            graphics.SmoothingMode = SmoothingMode.None;

            Region = new Region(rectangleSurface);

            if (BorderWidth < 1) return;

            using Pen penBorder = new(BorderColor, BorderWidth);

            penBorder.Alignment = PenAlignment.Inset;
            graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
        }
    }

    protected override void OnSizeChanged(EventArgs e) {
        Invalidate();
    }

    protected override void OnMouseEnter(EventArgs e) {
        base.OnMouseEnter(e);

        if (HoverColor is not null) BackColor = (Color)HoverColor;
    }

    protected override void OnMouseLeave(EventArgs e) {
        base.OnMouseLeave(e);

        BackColor = _defaultBackColor;
    }

    protected override void OnMouseDown(MouseEventArgs e) {
        base.OnMouseDown(e);

        MessageBox.Show(_defaultBackColor.ToString());
        if (ClickedColor is not null) BackColor = (Color)ClickedColor;
        MessageBox.Show(_defaultBackColor.ToString());
    }

    protected override void OnMouseUp(MouseEventArgs e) {
        base.OnMouseUp(e);

        BackColor = _defaultBackColor;
    }
}
