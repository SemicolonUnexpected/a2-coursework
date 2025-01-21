using System.ComponentModel;
using System.Windows.Forms.Design;

namespace a2_coursework.CustomControls;
[Designer(typeof(ParentControlDesigner))]
public partial class CustomTextBox : UserControl {
    public CustomTextBox() {
        InitializeComponent();

        tb.TextChanged += (s, e) => TextChanged?.Invoke(s, e);
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
}
