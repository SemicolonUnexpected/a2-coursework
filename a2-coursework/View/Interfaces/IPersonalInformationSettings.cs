using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces;
public interface IPersonalInformationSettings : IThemeable {
    public bool ApproveChangesBarVisible { set; }
    public string ForenameInput { get; set; }
    public string SurnameInput { get; set; }
    public void SetForenameBorderError(bool isError);
    public void SetSurnameBorderError(bool isError);
    public string NameErrorText { set; }

    public DateTime? DateOfBirthInput { get; set; }
    public string DayInput { get; }
    public string MonthInput { get; }
    public string YearInput { get; }
    public string DateOfBirthErrorText { set; }
}
