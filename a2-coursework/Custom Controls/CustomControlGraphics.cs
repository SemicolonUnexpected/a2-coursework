using System.Drawing.Drawing2D;

namespace AS_Coursework.Custom_Controls; 
public static class CustomControlGraphics {
    public static GraphicsPath GetRoundedRectGraphicPath(RectangleF rectangle, float cornerRadius) {
        GraphicsPath path = new();
        float curveSize = cornerRadius * 2F;

        path.StartFigure();
        path.AddArc(rectangle.X, rectangle.Y, curveSize, curveSize, 180, 90);
        path.AddArc(rectangle.Right - curveSize, rectangle.Y, curveSize, curveSize, 270, 90);
        path.AddArc(rectangle.Right - curveSize, rectangle.Bottom - curveSize, curveSize, curveSize, 0, 90);
        path.AddArc(rectangle.X, rectangle.Bottom - curveSize, curveSize, curveSize, 90, 90);
        path.CloseFigure();
        return path;
    }
}
