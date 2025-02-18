using a2_coursework._Helpers;
using a2_coursework.Theming;
using System.ComponentModel;

namespace a2_coursework.UserControls.SideMenu;
public partial class MenuButton : UserControl, IThemeable {
    public MenuButton() {
        InitializeComponent();
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        btn.BackColor = ColorScheme.Current.Background;
        btn.HoverColor = ColorScheme.Current.Primary;
        btn.ClickedColor = ColorScheme.Current.Primary;
        btn.ForeColor = ColorScheme.Current.Foreground;
    }

    public void SetToolTipVisibility() { }

    public void SetFont() {
        btn.SetFontName(Theming.Theme.Current.FontName);
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


    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [DefaultValue("")]
    [TypeConverter(typeof(StringConverter))]
    public new string Text {
        get => btn.Text;
        set {
            btn.Text = value;
        }
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);
        btn.ImageRectangle = new Rectangle(btn.Width - (btn.ImageRectangle.Width + btn.Padding.Right), (btn.Height - btn.ImageRectangle.Height) / 2, btn.ImageRectangle.Width, btn.ImageRectangle.Height);
    }
}
