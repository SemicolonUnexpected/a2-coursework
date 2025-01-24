using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Configuration;

namespace a2_coursework.Theming; 
internal class Theme {
    static Theme() {
        _currentTheme = new Theme(ConfigurationManager.AppSettings.Get("DefaultTheme") != "light" ? AppearanceTheme.Dark : AppearanceTheme.Light, true);
    }

    public Theme(AppearanceTheme theme, bool showToolTips) {
        AppearanceTheme = theme;
        ShowToolTips = showToolTips;
    }

    public static event EventHandler? ThemeChanged;
    private static Theme _currentTheme;
    public static Theme CurrentTheme {
        get => _currentTheme;
        set {
            _currentTheme = value;
            ThemeChanged?.Invoke(_currentTheme, EventArgs.Empty);
        }
    }

    public static event EventHandler? AppearanceThemeChanged;
    private AppearanceTheme _appearanceTheme;
    public AppearanceTheme AppearanceTheme {
        get =>_appearanceTheme;
        set {
            _appearanceTheme = value;
            AppearanceThemeChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    public static event EventHandler? ShowToolTipsChanged;
    private bool _showToolTips;
    public bool ShowToolTips {
        get => _showToolTips;
        set {
            _showToolTips = value;
            ShowToolTipsChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    public static void ToggleTheme() {
        CurrentTheme.AppearanceTheme = CurrentTheme.AppearanceTheme != AppearanceTheme.Dark ? AppearanceTheme.Dark : AppearanceTheme.Light;
    }

    public static readonly JsonSerializerSettings JsonSettings = new JsonSerializerSettings {
        Converters = { new StringEnumConverter(new CamelCaseNamingStrategy()) },
        Formatting = Formatting.Indented
    };
}

public enum AppearanceTheme { Dark, Light }
