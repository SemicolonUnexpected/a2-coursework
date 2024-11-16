using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms.Design;

namespace AS_Coursework.Custom_Controls;
// Allow the control to have children
[Designer(typeof(ParentControlDesigner))]
// Inherit from the Control class for a more lightweight control
// Inheriting from control instead of panel also removes any nasty flickering
public partial class CustomRectangle : Control {

    private Color _borderColor;
    [Category("_Custom rectangle")]
    public Color BorderColor {
        get => _borderColor;
        set {
            _borderColor = value;
            Invalidate();
        }
    }
    
    private int _cornerRadius;
    [Category("_Custom rectangle")]
    public int CornerRadius {
        get => _cornerRadius;
        set {
            _cornerRadius = value;
            Invalidate();
        }
    }

    private int _borderWidth;
    [Category("_Custom rectangle")]
    public int BorderWidth {
        get => _borderWidth;
        set {
            _borderWidth = value;
            Invalidate();
        }
    }

    public CustomRectangle() { }

    protected override void OnPaint(PaintEventArgs e) {
        Graphics graphics = e.Graphics;

        // The rectangle of the control which is drawn
        Rectangle rectangleSurface = DisplayRectangle;
        // Get the correct size for the border
        Rectangle borderRectangle = Rectangle.Inflate(rectangleSurface, -BorderWidth, -BorderWidth);

        // The size of the border to prevent a jagged edge
        int smoothSize = BorderWidth > 0 ? BorderWidth : 2;

        if (CornerRadius > 2) {
            using GraphicsPath pathSurface = CustomControlGraphics.GetRoundedRectGraphicPath(rectangleSurface, CornerRadius);
            using GraphicsPath pathBorder = CustomControlGraphics.GetRoundedRectGraphicPath(borderRectangle, CornerRadius - BorderWidth);
            using Pen penSurface = new(Parent.BackColor, smoothSize);
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

            if (BorderWidth <= 1) return;

            using Pen penBorder = new(BorderColor, BorderWidth);

            penBorder.Alignment = PenAlignment.Inset;
            graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
        }
    }

    protected override void OnSizeChanged(EventArgs e) {
        Refresh();
    }
}
