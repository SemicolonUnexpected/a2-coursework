using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces; 
public interface IAppearanceSettings : ISettingsView, IThemeable {
    public event EventHandler? DarkModeCheckedChanged;
    public event EventHandler? ToolTipsCheckedChanged;
    public event EventHandler? FontNameChanged;

    // Data fields
    public bool DarkModeChecked { get; set; }
    public bool ToolTipsChecked { get; set; }
    public string FontName { get; set; }

    // Error UI
    public void ShowError(string text, string caption);
    public void ShowSuccess(string message, string caption);
}
