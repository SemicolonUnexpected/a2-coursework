using a2_coursework.View;
using a2_coursework.View.CleaningJob;

namespace a2_coursework.Interfaces.CleaningJob;
public interface IDisplayUpcomingCleaningJobView : IChildView, IDisplayView<DisplayCleaningJobModel> {
    public event EventHandler? View;
    public event EventHandler? Edit;
    public event EventHandler? Search;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public string SearchText { get; set; }
    public string DataGridText { set; }
    public DisplayCleaningJobModel? SelectedItem { get; }
    public bool ViewMode { get; set; }

    public void DisableAll();
    public void EnableAll();
}