using System.ComponentModel;

namespace AS_Coursework.Custom_Controls;
public partial class CustomScrollablePanel : UserControl {
    private Control? _child;
    private int? _baseHeight;

    [Category("_CustomScrollablePanel")]
    public Control? ChildControl {
        get => _child;
        set {
            _child = value;

            if (_child is null) return;

            // Bind to the control's mouse wheel event
            _child.MouseWheel += _child_MouseWheel;

            // Setup control display settings
            if (_child is Form form) {
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
            }

            _child.Visible = false;
            _child.Enabled = true;

            // Display in panel
            pnlChild.Controls.Add(_child);
            _child.SendToBack();
            _child.Visible = true;
            _child.Show();

            // Redraw form
            Refresh();
        }
    }

    private void _child_MouseWheel(object? sender, MouseEventArgs e) {
    }

    public CustomScrollablePanel() {
        InitializeComponent();

        SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        // Avoid null references to the child control before it has been initialised
        if (ChildControl is null) return;

        if (_baseHeight <= Height) {
            // Hide the scroll bar if the control is big enough and scale the form appropriately
            sb.Hide();
            ChildControl.Height = pnlChild.Height;
        }
        else {
            // Show the scroll bar when the control is too small to see the whole child control and scale the control appropriately
            sb.Show();

            // Scale the thumb of the scroll bar
            sb.Maximum = ChildControl.Height - Height;
            int sbRange = sb.Maximum - sb.Minimum;
            int thumbHeight = Height - sbRange;

            // Ensure the form is not minimised before making this check to avoid an exception
            // if (Form.ActiveForm?.WindowState != FormWindowState.Minimized) sb.ThumbSize = new Size(sb.ThumbSize.Width, Math.Clamp(thumbHeight, 30, Height - sb.ChannelPadding.Vertical));

            // Set the scroll bar value to the correct position
            sb.Value = 0;

            // Scale the child control
            ChildControl.Height = (int)_baseHeight!;
        }
    }

    private void sb_ValueChanged(object sender, EventArgs e) {
        if (_child is null) return;
        _child.Location.Offset(0, -sb.Value);
        Refresh();
    }

    private void sb_Click(object sender, EventArgs e) {
        MessageBox.Show("Test");
    }
}
