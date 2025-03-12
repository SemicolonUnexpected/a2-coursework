using a2_coursework.Interfaces;

namespace a2_coursework.Interfaces.Order;
public interface IViewOrderView : IChildView, IViewView {
    public event EventHandler? Back;
}
