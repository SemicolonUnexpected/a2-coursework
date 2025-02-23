namespace a2_coursework.Interfaces.Staff.StaffManagement; 
public interface IManageStaffPasswordView : IChildView {
    public event EventHandler? PasswordChanged;
    public event EventHandler? ConfirmPasswordChanged;

    public string Password { get; set; }
    public string ConfirmPassword { get; set; }

    public bool EightLong { get; set; }
    public bool Number { get; set; }
    public bool SpecialCharacter { get; set; }
    public bool UppercaseLowercase { get; set; }

    public void SetPasswordBorderError(bool isError);
    public void SetConfirmPasswordBorderError(bool isError);
    public string PasswordError { set; }
}
