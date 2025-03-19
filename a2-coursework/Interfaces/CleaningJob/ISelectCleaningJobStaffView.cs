using a2_coursework.View;
using a2_coursework.View.Staff.StaffManagement;

namespace a2_coursework.Interfaces.CleaningJob; 
public interface ISelectCleaningJobStaffView : IDisplayView<DisplayStaffModel>, IChildView {
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public string DataGridText { get; set; }
    public bool ReadOnly { get; set; }
    public List<DisplayStaffModel> SelectedItems { get; }

    public void DisableAll();
    public void EnableAll();
    public void SetSelectedItemsById(IEnumerable<int> models);
}