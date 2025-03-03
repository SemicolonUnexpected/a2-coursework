using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.SignIn;
using a2_coursework.Model.Staff;

namespace a2_coursework.Presenter.SignIn;

public class DashboardPresenter : BasePresenter<IDashboardView>, INavigatingPresenter, IChildPresenter {
    private readonly StaffModel _staff;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public DashboardPresenter(IDashboardView view, StaffModel staff) : base(view) {
        _staff = staff;

        PopulateDefaultValues();
        _view.ChangePasswordClicked += OnChangePasswordClicked;
    }

    private void OnChangePasswordClicked(object? sender, EventArgs e) => NavigateChangePassword();

    private void NavigateChangePassword() {
        (IChildView view, IChildPresenter presenter) = StaffFactory.CreateSecuritySettings(_staff);

        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    private void PopulateDefaultValues() {
        string welcomeMessage = DateTime.Now.Hour < 12 ? "Good Morning" : DateTime.Now.Hour < 4 ? "Good afternoon" : "Good morning";
        _view.Welcome = $"{welcomeMessage}, {_staff.Forename}";

        _view.LastPasswordChange = _staff.LastPasswordChange;
        _view.ShowChangePassword = _staff.LastPasswordChange < DateTime.Now - new TimeSpan(30, 0, 0, 0);
    }

    public bool CanExit() => true;
}
