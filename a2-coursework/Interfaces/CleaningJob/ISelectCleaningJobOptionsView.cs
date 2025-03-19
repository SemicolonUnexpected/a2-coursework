using a2_coursework.View;
using a2_coursework.View.CleaningJobOptions;

namespace a2_coursework.Interfaces.CleaningJob;
public interface ISelectCleaningJobOptionsView : IDisplayView<DisplayCleaningJobOptionModel>, IChildView {
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public void DisableAll();
    public void EnableAll();
    public string DataGridText { get; set; }
    public List<DisplayCleaningJobOptionModel> SelectedItems { get; }
    public void SetSelectedItemsById(IEnumerable<int> models);
}