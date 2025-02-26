namespace a2_coursework.Interfaces.Report; 
public interface IReportView : IChildView {
    public event EventHandler? Download;
    public byte[]? Pdf { get; set; }
    public string ReportName { get; set; }
    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons);
    public bool GetFileName(out string name);
    public void Invoke(Action a);
}