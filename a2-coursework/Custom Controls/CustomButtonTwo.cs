using AS_Coursework.Custom_Controls;
using System.ComponentModel;

namespace a2_coursework.Custom_Controls;
public partial class CustomButtonTwo : CustomPanel {
    private Color _backColor;

    [Category("Appearance")]
    public Color HoverColor { get; set; }

    [Category("Appearance")]
    public Color ClickedColor { get; set; }

    public CustomButtonTwo() {
        _backColor = BackColor;
    }

    protected override void OnMouseEnter(EventArgs e) {
        base.OnMouseEnter(e);

        BackColor = HoverColor;
    }

    protected override void OnMouseLeave(EventArgs e) {
        base.OnMouseLeave(e);

        BackColor = _backColor;
    }

    protected override void OnMouseDown(MouseEventArgs e) {
        base.OnMouseDown(e);

        BackColor = ClickedColor;
    }

    protected override void OnMouseUp(MouseEventArgs e) {
        base.OnMouseUp(e);

        BackColor = _backColor;
    }
}
