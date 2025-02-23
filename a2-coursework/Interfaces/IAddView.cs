namespace a2_coursework.Interfaces;
public interface IAddView : IView {
    public event EventHandler? Next;
    public event EventHandler? Previous;
    public event EventHandler? Done;

    public bool PreviousVisible { get; set; }
    public bool NextVisible { get; set; }
    public bool DoneVisible { get; set; }

    public void DisplayChildView(IChildView view);

    public bool IsLoading { get; set; }

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK);
}
