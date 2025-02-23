using a2_coursework.Interfaces;

namespace a2_coursework.Interfaces.Customer;
public interface IEditCustomerView : IChildView, IEditView
{
    public event EventHandler? Back;
}