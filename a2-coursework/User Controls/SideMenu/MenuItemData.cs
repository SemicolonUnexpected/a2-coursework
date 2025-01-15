namespace a2_coursework.UserControls.SideMenu;
public struct MenuItemData(string name, string[] childNames) {
    public string Name { get; set; } = name;
    public string[] ChildNames { get; set; } = childNames;
}
