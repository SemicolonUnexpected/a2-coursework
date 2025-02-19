using a2_coursework.UserControls;

namespace a2_coursework.Interfaces; 
public interface IEditView : ISaveCancelView {
    public event EventHandler<string>? SelectedMenuItemChanged;
    public event EventHandler<ToggleEventArgs>? PreviewSelectedMenuItemChanged;

    public void DisplayChildView(IChildView childView);
}
