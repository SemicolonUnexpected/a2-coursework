using a2_coursework.Custom_Controls;
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
    
    private CornerRadiiF _cornerRadii;
    [Category("Appearance")]
    [TypeConverter(typeof(CornerRadiiFConverter))]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Browsable(true)]
    public CornerRadiiF CornerRadii {
        get => _cornerRadii;
        set {
            _cornerRadii = value;
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

    private GraphicsPath? _graphicsPath;
    protected GraphicsPath? GraphicsPath {
        get => _graphicsPath;
        private set {
            _graphicsPath?.Dispose();
            _graphicsPath = value;
        } 
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

        if (true) {
            using GraphicsPath pathSurface = CustomControlGraphics.GetRoundedRectGraphicPath(rectangleSurface, CornerRadii * scalingFactor);
            GraphicsPath pathBorder = CustomControlGraphics.GetRoundedRectGraphicPath(borderRectangle, (CornerRadii - BorderWidth) * scalingFactor);
            using Pen penSurface = new(Parent!.BackColor, smoothSize);
            using Pen penBorder = new(BorderColor, BorderWidth);

            // Store the graphics path for later use when checking for the mouse position
            GraphicsPath = pathBorder;

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
}
