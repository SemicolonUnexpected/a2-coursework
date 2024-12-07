using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms.Design;

namespace AS_Coursework.Custom_Controls;
// Allow the control to have children
[Designer(typeof(ParentControlDesigner))]
// Inherit from the Control class for a more lightweight control
// Inheriting from control instead of panel also removes any nasty flickering
public partial class CustomPanel : Control {

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

    private float _borderWidth;
    [Category("Appearance")]
    public float BorderWidth {
        get => _borderWidth;
        set {
            _borderWidth = value;
            Invalidate();
        }
    }

    public CustomPanel() : base(){
        float scalingFactor = DeviceDpi / 96f;
        Location = new Point((int)(Location.X * scalingFactor), (int)(Location.Y * scalingFactor));
    }

    protected override void OnPaint(PaintEventArgs e) {
        Graphics graphics = e.Graphics;

        // Scale the corners based on DPI
        float scalingFactor = DeviceDpi / 96f;

        // The rectangle of the control which is drawn
        Rectangle rectangleSurface = DisplayRectangle;
        // Get the correct size for the border
        RectangleF borderRectangle = RectangleF.Inflate(rectangleSurface, -BorderWidth, -BorderWidth);

        // The size of the border to prevent a jagged edge
        int smoothSize = BorderWidth > 0 ? (int)BorderWidth : 2;

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

            using Pen penBorder = new(BorderColor, BorderWidth * 2f);

            graphics.DrawRectangle(penBorder, 0, 0, Width, Height);
        }
    }

    protected override void OnSizeChanged(EventArgs e) {
        Invalidate();
    }
}
