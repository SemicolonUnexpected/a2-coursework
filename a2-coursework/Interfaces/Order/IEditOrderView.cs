using a2_coursework.Interfaces;

namespace a2_coursework.Interfaces.Order;
public interface IEditOrderView : IChildView, IEditView {
    public event EventHandler? Back;
}
