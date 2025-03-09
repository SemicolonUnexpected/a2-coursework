namespace a2_coursework.Interfaces;

public interface IViewView : IChildView {
    public event EventHandler<string>? SelectedMenuItemChanged;

    public void DisplayChildView(IChildView childView);
}
