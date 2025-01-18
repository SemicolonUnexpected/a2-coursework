using a2_coursework.View.Interfaces;

namespace a2_coursework.View;
public partial class MasterView : Form, IMaster {
    public MasterView() {
    }

    protected override void OnHandleCreated(EventArgs e) {
        base.OnHandleCreated(e);

        InitializeComponent();

        OnResize(EventArgs.Empty);
    }

    private void MasterView_Load(object sender, EventArgs e) {

    }
}
