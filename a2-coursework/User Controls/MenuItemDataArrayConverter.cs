//using a2_coursework.UserControls;
//using System.ComponentModel;
//using System.ComponentModel.Design.Serialization;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;

//namespace a2_coursework.User_Controls; 
//internal class MenuItemDataArrayConverter : TypeConverter {
//    public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType) {
//        if (sourceType == typeof(string)) return true;

//        return base.CanConvertFrom(context, sourceType);
//    }
    
//    public override bool CanConvertTo(ITypeDescriptorContext? context, [NotNullWhen(true)] Type? destinationType) {
//        if (destinationType == typeof(string)) return true;
//        if (destinationType == typeof(InstanceDescriptor)) return true;

//        return base.CanConvertTo(context, destinationType);
//    }

//    public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value) {
//        return base.ConvertFrom(context, culture, value);
//    }

//    public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType) {
//        if (value is MenuItemData[] dataArray) {
//            if (destinationType == typeof(string)) {
            
//            }
//            //else if (destinationType == typeof(InstanceDescriptor)) {
//            //    var ctor = typeof(MenuItemData[]).GetConstructor()
//            //    return new InstanceDescriptor(dataArray);
//            //}
//        }
//        return base.ConvertTo(context, culture, value, destinationType);
//    }

//    public override bool GetCreateInstanceSupported(ITypeDescriptorContext? context) => true;
//}
