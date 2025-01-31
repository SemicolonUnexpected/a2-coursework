using a2_coursework.Theming;

namespace a2_coursework.User_Controls.Settings;
public partial class ApproveChangesBar : UserControl, IThemeable {
    private int _height = 41;
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
        base.OnResize(e);
        Height = _height;
    }

    public event EventHandler? Cancel;
    private void btnCancel_Click(object sender, EventArgs e) {
        Cancel?.Invoke(this, e);
    }

    public event EventHandler? Save;
    private void btnSave_Click(object sender, EventArgs e) {
        Save?.Invoke(this, e);
    }

    private bool _isLoading = false;
    public bool IsLoading {
        get => _isLoading;
        set {
            _isLoading = value;

            if (_isLoading) {
                btnSave.Text = "Saving...";
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
            }
            else {
                btnSave.Text = "Save";
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }
    }
}
