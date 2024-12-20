using a2_coursework.Custom_Controls;
using System.Drawing.Drawing2D;

namespace AS_Coursework.Custom_Controls; 
internal static class CustomControlGraphics {
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

    public static GraphicsPath GetRoundedRectGraphicPath(RectangleF rectangle, CornerRadiiF cornerRadii) {
        GraphicsPath path = new();

        path.StartFigure();

        if (cornerRadii.TopLeft == 0) {
            path.AddLine(rectangle.X, rectangle.Y, rectangle.X, rectangle.Y);
        }
        else {
            path.AddArc(rectangle.X, rectangle.Y, cornerRadii.TopLeft * 2, cornerRadii.TopLeft * 2, 180, 90);
        }

        if (cornerRadii.TopRight == 0) {
            path.AddLine(rectangle.Right, rectangle.Y, rectangle.Right, rectangle.Y);
        }
        else {
            path.AddArc(rectangle.Right - cornerRadii.TopRight * 2, rectangle.Y, cornerRadii.TopRight * 2, cornerRadii.TopRight * 2, 270, 90);
        }

        if (cornerRadii.BottomRight == 0) {
            path.AddLine(rectangle.Right, rectangle.Bottom, rectangle.Right, rectangle.Bottom);
        }
        else {
            path.AddArc(rectangle.Right - cornerRadii.BottomRight * 2, rectangle.Bottom - cornerRadii.BottomRight * 2, cornerRadii.BottomRight * 2, cornerRadii.BottomRight * 2, 0, 90);
        }

        if(cornerRadii.BottomLeft == 0) {
            path.AddLine(rectangle.X, rectangle.Bottom, rectangle.X, rectangle.Bottom);
        }
        else {
            path.AddArc(rectangle.X, rectangle.Bottom - cornerRadii.BottomLeft * 2, cornerRadii.BottomLeft * 2, cornerRadii.BottomLeft * 2, 90, 90);
        }

        path.CloseFigure();
        return path;
    }
}
