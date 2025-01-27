using a2_coursework.Theming;

namespace a2_coursework.CustomControls; 
public partial class CustomMessageBoxView : Form, IThemable {
    public CustomMessageBoxView(string text, string caption, MessageBoxButtons buttons) {
        InitializeComponent();

        SetupButtons(buttons);

        Theme();
        Theming.Theme.AppearanceThemeChanged += (s, e) => Theme();
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;
    }

    private void SetupButtons(MessageBoxButtons buttons) {
        switch (buttons) {
            case MessageBoxButtons.OK:
            case MessageBoxButtons.OKCancel:
            default:
                throw new NotImplementedException();
        }
    }
}
