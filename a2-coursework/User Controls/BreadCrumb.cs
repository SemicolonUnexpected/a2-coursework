namespace a2_coursework.UserControls; 
public partial class BreadCrumb : Control {
    public BreadCrumb() {

    }

    public void Theme() {

    }

    private Image _breadCrumbSeparator;
    public Image BreadCrumbSeparator {
        get => _breadCrumbSeparator;
        set {
             _breadCrumbSeparator = value;
            Invalidate();
        }
    }

    private Size _breadCrumbSeparatorSize;
    public Size BreadCrumbSeparatorSize {
        get => _breadCrumbSeparatorSize;
        set {
            _breadCrumbSeparatorSize = value;
            Invalidate();
        }
    }

    private readonly List<string> crumbs = new();
    public string this[int index] {
        get => crumbs[index];
        set {
            crumbs[index] = value;
            Invalidate();
        }
    }

    public void Add(params string[] values) => crumbs.AddRange(values);
    public bool Remove(string value) => crumbs.Remove(value);
    public bool Contains(string value) => crumbs.Contains(value);
    public int Length => crumbs.Count;

    private int _gap = 4;
    public int Gap {
        get => _gap;
        set {
            _gap = value;
            OnResize(EventArgs.Empty);
        }
    }

    private void CreateBreadCrumbs() {
        Rectangle workingArea = new(
            ClientRectangle.X + Padding.Left,
            ClientRectangle.Y * Padding.Right,
            ClientRectangle.Width - Padding.Horizontal,
            ClientRectangle.Height - Padding.Vertical
            );

        for (int i = Length; i > 0; --i) {

        }
    }

    protected override void OnPaint(PaintEventArgs e) {
        Graphics g = e.Graphics;



        base.OnPaint(e);
    }
}
