using System.Configuration;

namespace a2_coursework.Theming;
internal class ColourScheme(Color background, Color foreground, Color primary, Color primaryForeground, Color secondary, Color secondaryForeground, Color danger, Color warning, Color info) {
    public static ColourScheme CurrentTheme { get; private set; }

    // Colours based on the the tailwind css
    public static ColourScheme Dark { get; } = new(
            background: Color.FromArgb(9, 9, 10),
            foreground: Color.FromArgb(255, 255, 255),
            primary: Color.FromArgb(24, 24, 26),
            primaryForeground: Color.FromArgb(250, 250, 250),
            secondary: Color.FromArgb(113, 113, 118),
            secondaryForeground: Color.FromArgb(233, 233, 245),
            danger: Color.FromArgb(190, 18, 60),
            warning: Color.FromArgb(245, 158, 11),
            info: Color.FromArgb(22, 163, 74)
        );

    public static ColourScheme Light { get; } = new(
            background: Color.FromArgb(255, 255, 255),
            foreground: Color.FromArgb(9, 9, 10),
            primary: Color.FromArgb(250, 250, 250),
            primaryForeground: Color.FromArgb(24, 24, 26),
            secondary: Color.FromArgb(233, 233, 245),
            secondaryForeground: Color.FromArgb(113, 113, 118),
            danger: Color.FromArgb(225, 29, 72),
            warning: Color.FromArgb(251, 191, 36),
            info: Color.FromArgb(34, 197, 94)
        );

    public static Color Red = Color.FromArgb(220, 38, 38);
    public static Color RedDark = Color.FromArgb(185, 28, 28);
    public static Color RedLight = Color.FromArgb(239, 68, 68);

    public static Color PaleBlue = Color.FromArgb(14, 165, 233);
    public static Color PaleBlueDark = Color.FromArgb(2, 132, 199);
    public static Color PaleBlueLight = Color.FromArgb(56, 189, 248);

    public static Color Blue = Color.FromArgb(29, 78, 216);
    public static Color BlueDark = Color.FromArgb(30, 64, 175);
    public static Color BlueLight = Color.FromArgb(37, 99, 235);

    #region Themed Colours
    public Color Background { get; init; } = background;
    public Color Foreground { get; init; } = foreground;
    public Color Primary { get; init; } = primary;
    public Color PrimaryForeground { get; init; } = primaryForeground;
    public Color Secondary { get; init; } = secondary;
    public Color SecondaryForeground { get; init; } = secondaryForeground;
    public Color Danger { get; init; } = danger;
    public Color Warning { get; init; } = warning;
    public Color Info { get; init; } = info;
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

    static ColourScheme() {
        string? themeConfiguration = ConfigurationManager.AppSettings.Get("DefaultTheme");

        // If there is an error in App.config, default to a dark theme
        if (themeConfiguration == "light") CurrentTheme = Light;
        else CurrentTheme = Dark;
    }
}
