namespace a2_coursework.Interfaces;

public interface ISplashView : IView
{
    public event FormClosedEventHandler? FormClosed;

    public double Progress { get; set; }
    public void Invoke(Action a);
    public void Show();
    public void Close();
}
