using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces;

public interface ISplash : IThemeable {
    double Progress { get; set; }
    void Invoke(Action a);
}
