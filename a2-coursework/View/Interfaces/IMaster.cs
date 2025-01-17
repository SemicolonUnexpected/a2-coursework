namespace a2_coursework.View.Interfaces;
internal interface IMaster {
    public void Show();
    public void Close();

    public event FormClosedEventHandler? FormClosed;
}
