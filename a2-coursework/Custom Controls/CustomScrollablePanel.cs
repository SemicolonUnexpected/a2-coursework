using System.ComponentModel;
using System.Windows.Forms.Design;

namespace a2_coursework.Custom_Controls;
[Designer(typeof(ParentControlDesigner))]
public partial class CustomScrollablePanel : UserControl {
    public CustomScrollablePanel() {
        InitializeComponent();
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        pnl.Size = new(Width + SystemInformation.VerticalScrollBarWidth, Height);
    }
}
