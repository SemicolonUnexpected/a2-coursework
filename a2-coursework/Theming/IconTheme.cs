using a2_coursework.Properties;
using System.Configuration;

namespace a2_coursework.Theming;
internal class IconTheme(Image eye, Image eyeCrossed, Image sun, Image moon) {
    public static IconTheme CurrentTheme;

    public static IconTheme Dark { get; } = new(
        eye: Resources.EyeWhite,
        eyeCrossed:  Resources.EyeCrossedWhite,
        sun:   Resources.SunWhite,
        moon: Resources.MoonWhite
        );

     public static IconTheme Light { get; } = new(
        eye: Resources.EyeSlate,
        eyeCrossed:  Resources.EyeCrossedSlate,
        sun:   Resources.SunSlate,
        moon: Resources.MoonSlate
        );

    #region Static Icons
    //public static Image Logo { get; } = Resources.Logo;
    #endregion

    #region Themed Icons
    public Image Eye { get; init; } = eye;
    public Image EyeCrossed { get; init; } = eyeCrossed;
    public Image Sun { get; init; } = sun;
    public Image Moon { get; init; } = moon;
    
    #endregion

    static IconTheme() {
        string? themeConfiguration = ConfigurationManager.AppSettings.Get("DefaultTheme");

        // If there is an error in App.config, default to a dark theme
        if (themeConfiguration == "light") CurrentTheme = Light;
        else CurrentTheme = Dark;
    }
}