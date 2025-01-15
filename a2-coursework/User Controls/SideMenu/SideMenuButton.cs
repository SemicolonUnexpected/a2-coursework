using a2_coursework.Theming;
using a2_coursework.View.Interfaces;

namespace a2_coursework.UserControls.SideMenu;
public partial class SideMenuButton : UserControl, IThemeable {
    public SideMenuButton() {
        InitializeComponent();
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        btn.BackColor = ColorScheme.CurrentTheme.Background;
        btn.HoverColor = ColorScheme.CurrentTheme.Primary;
        btn.ClickedColor = ColorScheme.CurrentTheme.Primary;
        btn.ForeColor = ColorScheme.CurrentTheme.Foreground;
    }

    public new event EventHandler? Click;
    private void btn_Click(object? sender, EventArgs e) => Click?.Invoke(sender, e);

    public Image IconImage {
        get => btn.Image;
        set => btn.Image = value;
    }

    public new Color BackColor {
        get => base.BackColor;
        set {
            btn.BackColor = value;
            base.BackColor = value;
        }
    }

    public new string Text {
        get => btn.Text;
        set {
            btn.Text = value;
        }
    }
}
