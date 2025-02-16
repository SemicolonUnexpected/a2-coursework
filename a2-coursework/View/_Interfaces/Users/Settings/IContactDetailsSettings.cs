using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces.Users.Settings;
public interface IContactDetailsSettings : IEditView
{
    public event EventHandler? EmailChanged;
    public event EventHandler? PhoneNumberChanged;
    public event EventHandler? AddressChanged;

    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }

    public void SetEmailBorderError(bool isError);
    public void SetPhoneNumberBorderError(bool isError);
    public string ContactErrorText { set; }
}
