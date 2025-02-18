using System.ComponentModel;

namespace a2_coursework.CustomControls;

// This struct has been annotated with XML documentation comments due to its extensive use within controls with rounded corners

/// <summary>
/// Represents a rounded corner radii for a control.
///</summary>
[TypeConverter(typeof(CornerRadiiFConverter))]
public struct CornerRadiiF : IEquatable<CornerRadiiF> {

    /// <summary>
    /// An empty set of corner radii with all values set to 0.
    ///</summary>
    public static CornerRadiiF Empty = new(0);

    /// <summary>
    /// Initialises a <see cref="CornerRadiiF"/> with all corner radii set to the same value.
    /// </summary>
    /// <param name="all">The radius applied to all corner radii.</param>
    public CornerRadiiF(float all) => All = all;

    /// <summary>
    /// Initialises a <see cref="CornerRadiiF"/> with values for each corner radii
    /// </summary>
    /// <param name="topLeft">The radius of the top-left corner.</param>
    /// <param name="topRight">The radius of the top-right corner.</param>
    /// <param name="bottomLeft">The radius of the bottom-left corner.</param>
    /// <param name="bottomRight">The radius of the bottom-right corner.</param>
    public CornerRadiiF(float topLeft, float topRight, float bottomLeft, float bottomRight) {
        TopLeft = topLeft;
        TopRight = topRight;
        BottomLeft = bottomLeft;
        BottomRight = bottomRight;
    }

    /// <summary>
    /// Gets or sets the corner radius of the top-left corner.
    /// </summary>
    [RefreshProperties(RefreshProperties.All)]
    public float TopLeft { readonly get; set; }

    /// <summary>
    /// Gets or sets the corner radius of the top-right corner.
    /// </summary>
    [RefreshProperties(RefreshProperties.All)]
    public float TopRight { readonly get; set; }

    /// <summary>
    /// Gets or sets the corner radius of the bottom-left corner.
    /// </summary>
    [RefreshProperties(RefreshProperties.All)]
    public float BottomLeft { readonly get; set; }

    /// <summary>
    /// Gets or sets the corner radius of the bottom-right corner.
    /// </summary>
    [RefreshProperties(RefreshProperties.All)]
    public float BottomRight { readonly get; set; }

    /// <summary>
    /// Gets or sets all the corner radii. If all the corner radii are the same, that value is returned, otherwise -1
    /// </summary>
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
        return new CornerRadiiF(c.TopLeft - value, c.TopRight - value, c.BottomLeft - value, c.BottomRight - value);
    }

    public static CornerRadiiF operator -(CornerRadiiF c, float value) {
        return new CornerRadiiF(c.TopLeft - value, c.TopRight - value, c.BottomLeft - value, c.BottomRight - value);
    }

    public static CornerRadiiF operator *(CornerRadiiF c, int factor) {
        return new CornerRadiiF(c.TopLeft * factor, c.TopRight * factor, c.BottomLeft * factor, c.BottomRight * factor);
    }

    public static CornerRadiiF operator *(CornerRadiiF c, float factor) {
        return new CornerRadiiF(c.TopLeft * factor, c.TopRight * factor, c.BottomLeft * factor, c.BottomRight * factor);
    }
}
