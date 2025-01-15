using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace a2_coursework.UserControls.SideMenu;
internal class MenuItemDataConverter : TypeConverter {
    public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType) {
        if (sourceType == typeof(string)) return true;

        return base.CanConvertFrom(context, sourceType);
    }

    public override bool CanConvertTo(ITypeDescriptorContext? context, [NotNullWhen(true)] Type? destinationType) {
        if (destinationType == typeof(string)) return true;
        if (destinationType == typeof(InstanceDescriptor)) return true;

        return base.CanConvertTo(context, destinationType);
    }

    public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType) {
        if (value is null) return null;

        if (value is MenuItemData data) {
            if (destinationType == typeof(string)) {
                return $"{data.Name};{string.Join(", ", data.ChildNames)}";
            }
            else if (destinationType == typeof(InstanceDescriptor)) {
                var ctor = typeof(MenuItemData).GetConstructor([typeof(string), typeof(string[])]);
                if (ctor is not null) {
                    return new InstanceDescriptor(ctor, new object?[] { data.Name, data.ChildNames });
                }
            }
        }

        return base.ConvertTo(context, culture, value, destinationType);
    }

    public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value) {
        if (value is null) return null;

        if (value is string stringValue) {
            stringValue = stringValue.Trim();

            if (stringValue.Length == 0) {
                return null;
            }

            string[] parts = stringValue.Split(';');
            if (parts.Length == 1) {
                return new MenuItemData() {
                    Name = parts[0],
                };
            }
            else if (parts.Length == 2) {
                string[] values = parts[1].Split(",");
                return new MenuItemData(parts[0], values);
            }
            else {
                throw new ArgumentException("Not a valid value");
            }
        }

        return base.ConvertFrom(context, culture, value);
    }

    public override bool GetCreateInstanceSupported(ITypeDescriptorContext? context) => true;

    public override object? CreateInstance(ITypeDescriptorContext? context, IDictionary propertyValues) {
        ArgumentNullException.ThrowIfNull(propertyValues);

        return new MenuItemData(
            (string)propertyValues[nameof(MenuItemData.Name)]!,
            (string[])propertyValues[nameof(MenuItemData.ChildNames)]!
            );
    }

    public override bool GetPropertiesSupported(ITypeDescriptorContext? context) => true;

    public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext? context, object value, Attribute[]? attributes) {
        PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(MenuItemData), attributes);
        return props.Sort([nameof(MenuItemData.Name), nameof(MenuItemData.ChildNames)]);
    }
}
