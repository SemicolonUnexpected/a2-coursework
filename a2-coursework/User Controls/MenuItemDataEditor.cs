using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace a2_coursework.User_Controls; 
internal class MenuItemDataEditor : UITypeEditor {
    public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext? context) {
        return UITypeEditorEditStyle.Modal;
    }

    public override object? EditValue(ITypeDescriptorContext? context, IServiceProvider provider, object? value) {
        if (provider is null) return value;
        IWindowsFormsEditorService editorService = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
        if (editorService is null) return value;

        if (value is MenuItemData data) {
            using JaggedStringArrayEditorForm jaggedStringArrayEditorForm = new JaggedStringArrayEditorForm(data);

            if (editorService.ShowDialog(jaggedStringArrayEditorForm) == DialogResult.OK) {
                return jaggedStringArrayEditorForm.JaggedStringArray;
            }
        }

        return value;
    }
}
