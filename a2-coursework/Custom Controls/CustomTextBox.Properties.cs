using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;

namespace a2_coursework.CustomControls;
public partial class CustomTextBox {
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
    [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
    public string PlaceholderText { get => tb.PlaceholderText; set => tb.PlaceholderText = value; }

    [Category("Placeholder Text")]
    public Color PlaceholderTextColor { get => tb.PlaceholderTextColor; set => tb.PlaceholderTextColor = value; }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
    [DefaultValue("")]
    [TypeConverter(typeof(StringConverter))]
    public new string Text {
        get => tb.Text;
        set => tb.Text = value;
    }

    public HorizontalAlignment TextAlign {
        get => tb.TextAlign;
        set => tb.TextAlign = value;
    }

    public bool UsePasswordChar {
        get => tb.UsePasswordChar;
        set => tb.UsePasswordChar = value;
    }

    public new bool Focused {
        get => tb.Focused;
    }

    public int MaxLength {
        get => tb.MaxLength;
        set => tb.MaxLength = value;
    }

    public bool MultiLine {
        get => tb.Multiline;
        set => tb.Multiline = value;
    }

    //private bool _enabled = true;
    //[DefaultValue(true)]
    //public new bool Enabled {
    //    get => _enabled;
    //    set {
    //        _enabled = value;
    //        ;
    //    }
    //}

    [Browsable(true)]
    public new event EventHandler? TextChanged;
    public new event KeyPressEventHandler? KeyPress {
        add => tb.KeyPress += value;
        remove => tb.KeyPress -= value;
    }

    public new event EventHandler? Leave {
        add => tb.Leave += value;
        remove => tb.Leave -= value;
    }

    public new event EventHandler? Enter {
        add => tb.Enter += value;
        remove => tb.Enter -= value;
    }
}
