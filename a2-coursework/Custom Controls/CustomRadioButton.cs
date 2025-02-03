using System.ComponentModel;

namespace a2_coursework.CustomControls; 
public partial class CustomRadioButton : Control {
    private float _borderThickness = 1;
    [DefaultValue(1)]
    public float BorderThickness {
        get => _borderThickness;
        set {
            _borderThickness = value;
            Invalidate();
        }
    }

    private float _checkRadius = 1;
    [DefaultValue(1)]
    public float CheckRadius {
        get => _checkRadius;
        set {
            _checkRadius = value;
            Invalidate();
        }
    }

    private Color _checkedColor;
    public Color CheckColor {
        get => _checkedColor;
        set {
            _checkedColor = value;
            Invalidate();
        }
    }

    private bool _checked = false;
    [DefaultValue(false)]
    public bool Checked {
        get => _checked;
        set {
            _checked = value;
            CheckChanged?.Invoke(this, EventArgs.Empty);

            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e) {
        Graphics g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        using Pen pen = new(ForeColor, BorderThickness);
        g.DrawEllipse(pen, Rectangle.Inflate(DisplayRectangle, -(int)(BorderThickness / 2 + 2), -(int)(BorderThickness / 2 + 2)));

        if (Checked) g.FillEllipse(new SolidBrush(CheckColor), Width / 2f - CheckRadius, Height / 2f - CheckRadius, CheckRadius * 2, CheckRadius * 2);

        base.OnPaint(e);
    }

    protected override void OnClick(EventArgs e) {
        Checked = !Checked;

        base.OnClick(e);
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        if (Width != Height) Width = Height;
    }

    public event EventHandler? CheckChanged;

    protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
        CheckRadius *= factor.Width;

        base.ScaleControl(factor, specified);
    }
}
