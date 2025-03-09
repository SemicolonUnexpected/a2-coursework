using a2_coursework.View;
using a2_coursework.View.Order;

namespace a2_coursework.Interfaces.CleaningJob;
public interface IBookCleaningJobView : IDisplayView<DisplayCleaningJobModel>, IChildView {
    public event EventHandler? Search;
    public event EventHandler? Add;
    public event EventHandler? Edit;
    public event EventHandler? View;
    public event EventHandler? Delete;
    public event EventHandler<SortRequestEventArgs>? SortRequested;
    public event EventHandler? DateChanged;

    public DateTime Date { get; set; }
    public string SearchText { get; set; }
    public DisplayCleaningJobModel? SelectedItem { get; }
    public string DataGridText { get; set; }
    public bool AddEnabled { get; set; }
    public bool DeleteEnabled { get; set; }
    public bool ViewMode { get; set; }

    public void DisableAll();
    public void EnableAll();
    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK);
}
