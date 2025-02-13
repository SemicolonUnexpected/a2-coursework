using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces.Users.Settings;
public interface IEmergencyContactSettings : ISettingsView
{
    public event EventHandler? EmergencyContactForenameChanged;
    public event EventHandler? EmergencyContactSurnameChanged;
    public event EventHandler? EmergencyContactPhoneNumberChanged;

    public string EmergencyContactForename { get; set; }
    public string EmergencyContactSurname { get; set; }
    public string EmergencyContactPhoneNumber { get; set; }

    public void SetPhoneNumberBorderError(bool isError);
    public string PhoneNumberErrorText { set; }
}
