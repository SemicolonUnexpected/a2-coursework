using a2_coursework.View.Interfaces;

namespace a2_coursework.View;
public partial class LoginView : Form, ILoginView {
    public LoginView() {
        InitializeComponent();

        OnResize(new EventArgs());
    }

    private void LoginView_Load(object sender, EventArgs e) {
    }

    protected override void OnResize(EventArgs e) {
        pnlLeft.Size = new Size((int)(Width * 0.5f), Height);
        pbBackground.Size = new Size(Width - pnlLeft.Width, Height);
        pbBackground.Location = new Point(pnlLeft.Width, 0);

        // Calculate the image portion to preserve the aspect ratio
        float imagePortionWidth = pbBackground.Width / (float)pbBackground.Height * pbBackground.ImageSize.Height;
        // If the image portion width is greater than the picture width, stretch the picture
        imagePortionWidth = imagePortionWidth > pbBackground.ImageSize.Width ? pbBackground.ImageSize.Width : imagePortionWidth;
        pbBackground.ImagePortion = new Rectangle(pbBackground.ImageSize.Width - (int)imagePortionWidth, 0, (int)imagePortionWidth, pbBackground.ImageSize.Height);

        // Call the base method to invalidate then redraw the form
        base.OnResize(e);
    }

    private void customButton1_Click(object sender, EventArgs e) {
        customPanel1.BackColor = Color.White;
    }

    private void customButton3_Click(object sender, EventArgs e) {

    }

    private void btnChangeTheme_Click(object sender, EventArgs e) {

    }

    private void label1_Click(object sender, EventArgs e) {

    }

    private void pnlLeft_Paint(object sender, PaintEventArgs e) {

    }

    private void customPanel1_Click(object sender, EventArgs e) {

    }
}
