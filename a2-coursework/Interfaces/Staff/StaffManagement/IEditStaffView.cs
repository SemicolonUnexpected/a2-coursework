using a2_coursework.UserControls;

namespace a2_coursework.Interfaces.Staff.StaffManagement;
public interface IEditStaffView : IChildView, IEditView {
    public event EventHandler<string>? SelectedMenuItemChanged;
    public event EventHandler<ToggleEventArgs>? PreviewSelectedMenuItemChanged;
    public event EventHandler? Back;

    public void DisplayChildView(IChildView childView);
}
