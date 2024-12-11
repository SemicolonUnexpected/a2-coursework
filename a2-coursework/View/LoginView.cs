using a2_coursework.View.Interfaces;
using a2_coursework.Theming;

namespace a2_coursework.View;
public partial class LoginView : Form, ILoginView {
    public LoginView() {
        InitializeComponent();

        OnResize(new EventArgs());

        FixFormatting();

        Theme();
    }

    private void Theme() {
        pnlLeft.BackColor = ColourScheme.CurrentTheme.PrimaryBackground;

        btnSignIn.BackColor = ColourScheme.CurrentTheme.Blue;
        btnSignIn.HoverColor = ColourScheme.CurrentTheme.Red;
        btnSignIn.ClickedColor = ColourScheme.CurrentTheme.Red;
    }

    // Necessary as dpi scaling does not work :(
    private void FixFormatting() {
        float scalingFactor = DeviceDpi / 96f;

        btnSignIn.Location = new((int)(130 * scalingFactor), (int)(320 * scalingFactor));
        btnSwitchTheme.Location = new((int)(363 * scalingFactor), (int)(5 * scalingFactor));
        lblSignIn.Location = new((int)(82 * scalingFactor), (int)(115 * scalingFactor));
        pbShowPassword.Location = new((int)(6 * scalingFactor), (int)(6 * scalingFactor));
        lblWelcome.Location = new((int)(79 * scalingFactor), (int)(70 * scalingFactor));
        tbUsername.Location = new((int)(90 * scalingFactor), (int)(180 * scalingFactor));
        tbPassword.Location = new((int)(90 * scalingFactor), (int)(240 * scalingFactor));
        pbShowPassword.Location = new((int)(194 * scalingFactor), (int)(6 * scalingFactor));
        pbShowPassword.Size = new((int)(25 * scalingFactor), (int)(25 * scalingFactor));
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

    public event EventHandler? AttemptSignIn;
    private void btnSignIn_Click(object sender, EventArgs e) => AttemptSignIn?.Invoke(sender, e);
}
