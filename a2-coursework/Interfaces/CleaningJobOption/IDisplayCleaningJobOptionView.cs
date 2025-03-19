using a2_coursework.View;
using a2_coursework.View.CleaningJobOptions;

namespace a2_coursework.Interfaces.CleaningJobOption; 
public interface IDisplayCleaningJobOptionView : IDisplayView<DisplayCleaningJobOptionModel>, IChildView {
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
    public DisplayCleaningJobOptionModel? SelectedItem { get; }

    public void DisableAll();
    public void EnableAll();
}
