using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces;
public interface IMaster : IThemeable {
    public Form? ChildForm { get; set; }
    public string UsernameText { get; set; }
    public void DisplayChildForm(Form childForm) { }
    public void GenerateMenu(string[][] menuItems) { }
}
