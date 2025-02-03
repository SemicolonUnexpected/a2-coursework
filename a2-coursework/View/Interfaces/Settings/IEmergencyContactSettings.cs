using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces.Settings;
public interface IEmergencyContactSettings : ISettingsView
{
    public event EventHandler? ForenameChanged;
    public event EventHandler? SurnameChanged;
    public event EventHandler? PhoneNumberChanged;

    public string Forename { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }

    public void SetPhoneNumberBorderError(bool isError);
    public string PhoneNumberErrorText { set; }
}
