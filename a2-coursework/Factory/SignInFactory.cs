using a2_coursework.Model.Staff;
using a2_coursework.Presenter;
using a2_coursework.View;

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
}
