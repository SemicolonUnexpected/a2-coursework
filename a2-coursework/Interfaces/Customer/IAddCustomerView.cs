namespace a2_coursework.Interfaces.Customer; 
public interface IAddCustomerView : IAddView {
    public event EventHandler? Back;
}