using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces; 
public interface IEmergencyContactSettingsView : IThemeable {
    public event EventHandler? SurnameChanged;
    public event EventHandler? ForenameChanged;
    public event EventHandler? PhoneNumberChanged;

    // Data fields
    public string Forename { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }

    // Error UI
    public void SetForenameBorderError(bool isError);
    public void SetSurnameBorderError(bool isError);
    public void SetPhoneNumberBorderError(bool isError);
    public string NameErrorText { set; }
    public string PhoneNumberErrorText { set; }
    public void ShowError(string text, string caption);
    public void ShowSuccess(string message, string caption);

    // Saving state UI
    public bool SaveVisible { set; }
    public bool IsLoading { set; }
}
