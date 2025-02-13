using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces;
public interface IMasterView : IThemeable, IView {
    public event EventHandler<string>? ToggleChanged;
    public event EventHandler? SignOut;

    public IMasterChildView? ChildView { get; set; }
    public string UsernameText { get; set; }
    public void DisplayChildForm(IMasterChildView childForm) { }
    public void GenerateMenu(string[][] menuItems) { }
}
