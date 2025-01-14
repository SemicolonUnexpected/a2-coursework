using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Text;

namespace a2_coursework.User_Controls;
public class JaggedStringArrayConverter : TypeConverter {
    public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType) {
        if (sourceType == typeof(string)) return true;

        return CanConvertFrom(sourceType);
    }

    public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType) {
        if (destinationType == typeof(string)) return true;
        if (destinationType == typeof(InstanceDescriptor)) return true;
        
        return base.CanConvertTo(context, destinationType);
    }

    public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value) {
        if (value is string stringValue) {
            stringValue.Trim();
            if (stringValue.Length == 0) {
                return null;
            }

            string[] arrays = stringValue.Split(';');
            string[][] values = new string[arrays.Length][];
            for (int i = 0; i < arrays.Length; i++) {
                values[i] = arrays[i].Split(",");
            }

            return values;
        }

        return base.ConvertFrom(context, culture, value);
    }

    public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType) {
        if (value is string[][] arrays) {
            if (destinationType == typeof(string)) {
                if (arrays is null) return null;

                string[] arrayStrings = new string[arrays.Length];

                for (int i = 0; i <= arrays.Length; i++) {
                    arrayStrings[i] = string.Join(',', arrays[i]);
                }

                return string.Join(';', arrayStrings);
            }
            else if (destinationType == typeof(InstanceDescriptor)) {
                var ctor = typeof(string[][]).GetConstructor([typeof(string[][])]);
                if (ctor is not null) {
                    return new InstanceDescriptor(ctor, new object[] { arrays });
                }
            }
        }
        return base.ConvertTo(context, culture, value, destinationType);
    }
}
