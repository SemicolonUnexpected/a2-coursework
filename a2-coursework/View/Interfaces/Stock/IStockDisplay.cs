using a2_coursework.View.Stock;
using System.ComponentModel;

namespace a2_coursework.View.Interfaces.Stock;
public interface IStockDisplay : IChildView {
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
    public DisplayStockItem? SelectedItem { get; }

    public void DisplayItems(BindingList<DisplayStockItem> items);
    public void DisableAll();
    public void EnableAll();
}
