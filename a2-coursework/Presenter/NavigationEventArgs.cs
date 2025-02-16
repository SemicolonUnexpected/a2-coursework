using a2_coursework.View.Interfaces;

namespace a2_coursework.Presenter; 
public class NavigationEventArgs : EventArgs {
    public IChildView View { get; init; }
    public IChildPresenter Presenter { get; init; }

    public NavigationEventArgs(IChildView view, IChildPresenter presenter) {
        View = view;
        Presenter = presenter;
    }
}
