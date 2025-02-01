using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces; 
public interface IEmergencyContactSettingsView : IThemeable, IChildView {
    public event EventHandler? ForenameChanged;
    public event EventHandler? SurnameChanged;
    public event EventHandler? PhoneNumberChanged;
    public event EventHandler? SaveRequested;
    public event EventHandler? CancelRequested;

    // Data fields
    public string Forename { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }

    // Error UI
    public void SetPhoneNumberBorderError(bool isError);
    public string PhoneNumberErrorText { set; }
    public void ShowError(string text, string caption);
    public void ShowSuccess(string message, string caption);

    // Saving state UI
    public bool SaveVisible { set; }
    public bool IsLoading { set; }
}
