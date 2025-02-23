using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace a2_coursework.CustomControls;
public class CornerRadiiFConverter : TypeConverter {
    public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType) {
        if (sourceType == typeof(string)) return true;

        return CanConvertFrom(sourceType);
    }

    public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType) {
        if (destinationType == typeof(string)) return true;
        if (destinationType == typeof(InstanceDescriptor)) return true;

        return base.CanConvertTo(context, destinationType);
    }

    /// <summary>
    ///  Converts the given object to the converter's native type.
    /// </summary>
    public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value) {
        if (value is string stringValue) {
            stringValue = stringValue.Trim();
            if (stringValue.Length == 0) {
                return null;
            }

            // Parse 4 float values.
            culture ??= CultureInfo.CurrentCulture;

            string[] tokens = stringValue.Split([culture.TextInfo.ListSeparator[0]]);
            float[] values = new float[tokens.Length];
            TypeConverter floatConverter = TypeDescriptor.GetConverter(typeof(float));
            for (int i = 0; i < values.Length; i++) {
                // Note: ConvertFromString will raise exception if value cannot be converted.
                values[i] = (float)floatConverter.ConvertFromString(context, culture, tokens[i])!;
            }

            if (values.Length == 4) {
                return new CornerRadiiF(values[0], values[1], values[2], values[3]);
            }

            // So you just have to type in one value to set them all
            if (values.Length == 1) {
                return new CornerRadiiF(values[0]);
            }

            if (values.Length != 4) {
                throw new ArgumentException("Failed to parse");
            }
        }

        return base.ConvertFrom(context, culture, value);
    }

    public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType) {
        if (value is CornerRadiiF cornerRadiiF) {
            if (destinationType == typeof(string)) {
                culture ??= CultureInfo.CurrentCulture;

                string sep = culture.TextInfo.ListSeparator + " ";
                TypeConverter floatConverter = TypeDescriptor.GetConverter(typeof(float));
                string[] args =
                [
                    floatConverter.ConvertToString(context, culture, cornerRadiiF.TopLeft)!,
                    floatConverter.ConvertToString(context, culture, cornerRadiiF.TopRight)!,
                    floatConverter.ConvertToString(context, culture, cornerRadiiF.BottomLeft)!,
                    floatConverter.ConvertToString(context, culture, cornerRadiiF.BottomRight)!
                ];
                return string.Join(sep, args);
            }
            else if (destinationType == typeof(InstanceDescriptor)) {
                var ctor = typeof(CornerRadiiF).GetConstructor([typeof(float), typeof(float), typeof(float), typeof(float)]);
                if (ctor is not null) {
                    return new InstanceDescriptor(ctor, new object[] { cornerRadiiF.TopLeft, cornerRadiiF.TopRight, cornerRadiiF.BottomLeft, cornerRadiiF.BottomRight });
                }
            }
        }

        return base.ConvertTo(context, culture, value, destinationType);
    }

    public override object CreateInstance(ITypeDescriptorContext? context, IDictionary propertyValues) {
        ArgumentNullException.ThrowIfNull(propertyValues);

        var original = context?.PropertyDescriptor?.GetValue(context.Instance);
        if (original is CornerRadiiF originalCornerRadiiF) {
            float all = (float)propertyValues[nameof(CornerRadiiF.All)]!;
            if (originalCornerRadiiF.All != all) {
                return new CornerRadiiF(all);
            }
        }

        return new CornerRadiiF(
            (float)propertyValues[nameof(CornerRadiiF.TopLeft)]!,
            (float)propertyValues[nameof(CornerRadiiF.TopRight)]!,
            (float)propertyValues[nameof(CornerRadiiF.BottomLeft)]!,
            (float)propertyValues[nameof(CornerRadiiF.BottomRight)]!
            );
    }

    public override bool GetCreateInstanceSupported(ITypeDescriptorContext? context) => true;

    public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext? context, object value, Attribute[]? attributes) {
        PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(CornerRadiiF), attributes);
        return props.Sort([nameof(CornerRadiiF.All), nameof(CornerRadiiF.TopLeft), nameof(CornerRadiiF.TopRight), nameof(CornerRadiiF.BottomLeft), nameof(CornerRadiiF.BottomRight)]);
    }

    public override bool GetPropertiesSupported(ITypeDescriptorContext? context) => true;
}
