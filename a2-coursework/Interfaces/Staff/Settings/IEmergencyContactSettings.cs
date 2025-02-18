namespace a2_coursework.Interfaces.Staff.Settings;
public interface IEmergencyContactSettings : IEditView {
    public event EventHandler? EmergencyContactForenameChanged;
    public event EventHandler? EmergencyContactSurnameChanged;
    public event EventHandler? EmergencyContactPhoneNumberChanged;

    public string EmergencyContactForename { get; set; }
    public string EmergencyContactSurname { get; set; }
    public string EmergencyContactPhoneNumber { get; set; }

    public void SetPhoneNumberBorderError(bool isError);
    public string PhoneNumberErrorText { set; }
}
