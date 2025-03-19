using a2_coursework.View;
using a2_coursework.View.Customer;

namespace a2_coursework.Interfaces.CleaningJob; 
public interface ISelectCleaningJobCustomerView : IDisplayView<DisplayCustomerModel>, IChildView {
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public void DisableAll();
    public void EnableAll();
    public string DataGridText { get; set; }
    public string SelectedCustomerName { get; set; }
    public DisplayCustomerModel? SelectedItem { get; }

    public void SetSelectedItemId(int? id);
}