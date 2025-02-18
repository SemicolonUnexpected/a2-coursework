namespace a2_coursework.Interfaces.Staff.StaffManagement;
public interface IManageStaffEmergencyContactView : IChildView {
    public event EventHandler? EmergencyContactForenameChanged;
    public event EventHandler? EmergencyContactSurnameChanged;
    public event EventHandler? EmergencyContactPhoneNumberChanged;

    public string EmergencyContactForename { get; set; }
    public string EmergencyContactSurname { get; set; }
    public string EmergencyContactPhoneNumber { get; set; }
    public string EmergencyContactPhoneNumberError { get; set; }

    public void SetEmergencyContactPhoneNumberBorderError(bool isError);
}
