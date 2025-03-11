namespace a2_coursework.Interfaces.Order; 
public interface IApproveOrderView : IChildView {
    public event EventHandler? Approve;
    public event EventHandler? DescriptionChanged;

    public string Description { get; set; }

    public void SetCharacterCount(int number);
}
