namespace a2_coursework.View.Interfaces;
internal interface IMaster : IThemable {
    public Form? ChildForm { get; set; }
    public string UsernameText { get; set; }
    public void DisplayChildForm(Form childForm) { }
    public void GenerateMenu(string[][] menuItems) { }
    public void Show();
    public void Close();

    public event FormClosedEventHandler? FormClosed;
}
