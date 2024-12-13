using System.Configuration;

namespace a2_coursework.Theming;
internal class ColourScheme {
    public static ColourScheme CurrentTheme { get; private set; }

    // Colours based on the the tailwind css defaults
    public static ColourScheme Dark { get; } = new(
        primaryForeground:      Color.FromArgb(248, 250, 252),      // slate-50
        secondaryForeground:    Color.FromArgb(203, 213, 225),      // slate-300
        primaryBackground:      Color.FromArgb(15, 23, 42),         // slate-900
        secondaryBackground:    Color.FromArgb(30, 41, 59)          // slate-800
        );

    public static ColourScheme Light { get; } = new(
        primaryForeground:      Color.FromArgb(15, 23, 42),         // slate-900
        secondaryForeground:    Color.FromArgb(30, 41, 59),         // slate-800
        primaryBackground:      Color.FromArgb(248, 250, 252),      // slate-50
        secondaryBackground:    Color.FromArgb(203, 213, 225)       // slate-300
        );

    public static Color Red = Color.FromArgb(185, 28, 28);          // red-700
    public static Color RedDark = Color.FromArgb(153, 27, 27);      // red-800
    public static Color RedLight = Color.FromArgb(220, 38, 38);     // red-600

    public static Color Blue = Color.FromArgb(14, 165, 233);        // sky-500
    public static Color BlueDark = Color.FromArgb(2, 132, 199);     // sky-600
    public static Color BlueLight = Color.FromArgb(56, 189, 248);   // sky-400

    #region Themed Colours
    public Color PrimaryForeground { get; private set; }
    public Color SecondaryForeground { get; private set; }
    public Color PrimaryBackground { get; private set; }
    public Color SecondaryBackground { get; private set; }
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

    public ColourScheme(Color primaryForeground, Color secondaryForeground, Color primaryBackground, Color secondaryBackground) {
        PrimaryForeground = primaryForeground;
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
