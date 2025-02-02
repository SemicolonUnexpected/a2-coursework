using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces.Settings;
public interface IContactDetailsSettings : IChildView, IThemeable
{
    public event EventHandler? SaveRequested;
    public event EventHandler? CancelRequested;
    public event EventHandler? EmailChanged;
    public event EventHandler? PhoneNumberChanged;
    public event EventHandler? AddressChanged;

    // Data fields
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }

    // Error UI
    public void SetEmailBorderError(bool isError);
    public void SetPhoneNumberBorderError(bool isError);
    public string ContactErrorText { set; }
    public void ShowError(string text, string caption);
    public void ShowSuccess(string message, string caption);

    // Saving state UI
    public bool SaveVisible { set; }
    public bool IsLoading { set; get; }
}
