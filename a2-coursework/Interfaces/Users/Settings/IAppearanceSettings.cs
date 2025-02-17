namespace a2_coursework.Interfaces.Users.Settings;
public interface IAppearanceSettings : IEditView
{
    public event EventHandler? DarkModeCheckedChanged;
    public event EventHandler? ToolTipsCheckedChanged;
    public event EventHandler? FontNameChanged;

    public bool DarkModeChecked { get; set; }
    public bool ToolTipsChecked { get; set; }
    public string FontName { get; set; }
}
