using System.Text;

namespace a2_coursework.UserControls.SideMenu; 
public class MenuItemData {
    public string? Name { get; set; } = null;
    public string[]? ChildNames { get; set; } = null;

    public MenuItemData(string? name, string[]? childItems) {
        Name = name;
        ChildNames = childItems;
    }

    public MenuItemData() { }

    public override string ToString() {
        StringBuilder sb = new();
        sb.Append($"{Name};");

        if (ChildNames is null) {
            return sb.ToString();
        }

        sb.AppendJoin(", ", ChildNames);

        return sb.ToString();
    }
}
