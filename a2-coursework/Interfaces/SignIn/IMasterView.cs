using a2_coursework.UserControls;

namespace a2_coursework.Interfaces.SignIn;
public interface IMasterView : IView {
    public event EventHandler<ToggleEventArgs>? PreviewToggleChanged;
    public event EventHandler<string>? ToggleChanged;
    public event EventHandler? SignOut;
    public event FormClosedEventHandler? FormClosed;
    public event FormClosingEventHandler? FormClosing;

    public IChildView? ChildView { get; set; }
    public string UsernameText { set; }
    public void DisplayChildView(IChildView childForm);
    public void GenerateMenu(string[][] menuItems);
    public void SetSideMenuToggledIndex(int i, int j, bool toggled);
    public void Show();
    public void SetSideMenuToggledName(string itemName);

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK);
}
