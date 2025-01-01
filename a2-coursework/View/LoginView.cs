using a2_coursework.View.Interfaces;
using a2_coursework.Theming;

namespace a2_coursework.View;
public partial class LoginView : Form, ILoginView {
    const int PANEL_GRAPHICS_MARGIN = 10;

    public LoginView() {
        InitializeComponent();

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

    private void improvedTextbox1_TextChanged(object sender, EventArgs e) {

    }
}
