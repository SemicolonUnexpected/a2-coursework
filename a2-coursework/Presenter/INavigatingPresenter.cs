using a2_coursework.View.Interfaces;

namespace a2_coursework.Presenter; 
public interface INavigatingPresenter {
    public event EventHandler<(IChildView view, IChildPresenter presenter)>? Navigating;
}
