using AS_Coursework.Custom_Controls;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Markup;

namespace AS_Coursework.Custom_Controls;
public partial class CustomButton : Button {

    #region Fields

    private Color _borderColour = Color.White;
    private int _borderWidth = 0;
    private int _cornerRadius = 0;
    private Size _imageSize;
    private Image? _image;

    #endregion

    #region Custom properties

    [Category("_CustomButton Appearance")]
    public Color BorderColor {
        get => _borderColour;
        set {
            _borderColour = value;
            Invalidate();
        }
    }

    [Category("_CustomButton Appearance")]
    public int BorderWidth {
        get => _borderWidth;
        set {
            _borderWidth = value;
            Invalidate();
        }
    }

    [Category("_CustomButton Appearance")]
    public int CornerRadius {
        get => _cornerRadius;
        set {
            _cornerRadius = value;
            Invalidate();
        }
    }

    [Category("_CustomButton Appearance")]
    new public Image? Image {
        get => _image;
        set {
            _image = value;
            if (Image is null) return;
            base.Image = new Bitmap(Image, _imageSize);
        }
    }

    [Category("_CustomButton Appearance")]
    public Size ImageSize {
        get => _imageSize;
        set {
            _imageSize = value;
            if (Image is null) return;
            base.Image = new Bitmap(Image, _imageSize);
        }
    }

    #endregion

    public CustomButton() {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        Size = new Size(150, 40);
        BackColor = Color.White;
        ForeColor = Color.Black;
        ImageSize = Size;
    }

    protected override void OnPaint(PaintEventArgs e) {
        base.OnPaint(e);

        Graphics graphics = e.Graphics;

        Rectangle rectangleSurface = ClientRectangle;
        Rectangle borders = Rectangle.Inflate(rectangleSurface, -BorderWidth, -BorderWidth);

        int smoothSize = BorderWidth > 0 ? BorderWidth : 2;

        if (CornerRadius > 2) {
            using GraphicsPath pathSurface = CustomControlGraphics.GetRoundedRectGraphicPath(rectangleSurface, CornerRadius);
            using GraphicsPath pathBorder = CustomControlGraphics.GetRoundedRectGraphicPath(borders, CornerRadius - BorderWidth);
            using Pen penSurface = new(Parent.BackColor, smoothSize);
            using Pen penBorder = new(BorderColor, BorderWidth);

            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Region = new Region(pathSurface);

            graphics.DrawPath(penSurface, pathSurface);

            if (BorderWidth >= 1) graphics.DrawPath(penBorder, pathBorder);
        }
        else {
            graphics.SmoothingMode = SmoothingMode.None;
            Region = new Region(rectangleSurface);

            if (BorderWidth <= 1) return;

            using Pen penBorder = new(BorderColor, BorderWidth);

            penBorder.Alignment = PenAlignment.Inset;
            graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
        }
    }

    protected override void OnBackColorChanged(EventArgs e) {
        base.OnBackColorChanged(e);
        Invalidate();
    }
}
