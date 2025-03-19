namespace a2_coursework.Interfaces.Order; 
public interface IOrderDiscrepanciesView : IChildView {
    public event EventHandler? DescriptionChanged;

    public string Description { get; set; }
    public bool ReadOnly { get; set; }

    public void SetCharacterCount(int number);
}