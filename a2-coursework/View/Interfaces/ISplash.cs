namespace a2_coursework.View.Interfaces;

internal interface ISplash {
    double Progress { get; set; }
    public event FormClosedEventHandler? FormClosed;
    public void Show();
    public void Close();
    void Invoke(Action a);
}
