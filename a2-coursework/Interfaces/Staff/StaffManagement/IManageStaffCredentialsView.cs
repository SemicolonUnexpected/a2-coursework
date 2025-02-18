namespace a2_coursework.Interfaces.Staff.StaffManagement;
public interface IManageStaffCredentialsView : IChildView {
    public event EventHandler? UsernameChanged;
    public event EventHandler? PrivilegeLevelChanged;

    public string SuggestedUsername { set; }
    public string Username { get; set; }
    public string[] PrivilegeLevels { get; set; }
    public int SelectedPrivilegeLevel { get; set; }

    public string UsernameError { set; }
    public void SetUsernameBorderError(bool isError);
}
