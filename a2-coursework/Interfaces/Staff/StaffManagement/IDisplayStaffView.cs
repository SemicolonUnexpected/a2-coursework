using a2_coursework.View;
using a2_coursework.View.StaffView.StaffManagement;

namespace a2_coursework.Interfaces.Staff.StaffManagement;
public interface IDisplayStaffView : IChildView, IDisplayView<DisplayStaffModel> {
    public event EventHandler? Add;
    public event EventHandler? Edit;
    public event EventHandler? ArchiveToggled;
    public event EventHandler? ShowArchivedChanged;
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public string SearchText { get; set; }
    public string DataGridText { set; }
    public bool ShowArchivedItems { get; }
    public bool SelectedItemArchived { set; get; }
    public DisplayStaffModel? SelectedItem { get; }

    public void DisableAll();
    public void EnableAll();

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK);
}
