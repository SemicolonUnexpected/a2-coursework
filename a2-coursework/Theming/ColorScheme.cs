namespace a2_coursework.Theming;
internal class ColorScheme(Color background, Color foreground, Color primary, Color primaryForeground, Color secondary, Color secondaryForeground, Color danger, Color warning, Color info, Color data) {
    public static ColorScheme Current {
        get {
            if (Theme.Current.AppearanceTheme == AppearanceTheme.Dark) return Dark;
            else return Light;
        }
    }

    // Colours based on tailwind css
    public static ColorScheme Dark { get; } = new(
            background: Color.FromArgb(9, 9, 10),
            foreground: Color.FromArgb(250, 250, 250),
            primary: Color.FromArgb(39, 39, 42),
            primaryForeground: Color.FromArgb(168, 171, 174),
            secondary: Color.FromArgb(24, 24, 27),
            secondaryForeground: Color.FromArgb(226, 226, 226),
            danger: Color.FromArgb(190, 18, 60),
            warning: Color.FromArgb(245, 158, 11),
            info: Color.FromArgb(22, 163, 74),
            data: Color.FromArgb(14, 165, 233)
        );

    public static ColorScheme Light { get; } = new(
            background: Color.FromArgb(250, 250, 250),
            foreground: Color.FromArgb(9, 9, 10),
            primary: Color.FromArgb(200, 200, 204),
            primaryForeground: Color.FromArgb(133, 133, 134),
            secondary: Color.FromArgb(226, 226, 226),
            secondaryForeground: Color.FromArgb(24, 24, 27),
            danger: Color.FromArgb(225, 29, 72),
            warning: Color.FromArgb(251, 191, 36),
            info: Color.FromArgb(34, 197, 94),
            data: Color.FromArgb(56, 189, 248)
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
    public Color Data { get; init; } = data;
    #endregion
}
