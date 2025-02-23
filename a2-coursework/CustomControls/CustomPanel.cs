using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms.Design;

namespace a2_coursework.CustomControls;

// Allow the control to have children
[Designer(typeof(ParentControlDesigner))]
public partial class CustomPanel : Panel {

    private Color _borderColor;
    [Category("Appearance")]
    public virtual Color BorderColor {
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
    public float BorderThickness {
        get => _borderWidth;
        set {
            _borderWidth = value;
            Invalidate();
        }
    }

    public CustomPanel() {
        DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e) {
        Graphics graphics = e.Graphics;

        // Get the correct size for the border
        RectangleF borderRectangle = RectangleF.Inflate(ClientRectangle, -BorderThickness, -BorderThickness);

        // The size of the border to prevent a jagged edge
        int smoothSize = BorderThickness > 0 ? (int)BorderThickness : 2;

        if (CornerRadii.All != 0) {
            using GraphicsPath pathSurface = CustomControlHelpers.GetRoundedRectGraphicPath(ClientRectangle, CornerRadii);
            using GraphicsPath pathBorder = CustomControlHelpers.GetRoundedRectGraphicPath(borderRectangle, CornerRadii - BorderThickness);
            using Pen penSurface = new(Parent!.BackColor, smoothSize);
            using Pen penBorder = new(BorderColor, BorderThickness);

            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Set the actual space of the control in which graphics can be drawn to the rounded rectangle path
            Region = new Region(pathSurface);

            graphics.DrawPath(penSurface, pathSurface);

            if (BorderThickness >= 1) graphics.DrawPath(penBorder, pathBorder);
        }
        else {
            graphics.SmoothingMode = SmoothingMode.None;

            Region = new Region(ClientRectangle);

            if (BorderThickness < 1) return;

            using Pen penBorder = new(BorderColor, BorderThickness * 2f);

            graphics.DrawRectangle(penBorder, 0, 0, Width, Height);
        }
    }

    protected override void OnResize(EventArgs e) {
        Invalidate();
        base.OnResize(e);
    }

    protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
        if (specified is BoundsSpecified.All or BoundsSpecified.Size) {
            BorderThickness *= factor.Width;
            CornerRadii *= factor.Width;
        }
        base.ScaleControl(factor, specified);
    }
}
