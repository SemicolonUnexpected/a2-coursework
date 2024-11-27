using a2_coursework.View.Interfaces;

namespace a2_coursework.Presenter; 
internal class LoginPresenter {
    private ILoginView _view;
 
    public void Show() => _view.Show();

    public event FormClosedEventHandler? FormClosed;

    public LoginPresenter(ILoginView view) {
        _view = view;

        _view.FormClosed += (o, e) => FormClosed?.Invoke(o, e);
    }
}
