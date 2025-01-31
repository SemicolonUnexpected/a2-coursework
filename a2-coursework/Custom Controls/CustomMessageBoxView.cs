using a2_coursework.Theming;

namespace a2_coursework.CustomControls;
public partial class CustomMessageBoxView : Form, IThemeable {
    public CustomMessageBoxView(string text, string caption, MessageBoxButtons buttons) {
        InitializeComponent();

        lblText.Text = text;
        lblTitle.Text = caption;

        SetupButtons(buttons);

        Theme();
        Theming.Theme.AppearanceThemeChanged += (s, e) => Theme();
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        lblTitle.ThemeTitle();
        lblText.ThemeSubtitle();

        pnlBottom.BackColor = ColorScheme.CurrentTheme.Background;
        flp.BackColor = ColorScheme.CurrentTheme.Background;
        pnlDecor.BackColor = ColorScheme.CurrentTheme.Primary;

        btnOk.ThemeStrong();
        btnCancel.ThemeStrong();
    }

    private void SetupButtons(MessageBoxButtons buttons) {
        switch (buttons) {
            case MessageBoxButtons.OK:
                btnCancel?.Hide();
                break;
            case MessageBoxButtons.OKCancel:
                break;
            default:
                throw new NotImplementedException();
        }
    }

    private void btnCancel_Click(object sender, EventArgs e) {
        DialogResult = DialogResult.Cancel;

        Close();
    }

    private void btnOk_Click(object sender, EventArgs e) {
        DialogResult = DialogResult.OK;

        Close();
    }
}
