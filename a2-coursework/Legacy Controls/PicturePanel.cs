using System.ComponentModel;
using System.Windows.Forms.Design;

namespace AS_Coursework.Custom_Controls;

[Designer(typeof(ParentControlDesigner))]
public partial class PicturePanel : Control {

    private Image? _image;
    [Category("Image"), Description("The image that will be displayed in the picture panel. The image portion is automatically updated when the image is set")]
    public Image? Image {
        get => _image;
        set {
            _image = value;
            if (value is not null) ImagePortion = new Rectangle(0, 0, value.Width, value.Height);
            Invalidate();
        }
    }

    [Category("Image")]
    public Size ImageSize {
        get => _image.Size;
    }

    private Rectangle? _imagePortion;
    [Category("Image")]
    public Rectangle? ImagePortion {
        get => _imagePortion;
        set {
            _imagePortion = value;
            Refresh();
        }
    }
    public PicturePanel() {
        DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e) {
        base.OnPaint(e);

        if (_image is null || _imagePortion is null) return;

        e.Graphics.DrawImage(_image, ClientRectangle, (Rectangle)ImagePortion!, GraphicsUnit.Pixel);
    }
}