using System.ComponentModel;

namespace a2_coursework.View.Interfaces.Users;
public interface IDisplayStaffView : IChildView {
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
    //public DisplayStaff? SelectedItem { get; }

    //public void DisplayItems(BindingList<DisplayStaff> items);
    public void DisableAll();
    public void EnableAll();
    public void Invoke(Action a);
}
