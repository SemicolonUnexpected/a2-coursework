using a2_coursework.Interfaces;

namespace a2_coursework.View.Order; 
public interface ISubmitOrderView : IChildView {
    public event EventHandler? Submit;
    public event EventHandler? DescriptionChanged;

    public string Description { get; set; }

    public void SetCharacterCount(int number);
}