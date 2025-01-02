using System.ComponentModel;
using System.Windows.Forms.Design;

namespace a2_coursework.CustomControls;
[Designer(typeof(ParentControlDesigner))]
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
    public new Color BackColor {
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
    public Padding TextBoxInset {
        get => pnl.Padding;
        set {
            pnl.Padding = value;
            Height = tb.Height + value.Vertical;
        }
    }

    [Browsable(true)]
    public new string Text {
        get => tb.Text;
        set => tb.Text = value;
    }

    public CustomTextBox() {
        InitializeComponent();
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        pnl.Size = new Size(Width, Height);

        if (!tb.Multiline) {
            Height = tb.Height + TextBoxInset.Vertical;
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
