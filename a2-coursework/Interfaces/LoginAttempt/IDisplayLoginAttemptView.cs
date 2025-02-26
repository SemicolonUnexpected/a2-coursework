using a2_coursework.View;
using a2_coursework.View.LoginAttempt;

namespace a2_coursework.Interfaces.LoginAttempt; 
public interface IDisplayLoginAttemptView : IDisplayView<DisplayLoginAttemptModel>, IChildView {
    public event EventHandler? Search;
    public event EventHandler<SortRequestEventArgs>? SortRequested;

    public string SearchText { get; set; }
    public string DataGridText { set; }

    public void DisableAll();
    public void EnableAll();
}
