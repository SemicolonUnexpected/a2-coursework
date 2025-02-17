using a2_coursework.Theming;
using System.ComponentModel;

namespace a2_coursework.User_Controls.Menu;
public partial class TopMenuItem : UserControl {
    public new event EventHandler? Click;

    public TopMenuItem() {
        InitializeComponent();

        Theme();

        base.Click += (s, e) => Click?.Invoke(this, EventArgs.Empty);
        lbl.Click += (s, e) => Click?.Invoke(this, EventArgs.Empty);
        pnlDecor.Click += (s, e) => Click?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;
        pnlDecor.BackColor = ColorScheme.CurrentTheme.Primary;
        ForeColor = ColorScheme.CurrentTheme.Foreground;

        lbl.ThemeTitle();
    }

    [DefaultValue("")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Browsable(true)]
    public new string Text {
        get => lbl.Text;
        set {
            lbl.Text = value ?? "";
            OnTextChanged(EventArgs.Empty);
        }
    }

    private bool _selected;
    public bool Selected {
        get => _selected;
        set {
            _selected = value;

            if (_selected) lbl.Font = new Font(lbl.Font, FontStyle.Bold);
            else lbl.Font = new Font(lbl.Font, FontStyle.Regular);

            pnlDecor.Visible = _selected;
        }
    }
}
