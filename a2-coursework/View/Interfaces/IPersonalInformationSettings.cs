using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces; 
public  interface IPersonalInformationSettings : IThemeable {
    public string NamesErrorText { get; set; }
    public string DateErrorText { get; set; }
}
