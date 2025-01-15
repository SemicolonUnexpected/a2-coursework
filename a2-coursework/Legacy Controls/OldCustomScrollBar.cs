using System.ComponentModel;
using System.Windows.Forms.Design;

namespace AS_Coursework.Custom_Controls;
[Designer(typeof(ParentControlDesigner))]
public partial class OldCustomScrollBar : Control {
    #region Fields

    // Custom appearance fields
    private Brush _thumbBrush = new SolidBrush(Color.Gray);
    private Rectangle _thumbRectangle = new(0, 0, 0, 0);
    private Rectangle _channelRectangle;
    private Padding _channelPadding = new(0, 0, 0, 0);

    // Progress bar fields that are the same as the default windows scrollbar
    private int _value = 0;
    private int _maximum = 100;
    private int _minimum = 0;
    private double _mouseWheelSensitivity = 1;

    // Other fields
    private bool _isDragging = false;
    private int _grabY = 0;

    #endregion

    public OldCustomScrollBar() {
        DoubleBuffered = true;
    }

    #region Properties

    // Use the BackColor as is, but move it within the designer to a more intuitive location
    [Category("_CustomScrollBar Appearance")]
    public override Color BackColor { get => base.BackColor; set => base.BackColor = value; }

    [Category("_CustomScrollBar Further Options")]
    public Padding ChannelPadding {
        get => _channelPadding;
        set {
            _channelPadding = value;

            Invalidate();
        }
    }

    [Category("_CustomScrollBar Appearance")]
    public Color ThumbColor {
        get => (_thumbBrush as SolidBrush)!.Color;
        set {
            _thumbBrush = new SolidBrush(value);
            Invalidate();
        }
    }

    // An advanced property that can only be accessed through code
    [Browsable(false)]
    public Brush ThumbBrush {
        get => _thumbBrush;
        set {
            _thumbBrush = value;
            Invalidate();
        }
    }

    [Category("_CustomScrollBar Appearance")]
    public int ThumbHeight {
        // get => _thumbHeight;
        set {
            // Ensure the thumb is not too large to fit inside the scroll bar
            Invalidate();
        }
    }


    [Category("_CustomScrollBar Scroll")]
    public int Value {
        get => _value;
        set {
            value = Math.Clamp(value, Minimum, Maximum);

            // Only change the value if there is an actual difference
            // This ensures the value changed event is called at the correct time
            // And allows performace gains as the control is not redrawn
            if (value == _value) return;

            _value = value;
            ValueChanged?.Invoke(this, EventArgs.Empty);

            Invalidate();
        }
    }

    [Category("_CustomScrollBar Scroll")]
    public int Minimum {
        get => _minimum;
        set {
            if (DesignMode && Maximum <= value) return;
            else if (Maximum <= value) throw new ArgumentOutOfRangeException(nameof(value), "The minimum must be less than the maximum");

            _minimum = value;
            Invalidate();
        }
    }

    [Category("_CustomScrollBar Scroll")]
    public int Maximum {
        get => _maximum;
        set {
            if (DesignMode && Minimum >= value) return;
            else if (Minimum >= value) throw new ArgumentOutOfRangeException(nameof(value), "The maximum must be greater than the minimum");

            _maximum = value;
            Invalidate();
        }
    }

    [Category("_CustomScrollBar Scroll")]
    public double MouseWheelSensitivity {
        get => _mouseWheelSensitivity;
        set {
            _mouseWheelSensitivity = value;
        }
    }

    #endregion

    #region Events

    [Category("_CustomScrollBar")]
    public event EventHandler? Scroll;
    [Category("_CustomScrollBar")]
    public event EventHandler? ValueChanged;

    #endregion

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        // Resize the thumb rectangle to fit with the padding
        _thumbRectangle.Width = _channelRectangle.Width;
    }

    // Override the OnPaint event to draw the control
    protected override void OnPaint(PaintEventArgs e) {
        // All this base method does is send the event to any listeners
        // This can be found when decompiling this base method's definition
        // So I guess this is good practice to call it then
        base.OnPaint(e);

        Graphics graphics = e.Graphics;

    }

    protected override void OnMouseDown(MouseEventArgs e) {
        base.OnMouseDown(e);

        // Set the control to the dragging state if the mouse clicks in the channel
        Point mousePoint = e.Location;
        if (e.Button == MouseButtons.Left && _channelRectangle.Contains(mousePoint)) {
            // Set the grab point to the mouse Y position if it is on the thumb or the middle of the thumb if it is not
          //  _grabY = mousePoint.Y <  ? mousePoint.Y - _thumbRectangle.Top : _thumbRectangle.Height / 2;
            _isDragging = true;

            //TrySetThumbHeight();
        }
    }

    private void SetRectanglesToSizeAndPadding() {
//            _channelRectangle.X = value.Left;
//            _channelRectangle.Y = value.Top;
//            _channelRectangle.Width = Width - value.Horizontal;
//            _channelRectangle.Height = Height - value.Vertical;
//
//            _thumbRectangle.X = _channelRectangle.X;
//            _thumbRectangle.Width = _channelRectangle.Width;
//
    }
}
