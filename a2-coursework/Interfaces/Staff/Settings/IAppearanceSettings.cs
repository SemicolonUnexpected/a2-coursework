namespace a2_coursework.Interfaces.Staff.Settings;
public interface IAppearanceSettings : IEditView {
    public event EventHandler? DarkModeCheckedChanged;
    public event EventHandler? ToolTipsCheckedChanged;
    public event EventHandler? FontNameChanged;

    public bool DarkModeChecked { get; set; }
    public bool ShowToolTipsChecked { get; set; }
    public string FontName { get; set; }
}
