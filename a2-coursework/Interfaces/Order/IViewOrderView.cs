namespace a2_coursework.Interfaces.Order;
public interface IViewOrderView : IViewView {
    public event EventHandler? Back;

    public bool DiscrepanciesVisible { get; set; }
}
