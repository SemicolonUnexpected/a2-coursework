using a2_coursework.Interfaces;

namespace a2_coursework.View.Order;
public interface IViewCleaningJobView : IChildView, IViewView {
    public event EventHandler? Back;
}
