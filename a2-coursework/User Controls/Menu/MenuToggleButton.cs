using a2_coursework._Helpers;
using a2_coursework.Theming;
using System.ComponentModel;

namespace a2_coursework.UserControls.SideMenu;
public partial class MenuToggleButton : UserControl {
    public MenuToggleButton() {
        InitializeComponent();
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;
        btn.BackColor = ColorScheme.Current.Background;
        btn.HoverColor = ColorScheme.Current.Primary;
        btn.ToggledColor = ColorScheme.Current.Primary;
        btn.ForeColor = ColorScheme.Current.Foreground;
    }

    public event EventHandler? ToggleChanged;
    public event EventHandler<ToggleEventArgs>? PreviewToggleChanged;
    private void btn_ToggleChanged(object? sender, EventArgs e) => ToggleChanged?.Invoke(sender, e);
    private void btn_PreviewToggleChanged(object sender, ToggleEventArgs e) => PreviewToggleChanged?.Invoke(sender, e);

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

    protected override void OnFontChanged(EventArgs e) {
        base.OnFontChanged(e);

        btn.SetFontName(Font.Name);
    }
}
