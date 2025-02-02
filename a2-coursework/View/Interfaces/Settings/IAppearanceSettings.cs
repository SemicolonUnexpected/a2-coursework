namespace a2_coursework.View.Interfaces.Settings;
public interface IAppearanceSettings : ISettingsView
{
    public event EventHandler? DarkModeCheckedChanged;
    public event EventHandler? ToolTipsCheckedChanged;
    public event EventHandler? FontNameChanged;

    public bool DarkModeChecked { get; set; }
    public bool ToolTipsChecked { get; set; }
    public string FontName { get; set; }
}
