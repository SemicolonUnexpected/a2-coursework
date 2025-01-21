using a2_coursework.Theming;
using a2_coursework.UserControls.SideMenu;
using a2_coursework.View.Interfaces;

namespace a2_coursework.View;
public partial class MasterView : Form, IMaster {
    public MasterView() {
        InitializeComponent();

        sideMenu.GenerateMenu([["q"], ["a", "b", "c"], ["one", "two", "three"], ["q"], ["a", "b", "c"], ["one", "two", "three"], ["q"], ["a", "b", "c"], ["one", "two", "three"]]);
        ((SideMenuToggleButton)sideMenu[0]).Toggled = true;

        Theme();

        DisplayChildForm(new TestView());
    }

    public void Theme() {
        sideMenu.Theme();
        topBar.Theme();
        BackColor = ColorScheme.CurrentTheme.Background;
    }

    private Form? _childForm;
    public Form? ChildForm {
        get => _childForm;
        set => _childForm = value;
    }


    public void DisplayChildForm(Form childForm) {
        ChildForm = childForm;

        childForm.TopLevel = false;
        childForm.Width = pnlHolder.Width;
        childForm.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

        pnlHolder.Controls.Add(childForm);

        childForm.Show();

        SetScrollOptions();
    }

    private void SetScrollOptions() {
        if (ChildForm is null) return;

        if (pnlHolder.Height < ChildForm.Height) {
            sb.Visible = true;
            sb.LargeChange = pnlHolder.Height;
            sb.Maximum = ChildForm.Height - pnlHolder.Height;
        }
        else {
            sb.Visible = false;
            sb.Value = 0;
        }
    }
    
    private void sb_ValueChanged(object sender, EventArgs e) {
        if (ChildForm is null) return;

        ChildForm.Location = new Point(0, -sb.Value);
    }

    protected override void OnResize(EventArgs e) {
        SetScrollOptions();

        base.OnResize(e);
    }
}
