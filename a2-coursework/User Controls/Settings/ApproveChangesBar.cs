using a2_coursework.View.Interfaces;

namespace a2_coursework.User_Controls.Settings; 
public partial class ApproveChangesBar : UserControl, IThemable {
    private int _height = 40;
    public ApproveChangesBar() {
        InitializeComponent();

        float scalingFactor = DeviceDpi / 96f;
        _height = (int)(scalingFactor * _height);
    }

    public void Theme() {
        
    }

    protected override void OnResize(EventArgs e) {
        Height = _height;
        base.OnResize(e);
    }
}
