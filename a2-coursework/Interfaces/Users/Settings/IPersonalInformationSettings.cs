namespace a2_coursework.Interfaces.Users.Settings;
public interface IPersonalInformationSettings : IEditView
{
    public event EventHandler? SurnameChanged;
    public event EventHandler? ForenameChanged;
    public event EventHandler? DateOfBirthChanged;

    public string Forename { get; set; }
    public string Surname { get; set; }
    public DateTime? DateOfBirth { get; set; }

    public void SetForenameBorderError(bool isError);
    public void SetSurnameBorderError(bool isError);
    public string NameErrorText { set; }
    public string DateOfBirthErrorText { set; }

    public bool DateOfBirthValid { get; }
}
