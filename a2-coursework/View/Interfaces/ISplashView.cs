using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces;

public interface ISplashView : IThemeable, IView {
    public event FormClosedEventHandler? FormClosed;

    public double Progress { get; set; }
    public void Invoke(Action a);
    public void Show();
    public void Close();
}
