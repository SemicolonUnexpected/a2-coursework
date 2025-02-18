using a2_coursework.Properties;

namespace a2_coursework.Theming;
internal class IconTheme(Image eye, Image eyeCrossed, Image settings, Image backArrow, Image forwardArrow, Image doubleBackArrow, Image doubleForwardArrow, Image plus, Image minus, Image navigation, Image search, Image cross, Image tick, Image edit, Image delete, Image archive, Image restore, Image openBox, Image closedBox) {
    public static IconTheme CurrentTheme {
        get {
            if (Theme.Current.AppearanceTheme == AppearanceTheme.Dark) return Dark;
            else return Light;
        }
    }

    public static IconTheme Dark { get; } = new(
        eye: Resources.eye_light,
        eyeCrossed: Resources.eye_crossed_light,
        settings: Resources.settings_sliders_light,
        backArrow: Resources.chevron_left_light,
        forwardArrow: Resources.chevron_right_light,
        doubleBackArrow: Resources.chevrons_left_light,
        doubleForwardArrow: Resources.chevrons_right_light,
        plus: Resources.plus_light,
        minus: Resources.minus_light,
        navigation: Resources.navigation_light,
        search: Resources.search_light,
        cross: Resources.cross_light,
        tick: Resources.check_light,
        edit: Resources.pencil_light,
        delete: Resources.trash_light,
        archive: Resources.archive_light,
        restore: Resources.archive_restore_light,
        openBox: Resources.package_open_light,
        closedBox: Resources.package_light
        );

    public static IconTheme Light { get; } = new(
        eye: Resources.eye_dark,
        eyeCrossed: Resources.eye_crossed_dark,
        settings: Resources.settings_sliders_dark,
        backArrow: Resources.chevron_left_dark,
        forwardArrow: Resources.chevron_right_dark,
        doubleBackArrow: Resources.chevrons_left_dark,
        doubleForwardArrow: Resources.chevrons_right_dark,
        plus: Resources.plus_dark,
        minus: Resources.minus_dark,
        navigation: Resources.navigation_dark,
        search: Resources.search_dark,
        cross: Resources.cross_dark,
        tick: Resources.check_dark,
        edit: Resources.pencil_dark,
        delete: Resources.trash_dark,
        archive: Resources.archive_dark,
        restore: Resources.archive_restore_dark,
        openBox: Resources.package_open_dark,
        closedBox: Resources.package_dark
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
    public Image BackArrow { get; } = backArrow;
    public Image ForwardArrow { get; } = forwardArrow;
    public Image DoubleBackArrow { get; } = doubleBackArrow;
    public Image DoubleForwardArrow { get; } = doubleForwardArrow;
    public Image Plus { get; } = plus;
    public Image Minus { get; } = minus;
    public Image Navigation { get; } = navigation;
    public Image Search { get; } = search;
    public Image Cross { get; } = cross;
    public Image Tick { get; } = tick;
    public Image Edit { get; } = edit;
    public Image Delete { get; } = delete;
    public Image Archive { get; } = archive;
    public Image Restore { get; } = restore;
    public Image ClosedBox { get; } = closedBox;
    public Image OpenBox { get; } = openBox;

    #endregion
}