using a2_coursework.Presenter;
using a2_coursework.Model;

namespace a2_coursework.View; 
public static class ViewFactory {
    public static (SplashView view, SplashPresenter presenter) CreateSplash() {
        SplashView view = new();
        SplashPresenter presenter = new(view);
        view.SetPresenter(presenter);

        return (view, presenter);
    }

    public static (LoginView view, LoginPresenter presenter) CreateLogin() {
        LoginView view = new();
        LoginPresenter presenter = new(view);
        view.SetPresenter(presenter);

        return (view, presenter);
    }

    public static (MasterView view, MasterPresenter presenter) CreateMaster(Staff staff) {
        MasterView view = new();
        MasterPresenter presenter = new(view, staff);
        view.SetPresenter(presenter);

        return (view, presenter);
    }
}
