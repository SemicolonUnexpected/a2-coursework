using a2_coursework.View;
using a2_coursework.View.Order;

namespace a2_coursework.Interfaces.Order;

public interface IDisplayOrderView : IChildView, IDisplayView<DisplayOrderModel> {
    public event EventHandler? Add;
    public event EventHandler? Edit;
    public event EventHandler? Delete;
    public event EventHandler? Search;
    public event EventHandler? SelectionChanged;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public string SearchText { get; set; }
    public string DataGridText { set; }
    public DisplayOrderModel? SelectedItem { get; }

    public void DisableAll();
    public void EnableAll();
}
