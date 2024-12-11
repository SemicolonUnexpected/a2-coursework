using System.Configuration;

namespace a2_coursework.Theming;
internal class ColourScheme {
    public static ColourScheme CurrentTheme { get; private set; }

    // Colours inspired by the the tailwind css defaults
    public static ColourScheme Dark { get; } = new(
        primaryForeground: Color.FromArgb(248, 250, 252),   // slate-50
        secondaryForeground: Color.FromArgb(156, 163, 175), // grey-400
        primaryBackground: Color.FromArgb(17, 24, 39),      // grey-900
        secondaryBackground: Color.FromArgb(31, 41, 55),    // grey-900
        red: Color.FromArgb(212, 0, 0),                 // red
        blue: Color.FromArgb(48, 154, 207)             // blue
        );

    public static ColourScheme Light { get; } = new(
        primaryForeground: Color.FromArgb(31, 41, 55),      // slate-900
        secondaryForeground: Color.FromArgb(156, 163, 175), // grey-400
        primaryBackground: Color.FromArgb(248, 250, 252),   // grey-50
        secondaryBackground: Color.FromArgb(248, 250, 252), // grey-50
        red: Color.FromArgb(212, 0, 0),                 // red
        blue: Color.FromArgb(48, 154, 207)             // blue
        );

    #region Colours
    public Color PrimaryForeground { get; private set; }
    public Color SecondaryForeground { get; private set; }
    public Color PrimaryBackground { get; private set; }
    public Color SecondaryBackground { get; private set; }
    public Color Red { get; private set; }
    public Color Blue { get; private set; }
    #endregion

    public static event EventHandler? ColourSchemeChanged;

    public static void SetColourSchemeDark() {
        CurrentTheme = Dark;

        ColourSchemeChanged?.Invoke(null, new EventArgs());
    }

    public static void SetColourSchemeLight() {
        CurrentTheme = Light;

        ColourSchemeChanged?.Invoke(null, new EventArgs());
    }

    public static void ToggleColourScheme() {
        if (CurrentTheme == Dark) CurrentTheme = Light;
        else CurrentTheme = Dark;

        ColourSchemeChanged?.Invoke(null, new EventArgs());
    }

    public ColourScheme(Color primaryForeground, Color secondaryForeground, Color primaryBackground, Color secondaryBackground, Color red, Color blue) {
        PrimaryForeground = primaryForeground;
        Blue = blue;
        Red = red;
        SecondaryBackground = secondaryBackground;
        PrimaryBackground = primaryBackground;
        SecondaryForeground = secondaryForeground;
    }

    static ColourScheme() {
        string? themeConfiguration = ConfigurationManager.AppSettings.Get("DefaultTheme");

        // If there is an error in App.config, default to a dark theme
        if (themeConfiguration == "light") CurrentTheme = Light;
        else CurrentTheme = Dark;
    }
}
