using AS_Coursework.Custom_Controls;
using System.ComponentModel;

namespace a2_coursework.Custom_Controls; 
public partial class CustomBasicButton : CustomPanel {
    [Category("Appearance")]
    public Color HoverColor { get; set; }

    [Category("Appearance")]
    public Color ClickedColor { get; set; } 

    [Category("Appearance")]
    public Color BorderHoverColor { get; set; }

    [Category("Appearance")]
    public Color BorderClickedColor { get; set; }

    private Color _backColor;
    [Category("Appearance")]
    public new Color BackColor {
        get {
            return _backColor;
        }
        set {
            _backColor = value;
            if (!ClientRectangle.Contains(MousePosition) || DesignMode) {
                base.BackColor = value;
            }
        }
    }

    public CustomBasicButton() {
        BackColor = base.BackColor;
        //int scalingFactor = DeviceDpi / 96;
        //Location = new Point(Location.X * scalingFactor, Location.Y * scalingFactor);
    }

    protected override void OnMouseEnter(EventArgs e) {
        base.OnMouseEnter(e);

        if(ClientRectangle.Contains(PointToClient(MousePosition)) && HoverColor != Color.Empty) base.BackColor = HoverColor;
    }

    protected override void OnMouseLeave(EventArgs e) {
        base.OnMouseLeave(e);

        if (!ClientRectangle.Contains(PointToClient(MousePosition))) base.BackColor = BackColor;
    }

    protected override void OnMouseDown(MouseEventArgs e) {
        base.OnMouseDown(e);

        if (ClickedColor != Color.Empty) base.BackColor = ClickedColor;
    }

    protected override void OnMouseUp(MouseEventArgs e) {
        base.OnMouseUp(e);

        if (HoverColor != Color.Empty) base.BackColor = HoverColor;
    }
}
