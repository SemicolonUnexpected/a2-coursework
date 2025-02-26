using a2_coursework.Interfaces;
using a2_coursework.Model.Staff;
using a2_coursework.Presenter;
using a2_coursework.Presenter.Customer;
using a2_coursework.Presenter.SignIn;
using a2_coursework.View;
using a2_coursework.View.Users;

namespace a2_coursework.Factory;
public static class SignInFactory {
    public static SplashPresenter CreateSplash() {
        SplashView view = new();
        SplashPresenter presenter = new(view);

        return presenter;
    }

    public static SignInPresenter CreateSignIn() {
        SignInView view = new();
        SignInPresenter presenter = new(view);

        return presenter;
    }

    public static MasterPresenter CreateMaster(StaffModel staff) {
        MasterView view = new();
        MasterPresenter presenter = new(view, staff);

        return presenter;
    }

    public static (DisplayLoginAttemptView view, DisplayLoginAttemptPresenter presenter) CreateDisplayLoginAttempt() {
        DisplayLoginAttemptView view = new();
        DisplayLoginAttemptPresenter presenter = new(view);

        return (view, presenter);
    }
}
