namespace a2_coursework.Interfaces.Order; 
public interface ISubmitOrderView : IChildView {
    public event EventHandler? Submit;
    public event EventHandler? Receive;
    public event EventHandler? DescriptionChanged;

    public string Description { get; set; }
    public bool ReadOnly { get; set; }
    public bool Receivable { get; set; }
    public bool ButtonVisible { get; set; }

    public void SetCharacterCount(int number);
}