using System.ComponentModel;

namespace a2_coursework.CustomControls;
public partial class CustomTextBox : UserControl {
    [Category("Appearance")]
    public CornerRadiiF CornerRadii {
        get => pnl.CornerRadii;
        set {
            pnl.CornerRadii = value;
            Invalidate();
        }
    }

    private Color _internalBackColor;
    [Category("Appearance")]
    public  Color InternalBackColor {
        get => _internalBackColor;
        set {
            _internalBackColor = value;
            pnl.BackColor = value;
            tb.BackColor = value;
            Invalidate();
        }
    }

    private Color _internalHoverColor;
    [Category("Appearance")]
    public Color InternalHoverColor {
        get => _internalHoverColor;
        set => _internalHoverColor = value;
    }

    [Category("Appearance")]
    public Color BorderColor { get => pnl.BorderColor; set => pnl.BorderColor = value; }

    [Category("Appearance")]
    public float BorderThickness { get => pnl.BorderThickness; set => pnl.BorderThickness = value; }

    [Category("Appearance")]
    public override Font Font {
        get => tb.Font;
        set {
            int newHeight = TextRenderer.MeasureText("Text", value).Height;
            int oldHeight = TextRenderer.MeasureText("Text", tb.Font).Height;

            Height += newHeight - oldHeight;

            tb.Font = value;
        }
    }

    [Category("Appearance")]
    public new Padding Padding {
        get => pnl.Padding;
        set => pnl.Padding = value;
    }

    public CustomTextBox() {
        InitializeComponent();
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        if (!tb.Multiline) {
            Height = TextRenderer.MeasureText("Text", Font).Height + Padding.Vertical;
        }
    }

    protected override void OnForeColorChanged(EventArgs e) {
        tb.ForeColor = ForeColor;

        base.OnForeColorChanged(e);
    }

    private void TextBoxHover(object sender, EventArgs e) {
        tb.BackColor = InternalHoverColor;
    }
}
