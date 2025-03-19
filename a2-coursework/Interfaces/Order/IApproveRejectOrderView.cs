using a2_coursework.View;
using a2_coursework.View.Order;

namespace a2_coursework.Interfaces.Order;

public interface IApproveRejectOrderView : IChildView, IDisplayView<DisplayOrderModel> {
    public event EventHandler? View;
    public event EventHandler? Approve;
    public event EventHandler? Reject;
    public event EventHandler? Search;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public string SearchText { get; set; }
    public string DataGridText { set; }
    public DisplayOrderModel? SelectedItem { get; }

    public void DisableAll();
    public void EnableAll();
}
