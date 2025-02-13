using a2_coursework.View.Interfaces;

namespace a2_coursework.Presenter;
public abstract class BasePresenter<T>(T view) : ICleanable where T : IView {
    protected readonly T _view = view;
    public virtual void CleanUp() {
        _view.CleanUp();
        _view.Dispose();
    }
}
