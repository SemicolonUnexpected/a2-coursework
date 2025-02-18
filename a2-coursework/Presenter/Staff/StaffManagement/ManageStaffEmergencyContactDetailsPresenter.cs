using a2_coursework.Interfaces.Staff.StaffManagement;

namespace a2_coursework.Presenter.Staff.StaffManagement;
public class ManageStaffEmergencyContactDetailsPresenter : BasePresenter<IManageStaffEmergencyContactDetailsView>, IChildPresenter, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public ManageStaffEmergencyContactDetailsPresenter(IManageStaffEmergencyContactDetailsView view) : base(view) {
    }

    public bool CanExit() => true;
}
