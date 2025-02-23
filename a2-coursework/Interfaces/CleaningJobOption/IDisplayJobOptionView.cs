using a2_coursework.Model.JobOption;
using a2_coursework.View;

namespace a2_coursework.Interfaces.CleaningJobOption; 
public interface IDisplayJobOptionView :IDisplayView<DisplayJobOptionModel> {
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
    public DisplayJobOptionModel? SelectedItem { get; }

    public void DisableAll();
    public void EnableAll();
}
