using a2_coursework.View.Interfaces;
using a2_coursework.Theming;

namespace a2_coursework.View;
public partial class LoginView : Form, ILoginView {
    const int PANEL_GRAPHICS_MARGIN = 10;

    private readonly Image _backgroundImage = Properties.Resources.Login_Background;

    public LoginView() {
        InitializeComponent();

        float scalingFactor = DeviceDpi / 96f;
    }

    protected override void OnResize(EventArgs e) {

        base.OnResize(e);
    }

    public event EventHandler? AttemptSignIn;
    public event EventHandler? UsernameUpdated;
    public event EventHandler? PasswordUpdated;

    private void btnSignIn_Click(object sender, EventArgs e) => AttemptSignIn?.Invoke(sender, e);
    private void tbPassword_Enter(object sender, EventArgs e) => AttemptSignIn?.Invoke(sender, e);
    private void tbUsername_TextChanged(object sender, EventArgs e) => UsernameUpdated?.Invoke(sender, e);
    private void tbPassword_TextChanged(object sender, EventArgs e) => PasswordUpdated?.Invoke(sender, e);

    private void btnSwitchTheme_Click(object sender, EventArgs e) {
        ColourScheme.ToggleColourScheme();

        Invalidate();
    }


    protected override void OnPaint(PaintEventArgs e) {

        // Calculate the image portion to preserve the aspect ratio
        float imagePortionWidth = Width / (float)Height * _backgroundImage.Size.Height;
        // If the image portion width is greater than the picture width, stretch the picture
        imagePortionWidth = imagePortionWidth > _backgroundImage.Size.Width ? _backgroundImage.Size.Width : imagePortionWidth;
        Rectangle srcRect = new(_backgroundImage.Size.Width - (int)imagePortionWidth, 0, (int)imagePortionWidth, _backgroundImage.Size.Height);


        e.Graphics.DrawImage(_backgroundImage, ClientRectangle, srcRect, GraphicsUnit.Pixel);
        base.OnPaint(e);
    }
}
