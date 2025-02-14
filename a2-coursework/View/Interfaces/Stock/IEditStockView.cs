using a2_coursework.UserControls;

namespace a2_coursework.View.Interfaces.Stock; 
public interface IEditStockView : IChildView {
    public event EventHandler? SelectedMenuItemChanged;
    public event EventHandler<ToggleEventArgs>? PreviewSelectedMenuItemChanged;
    public event EventHandler? Save;
    public event EventHandler? Cancel;

    public string SelectedMenuItem { get; }
    public bool IsLoading { get; set; }
    public bool SaveCancelVisible { get; set; }

    public void DisplayView(IChildView childView);

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK);
}
