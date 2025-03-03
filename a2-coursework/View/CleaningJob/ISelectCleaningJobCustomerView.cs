using a2_coursework.Interfaces;

namespace a2_coursework.View.CleaningJob; 
public interface ISelectCleaningJobCustomerView : IDisplayView<DisplayCustomerModel>, IChildView {
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public void DisableAll();
    public void EnableAll();
    public string DataGridText { get; set; }
    public List<DisplayCustomerModel> SelectedItems { get; }
    public void SetSelectedItemById(int id);
}