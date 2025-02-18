using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Configuration;

namespace a2_coursework.Theming;
public class Theme {
    static Theme() {
        _currentTheme = new Theme();
    }

    public Theme(AppearanceTheme? theme, bool? showToolTips, string? fontName) {
        AppearanceTheme = theme ?? AppearanceTheme.Dark;
        ShowToolTips = showToolTips ?? true;
        FontName = fontName ?? "Bahnschrift";
    }

    public Theme() {
        AppearanceTheme = ConfigurationManager.AppSettings.Get("DefaultTheme") != "light" ? AppearanceTheme.Dark : AppearanceTheme.Light;
        ShowToolTips = true;
        FontName = "Bahnschrift";
    }

    private static Theme _currentTheme;
    public static Theme Current {
        get => _currentTheme;
        set {
            Theme oldTheme = _currentTheme;
            _currentTheme = value;

            if (oldTheme.AppearanceTheme != _currentTheme.AppearanceTheme) AppearanceThemeChanged?.Invoke();
            if (oldTheme.ShowToolTips != _currentTheme.ShowToolTips) ShowToolTipsChanged?.Invoke();
            if (oldTheme.FontName != _currentTheme.FontName) FontNameChanged?.Invoke();
        }
    }

    public static event Action? AppearanceThemeChanged;
    private AppearanceTheme _appearanceTheme;
    public AppearanceTheme AppearanceTheme {
        get => _appearanceTheme;
        set {
            _appearanceTheme = value;
            AppearanceThemeChanged?.Invoke();
        }
    }

    public static event Action? ShowToolTipsChanged;
    private bool _showToolTips;
    public bool ShowToolTips {
        get => _showToolTips;
        set {
            _showToolTips = value;
            ShowToolTipsChanged?.Invoke();
        }
    }

    public static event Action? FontNameChanged;
    private string _fontName = "";
    public string FontName {
        get => _fontName;
        set {
            _fontName = value;
            FontNameChanged?.Invoke();
        }
    }

    public bool IsDarkMode => AppearanceTheme == AppearanceTheme.Dark;

    public static void ToggleTheme() {
        Current.AppearanceTheme = Current.AppearanceTheme != AppearanceTheme.Dark ? AppearanceTheme.Dark : AppearanceTheme.Light;
    }

    public static readonly JsonSerializerSettings JsonSettings = new JsonSerializerSettings {
        Converters = { new StringEnumConverter(new CamelCaseNamingStrategy()) },
        Formatting = Formatting.Indented
    };
}

public enum AppearanceTheme { Dark, Light }
