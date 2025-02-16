using a2_coursework.UserControls;
using a2_coursework.View.Interfaces.Users.Settings;

namespace a2_coursework.View.Interfaces.Stock; 
public interface IEditStockView : IChildView, IEditView {
    public event EventHandler<string>? SelectedMenuItemChanged;
    public event EventHandler<ToggleEventArgs>? PreviewSelectedMenuItemChanged;
    public event EventHandler? Back;

    public void DisplayChildView(IChildView childView);
}
