using a2_coursework.UserControls.SideMenu;
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

    private void lblWelcome_Click(object sender, EventArgs e) {

    }

    private void MasterView_Load(object sender, EventArgs e) {

    }

    private void panel1_Paint(object sender, PaintEventArgs e) {

    }

    private void panel1_Click(object sender, EventArgs e) {
    }

    protected override void OnClick(EventArgs e) {
        base.OnClick(e);

        string value = mainSideMenu1.Debug;
    }
}
