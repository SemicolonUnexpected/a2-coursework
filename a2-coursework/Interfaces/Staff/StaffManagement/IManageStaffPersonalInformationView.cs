namespace a2_coursework.Interfaces.Staff.StaffManagement;
public interface IManageStaffPersonalInformationView : IChildView {
    public event EventHandler? ForenameChanged;
    public event EventHandler? SurnameChanged;
    public event EventHandler? DateOfBirthChanged;

    public string Forename { get; set; }
    public string Surname { get; set; }
    public DateTime? DateOfBirth { get; set; }

    public bool DateOfBirthValid { get; }
    public string NameError { get; set; }
    public string DateOfBirthError { get; set; }
    public void SetForenameBorderError(bool isError);
    public void SetSurnameBorderError(bool isError);
}
