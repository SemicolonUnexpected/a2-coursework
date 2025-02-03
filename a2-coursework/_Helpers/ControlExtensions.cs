namespace a2_coursework._Helpers;
public static class ControlExtensions {
    public static void ExecuteRecursive(this Control control, Action<Control> a) => ControlHelpers.ExecuteRecursive(control, a);

    public static void SetFontName(this Control control, string fontName) => ControlHelpers.SetFontName(control, fontName);
}
