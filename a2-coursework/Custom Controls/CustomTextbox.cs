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
    [TypeConverter(typeof(ColorConverter))]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [DefaultValue(typeof(Color), "255, 255, 255")]
    public new Color BackColor {
        get => _internalBackColor;
        set {
            _internalBackColor = value;
            pnl.BackColor = value;
            tb.BackColor = value;
            Invalidate();
        }
    }

    private Color _internalForeColor;
    [Category("Appearance")]
    [TypeConverter(typeof(ColorConverter))]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [DefaultValue(typeof(Color), "255, 255, 255")]
    public new Color ForeColor {
        get => _internalForeColor;
        set {
            _internalForeColor = value;
            tb.ForeColor = value;
            Invalidate();
        }
    }

    [Category("Appearance")]
    public Color BorderColor { get => pnl.BorderColor; set => pnl.BorderColor = value; }

    [Category("Appearance")]
    public float BorderThickness { get => pnl.BorderThickness; set => pnl.BorderThickness = value; }

    [Category("Appearance")]
    [TypeConverter(typeof(FontConverter))]
    [DefaultValue(typeof(Font), "Segoe UI, 9pt")]
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

    private Color _hoverColor;
    [Category("Hover")]
    public Color HoverColor {
        get => _hoverColor;
        set => _hoverColor = value;
    }

    [Category("Placeholder Text")]
    public string PlaceholderText { get => tb.PlaceholderText; set => tb.PlaceholderText = value; }

    [Category("Placeholder Text")]
    public Color PlaceholderTextColor { get => tb.PlaceholderTextColor; set => tb.PlaceholderTextColor = value; }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [DefaultValue("")]
    [TypeConverter(typeof(StringConverter))]
    public new string Text {
        get => tb.Text;
        set => tb.Text = value;
    }

    public bool UsePasswordChar {
        get => tb.UsePasswordChar;
        set => tb.UsePasswordChar = value;
    }

    public new bool Focused {
        get => tb.Focused;
    }

    public CustomTextBox() {
        InitializeComponent();

        tb.TextChanged += (s, e) => TextChanged?.Invoke(s, e);
        tb.KeyPress += (s, e) => KeyPress?.Invoke(s, e);
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        pnl.Size = new Size(Width, Height);

        if (!tb.Multiline) {
            Height = tb.Height + TextBoxInset.Vertical;
        }
    }

    protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
        if (specified is BoundsSpecified.All or BoundsSpecified.Size) {
            TextBoxInset = new Padding((int)(TextBoxInset.Left * factor.Width), (int)(TextBoxInset.Top * factor.Height), (int)(TextBoxInset.Right * factor.Width), (int)(TextBoxInset.Bottom * factor.Height));
            BorderThickness *= factor.Width;
        }
        base.ScaleControl(factor, specified);
    }

    [Browsable(true)]
    public new event EventHandler? TextChanged;
    public new event KeyPressEventHandler? KeyPress;
}
