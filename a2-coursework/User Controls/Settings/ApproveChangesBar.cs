using a2_coursework.Theming;

namespace a2_coursework.User_Controls.Settings;
public partial class ApproveChangesBar : UserControl, IThemeable {
    private int _height = 40;
    public ApproveChangesBar() {
        InitializeComponent();

        float scalingFactor = DeviceDpi / 96f;
        _height = (int)(scalingFactor * _height);
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        btnSave.ThemeStrong();
        btnCancel.ThemeStrong();
    }

    protected override void OnResize(EventArgs e) {
        Height = _height;
        base.OnResize(e);
    }

    public event EventHandler? Cancel;
    private void btnCancel_Click(object sender, EventArgs e) {
        Cancel?.Invoke(this, e);
    }

    public event EventHandler? Save;
    private void btnSave_Click(object sender, EventArgs e) {
        Save?.Invoke(this, e);
    }
}
