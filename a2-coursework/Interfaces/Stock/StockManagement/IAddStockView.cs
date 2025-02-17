namespace a2_coursework.Interfaces.Stock.StockManagement;
public interface IAddStockView : IView
{
    public event EventHandler? Back;
    public event EventHandler? Next;
    public event EventHandler? Previous;
    public event EventHandler? Done;

    public string Title { get; set; }

    public bool NextVisible { get; set; }
    public bool PreviousVisible { get; set; }
    public bool DoneVisible { get; set; }
    public bool IsLoading { get; set; }

    public void DisplayChildView(IChildView childView);
    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK);
}
