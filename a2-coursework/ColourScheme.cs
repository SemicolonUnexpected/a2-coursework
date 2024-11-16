using System.Configuration;

namespace a2_coursework;
internal class ColourScheme {
    public static ColourScheme Current { get; private set; }

    // Colours inspired by the the tailwind css defaults
    private static ColourScheme _light = new(
        primaryForeground: Color.FromArgb(248, 250, 252),   // slate-50
        secondaryForeground: Color.FromArgb(156, 163, 175), // grey-400
        primaryBackground: Color.FromArgb(17, 24, 39),      // grey-900
        secondaryBackground: Color.FromArgb(31, 41, 55),    // grey-900
        primary: Color.FromArgb(212, 0, 0),                 // red
        secondary: Color.FromArgb(48, 154, 207),            // blue
        highlight: Color.FromArgb(132, 204, 22) // lime-500
        );

    private static readonly ColourScheme _dark = new(
        primaryForeground: Color.FromArgb(248, 250, 252),   // slate-50
        secondaryForeground: Color.FromArgb(156, 163, 175), // grey-400
        primaryBackground: Color.FromArgb(17, 24, 39),      // grey-900
        secondaryBackground: Color.FromArgb(31, 41, 55),    // grey-900
        primary: Color.FromArgb(212, 0, 0),                 // red
        secondary: Color.FromArgb(48, 154, 207),            // blue
        highlight: Color.FromArgb(132, 204, 22) // lime-500
        );

    #region Colours
    public Color PrimaryForeground { get; private set; }
    public Color SecondaryForeground { get; private set; }
    public Color PrimaryBackground { get; private set; }
    public Color SecondaryBackground { get; private set; }
    public Color Primary { get; private set; }
    public Color Secondary { get; private set; }
    public Color Highlight {  get; private set; }
    #endregion

    public static event EventHandler? ColourSchemeChanged;

    public static void SetColourSchemeDark() {
        Current = _dark;

        ColourSchemeChanged?.Invoke(null, new EventArgs());
    }

    public static void SetColourSchemeLight() {
        Current = _light;

        ColourSchemeChanged?.Invoke(null, new EventArgs());
    }

    public static void ToggleColourScheme() {
        if (Current == _dark) Current = _light;
        else Current = _dark;

        ColourSchemeChanged?.Invoke(null, new EventArgs());
    }

    public ColourScheme(Color primaryForeground, Color secondaryForeground, Color primaryBackground, Color secondaryBackground, Color primary, Color secondary, Color highlight) {
        PrimaryForeground = primaryForeground;
        Secondary = secondary;
        Primary = primary;
        SecondaryBackground = secondaryBackground;
        PrimaryBackground = primaryBackground;
        SecondaryForeground = secondaryForeground;
        Highlight = highlight;
    }
    
    static ColourScheme() {
        string? colourSchemeConfiguration = ConfigurationManager.AppSettings.Get("DefaultColourScheme");

        if (colourSchemeConfiguration is null) throw new ArgumentNullException("Colour scheme configuration in App.config is null");
        else if (colourSchemeConfiguration == "dark") Current = _dark;
        else if (colourSchemeConfiguration == "light") Current = _light;
        else throw new ArgumentException($"Colour scheme default of '{colourSchemeConfiguration}' not recognised");
    }
}
