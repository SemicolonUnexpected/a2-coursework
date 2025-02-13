using a2_coursework.UserControls;

namespace a2_coursework.View.Interfaces;
public interface IMasterView : IView {
    public event EventHandler<ToggleEventArgs>? PreviewToggleChanged;
    public event EventHandler<string>? ToggleChanged;
    public event EventHandler? SignOut;

    public IChildView? ChildView { get; set; }
    public string UsernameText { set; }
    public void DisplayChildForm(IChildView childForm);
    public void GenerateMenu(string[][] menuItems);

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK);
}
