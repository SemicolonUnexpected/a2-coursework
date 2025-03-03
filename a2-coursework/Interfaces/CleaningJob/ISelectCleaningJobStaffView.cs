using a2_coursework.View;
using a2_coursework.View.StaffView.StaffManagement;

namespace a2_coursework.Interfaces.CleaningJob; 
public interface ISelectCleaningJobStaffView : IDisplayView<DisplayStaffModel> {
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public void DisableAll();
    public void EnableAll();
    public string DataGridText { get; set; }
    public List<DisplayStaffModel> SelectedItems { get; }
    public void SetSelectedItemsById(IEnumerable<int> models);
}