using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces;
public interface IPersonalInformationSettings : IThemeable {
    public event EventHandler? SurnameChanged;
    public event EventHandler? ForenameChanged;
    public event EventHandler? DateOfBirthChanged;
    public event EventHandler? SaveRequested;
    public event EventHandler? CancelRequested;

    // Data fields
    public string Forename { get; set; }
    public string Surname { get; set; }
    public DateTime? DateOfBirth { get; set; }

    // Error UI
    public void SetForenameBorderError(bool isError);
    public void SetSurnameBorderError(bool isError);
    public string NameErrorText { set; }
    public string DateOfBirthErrorText { set; }
    public void ShowError(string text, string caption);
    public void ShowSuccess(string message, string caption);

    // Validation information
    public bool DateOfBirthValid { get; }

    // Saving state UI
    public bool SaveVisible { set; }
    public bool IsLoading { set; get; }
}
