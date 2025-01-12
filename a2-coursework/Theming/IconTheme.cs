using a2_coursework.Properties;

namespace a2_coursework.Theming;
internal class IconTheme(Image eye, Image eyeCrossed, Image settings, Image backArrow) {
    public static IconTheme CurrentTheme {
        get {
            if (ColorScheme.CurrentTheme == ColorScheme.Dark) return Dark;
            else return Light;
        }
    }

    public static IconTheme Dark { get; } = new(
        eye: Resources.eye_light,
        eyeCrossed: Resources.eye_crossed_light,
        settings: Resources.settings_sliders_light,
        backArrow: Resources.chevron_left_light
        );

    public static IconTheme Light { get; } = new(
        eye: Resources.eye_dark,
        eyeCrossed: Resources.eye_crossed_dark,
        settings: Resources.settings_sliders_dark,
        backArrow: Resources.chevron_left_dark
        );

    #region Static Icons
    public static Image Logo { get; } = Resources.Logo;
    public static Image Brightness { get; } = Resources.brightness;
    public static Image Moon { get; } = Resources.moon;
    #endregion

    #region Themed Icons
    public Image Eye { get; } = eye;
    public Image EyeCrossed { get; } = eyeCrossed;
    public Image Settings { get; } = settings;
    public Image BackArrow { get;  } = backArrow;
    #endregion
}