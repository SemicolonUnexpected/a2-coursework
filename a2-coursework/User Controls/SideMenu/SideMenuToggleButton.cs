using a2_coursework.Theming;
using System.ComponentModel;

namespace a2_coursework.UserControls.SideMenu;
public partial class SideMenuToggleButton : UserControl {
    public SideMenuToggleButton() {
        InitializeComponent();
    }

    public void Theme() {
        btn.BackColor = ColorScheme.CurrentTheme.Background;
        btn.HoverColor = ColorScheme.CurrentTheme.Primary;
        btn.ToggledColor = ColorScheme.CurrentTheme.Primary;
        btn.ForeColor = ColorScheme.CurrentTheme.Foreground;
    }

    public event EventHandler? ToggleChanged;
    private void btn_ToggleChanged(object? sender, EventArgs e) => ToggleChanged?.Invoke(sender, e);

    public new Color BackColor {
        get => base.BackColor;
        set {
            btn.BackColor = value;
            base.BackColor = value;
        }
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [DefaultValue("")]
    [TypeConverter(typeof(StringConverter))]
    public new string Text {
        get => btn.Text;
        set => btn.Text = value;
    }

    public bool Toggled {
        get => btn.Toggled;
        set => btn.Toggled = value;
    }

    public ToggleButton ToggleButton {
        get => btn;
    }
}
