using System.ComponentModel;

namespace a2_coursework.CustomControls;

[TypeConverter(typeof(CornerRadiiFConverter))]
public struct CornerRadiiF : IEquatable<CornerRadiiF> {

    public static CornerRadiiF Empty;

    public CornerRadiiF(float all) => All = all;

    public CornerRadiiF(float topLeft, float topRight, float bottomLeft, float bottomRight) {
        TopLeft = topLeft;
        TopRight = topRight;
        BottomLeft = bottomLeft;
        BottomRight = bottomRight;
    }

    [RefreshProperties(RefreshProperties.All)]
    public float TopLeft { readonly get; set; } 
    [RefreshProperties(RefreshProperties.All)]
    public float TopRight { readonly get; set; }
    [RefreshProperties(RefreshProperties.All)]
    public float BottomLeft { readonly get; set; }
    [RefreshProperties(RefreshProperties.All)]
    public float BottomRight { readonly get; set; }

    [RefreshProperties(RefreshProperties.All)]
    public float All {
        readonly get {
            return TopRight == TopLeft && TopLeft == BottomLeft && BottomLeft == BottomRight ? TopLeft : -1;
        }

        set {
            TopLeft = value;
            TopRight = value;
            BottomLeft = value;
            BottomRight = value;
        }
    }
    
    public bool Equals(CornerRadiiF other) {
        return TopLeft == other.TopLeft && TopRight == other.TopRight && BottomRight == other.BottomRight && BottomLeft == other.BottomLeft;
    }

    public static CornerRadiiF operator +(CornerRadiiF c1, CornerRadiiF c2) {
        return new CornerRadiiF(c1.TopLeft + c2.TopLeft, c1.TopRight + c2.TopRight, c1.BottomLeft + c2.BottomLeft, c1.BottomRight + c2.BottomRight);
    }

    public static CornerRadiiF operator -(CornerRadiiF c1, CornerRadiiF c2) {
        return new CornerRadiiF(c1.TopLeft - c2.TopLeft, c1.TopRight - c2.TopRight, c1.BottomLeft - c2.BottomLeft, c1.BottomRight - c2.BottomRight);
    }
    public static CornerRadiiF operator -(CornerRadiiF c, int value) {
        return new CornerRadiiF(c.TopLeft - value, c.TopRight - value, c.BottomLeft -  value,c.BottomRight -  value);
    }

    public static CornerRadiiF operator -(CornerRadiiF c, float value) {
        return new CornerRadiiF(c.TopLeft - value, c.TopRight - value, c.BottomLeft -  value,c.BottomRight -  value);
    }

    public static CornerRadiiF operator *(CornerRadiiF c, int factor) {
        return new CornerRadiiF(c.TopLeft * factor, c.TopRight * factor, c.BottomLeft * factor, c.BottomRight * factor);
    }

    public static CornerRadiiF operator *(CornerRadiiF c, float factor) {
        return new CornerRadiiF(c.TopLeft * factor, c.TopRight * factor, c.BottomLeft * factor, c.BottomRight * factor);
    }
}
