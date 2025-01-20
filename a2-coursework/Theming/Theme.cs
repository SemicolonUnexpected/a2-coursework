using System.Configuration;

namespace a2_coursework.Theming; 
internal class Theme {
    public static event EventHandler? ColourSchemeChanged;
    private static ThemeMode _currentTheme = ConfigurationManager.AppSettings.Get("DefaultTheme") != "light" ? ThemeMode.Dark : ThemeMode.Light;
    public static ThemeMode CurrentTheme {
        get => _currentTheme;
        set {
            _currentTheme = value;
            ColourSchemeChanged?.Invoke(null, EventArgs.Empty);
        }
    }

    public static void ToggleTheme() {
        if (CurrentTheme == ThemeMode.Dark) CurrentTheme = ThemeMode.Light;
        else CurrentTheme = ThemeMode.Dark;
    }

    public Theme(bool isDarkMode, bool showToolTips) {
        IsDarkMode = isDarkMode;
        ShowToolTips = showToolTips;
    }

    public bool IsDarkMode { get; set; }
    public bool ShowToolTips {  get; set; }
}

public enum ThemeMode { Dark, Light }
