namespace a2_coursework.Interfaces;
public interface IEditView : IChildView {
    public event EventHandler? Save;
    public event EventHandler? Cancel;

    public bool SaveCancelVisible { set; }
    public bool IsLoading { get; set; }

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK);
}
