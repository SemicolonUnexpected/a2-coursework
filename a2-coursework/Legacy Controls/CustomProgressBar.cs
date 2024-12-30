using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace a2_coursework.CustomControls; 
public partial class CustomProgressBar : Control {

    private Color _startColor = Color.FromArgb(0, 100, 255);
    private Color _endColor = Color.FromArgb(50, 200, 255);
    private Color _backColor = Color.White;
    private float _progress;
    private int _angle;

    public CustomProgressBar() {
        DoubleBuffered = true;
    }

    [Category("_CustomProgressBar Appearance")]
    public Color StartColor {
        get => _startColor;
        set {
            _startColor = value;
            Invalidate();
        }
    }

    [Category("_CustomProgressBar Appearance")]
    public Color EndColor {
        get => _endColor;
        set {
            _endColor = value;
            Invalidate();
        }
    }

    [Category("_CustomProgressBar Appearance")]
    public Color BackingColor {
        get => _backColor;
        set {
            _backColor = value;
            Invalidate();
        }
    }

    [Category("_CustomProgressBar Appearance")]
    public int Angle {
        get => _angle;
        set {
            _angle = value;
            Invalidate();
        }
    }

    /// <summary>
    /// The progress displayed as a number between 0 and 1
    /// </summary>
    [Category("_CustomProgressBar Appearance"), Description("The progress displayed as a number between 0 and 1")]
    public float Progress {
        get => _progress;
        set {
            // Ensure the progress is between 0 and 1
            // Only throw a runtime error as designer errors are awkward to deal with
            if (DesignMode) _progress = Math.Clamp(value, 0, 1);
            else _progress = value >= 0 && value <= 1 ? value : throw new ArgumentOutOfRangeException("Progress", "The progress value must be between 0 and 1");
            Refresh();
        }
    }

    protected override void OnPaint(PaintEventArgs e) {
        base.OnPaint(e);

        Graphics graphics = e.Graphics;
        graphics.SmoothingMode = SmoothingMode.HighQuality;

        using Pen backingPen = new(BackingColor, Height / 2);
        using Pen progressPen = new(new LinearGradientBrush(DisplayRectangle, StartColor, EndColor, Angle), Height / 2);

        backingPen.StartCap = LineCap.Round;
        backingPen.EndCap = LineCap.Round;
        progressPen.StartCap = LineCap.Round;
        progressPen.EndCap = LineCap.Round;

        PointF lineStart = new(Height / 2, Height / 2);
        PointF lineEnd = new(Width - Height / 2, Height / 2);

        float maxProgressWidth = lineEnd.X - lineStart.X;

        PointF progressLineEnd = new(lineStart.X + maxProgressWidth * Progress, Height / 2);

        graphics.DrawLine(backingPen, lineStart, lineEnd);
        graphics.DrawLine(progressPen, lineStart, progressLineEnd);
    }
}
