using a2_coursework.View.Interfaces.Users;

namespace a2_coursework.Presenter.Users; 
public class ChangePasswordPresenter {
    private IChangePasswordView _view;

    public ChangePasswordPresenter(IChangePasswordView view) {
        _view = view;
    }

    public bool CanExit() => true;
}
