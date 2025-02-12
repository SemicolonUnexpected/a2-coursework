using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces;
public interface IMasterView : IThemeable {

    public IChildView? ChildView { get; set; }
    public string UsernameText { get; set; }
    public void DisplayChildForm(IChildView childForm) { }
    public void GenerateMenu(string[][] menuItems) { }
}
