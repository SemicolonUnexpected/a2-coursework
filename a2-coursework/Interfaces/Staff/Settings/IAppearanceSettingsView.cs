namespace a2_coursework.Interfaces.Staff.Settings;
public interface IAppearanceSettingsView : ISaveCancelView {
    public event EventHandler? DarkModeCheckedChanged;
    public event EventHandler? ToolTipsCheckedChanged;
    public event EventHandler? FontNameChanged;

    public bool DarkModeChecked { get; set; }
    public bool ShowToolTipsChecked { get; set; }
    public string FontName { get; set; }
}
