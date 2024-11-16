using System.ComponentModel;
//using AS_Coursework._Helpers;

namespace AS_Coursework.Custom_Controls;
// Must be declared as public partial to show up in designer
public partial class MenuItem : UserControl {
    // Fields
    private string _text = "";
    private Image? _image;
    private Color _hoverColour = Color.FromArgb(25, 25, 60);
    private Color _baseColor = Color.FromArgb(30, 30, 70);
    private int _imagePadding = 20;

    public MenuItem() {
        InitializeComponent();

        SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

        // Setup events
        MouseEnter += Highlight;
        lbl.MouseEnter += Highlight;
        pb.MouseEnter += Highlight;

        MouseLeave += ClearHighlight;
        lbl.MouseLeave += ClearHighlight;
        pb.MouseLeave += ClearHighlight;

        // Use mouse down event as Click event is unreliable
        MouseDown += Clicked;
        lbl.MouseDown += Clicked;
        pb.MouseDown += Clicked;

        // Call OnResize to ensure correct formatting        
        OnResize(EventArgs.Empty);
    }

    #region Properties

    [Category("_MenuItem")]
    public string MenuText {
        get => _text;
        set {
            _text = value;
            lbl.Text = value;
        }
    }

    [Category("_MenuItem")]
    public Image? Image {
        get => _image;
        set {
            _image = value;
            pb.Image = value;
        }
    }

    [Category("_MenuItem")]
    public Color HoverColour { get => _hoverColour; set => _hoverColour = value; }

    [Category("_MenuItem")]
    public Color BaseColor {
        get => _baseColor;
        set {
            _baseColor = value;
            BackColor = value;
        }
    }

    [Category("_MenuItem")]
    public int ImagePadding {
        get => _imagePadding;
        set {
            _imagePadding = value;
            OnResize(EventArgs.Empty);
        }
    }

    [Category("_MenuItem")]
    public override Font Font {
        get => lbl.Font;
        set {
            lbl.Font = value;
            base.Font = value;
        }
    }


    #endregion

    #region Events

    // Event handlers
    [Browsable(true), Category("_MenuItem")]
    public event EventHandler? MenuClick;

    private void Clicked(object? sender, MouseEventArgs e) {
        if (e.Button == MouseButtons.Left) MenuClick?.Invoke(this, e);
    }

    // Handle highlighting of menu item
    // The mouse enter an leave events can be unreliable
    // so checking the mouse position with a timer may be a better option
    private void Highlight(object? sender, EventArgs e) {
        BackColor = HoverColour;
        lbl.BackColor = HoverColour;
    }

    private void ClearHighlight(object? sender, EventArgs e) {
        BackColor = BaseColor;
        lbl.BackColor = BaseColor;
    }

    #endregion

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        pb.Left = ImagePadding;
        lbl.Left = pb.Width + 2 * ImagePadding;

//        lbl.CenterY();
//        pb.CenterY();
    }
}
