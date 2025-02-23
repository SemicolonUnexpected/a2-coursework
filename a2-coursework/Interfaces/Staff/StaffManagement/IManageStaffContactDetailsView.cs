namespace a2_coursework.Interfaces.Staff.StaffManagement;
public interface IManageStaffContactDetailsView : IChildView {
    public event EventHandler? EmailChanged;
    public event EventHandler? PhoneNumberChanged;
    public event EventHandler? AddressChanged;

    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }

    public string ContactError { get; set; }
    public void SetEmailBorderError(bool isError);
    public void SetPhoneNumberBorderError(bool isError);

    public void SetCharacterCount(int number);
}
