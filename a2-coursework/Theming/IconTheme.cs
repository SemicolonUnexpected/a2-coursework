using a2_coursework.Properties;
using System.Configuration;

namespace a2_coursework.Theming;
internal class IconTheme() {
    public static IconTheme CurrentTheme;

    public static IconTheme Dark { get; } = new(
        );

    public static IconTheme Light { get; } = new(
        );

    #region Static Icons
    public static Image Logo { get; } = Resources.Logo;
    public static Image Brightness { get; } = Resources.brightness;
    public static Image Moon { get; } = Resources.moon;
    #endregion

    #region Themed Icons
    
    #endregion

    static IconTheme() {
        string? themeConfiguration = ConfigurationManager.AppSettings.Get("DefaultTheme");

        // If there is an error in App.config, default to a dark theme
        if (themeConfiguration == "light") CurrentTheme = Light;
        else CurrentTheme = Dark;
    }
}