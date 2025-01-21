using a2_coursework.CustomControls;

namespace a2_coursework.Theming;
internal static class ThemingExtenders {

    public static void Theme(this Form form) {
        form.BackColor = ColorScheme.CurrentTheme.Background;
        form.ForeColor = ColorScheme.CurrentTheme.Foreground;
    }

    public static void Theme(this CustomTextBox customTextBox) {
        customTextBox.BackColor = ColorScheme.CurrentTheme.Background;
        customTextBox.ForeColor = ColorScheme.CurrentTheme.Foreground;
        customTextBox.BorderColor = ColorScheme.CurrentTheme.Primary;
        customTextBox.PlaceholderTextColor = ColorScheme.CurrentTheme.PrimaryForeground;
    }

    public static void ThemeTitle(this Label label) {
        label.ForeColor = ColorScheme.CurrentTheme.Foreground;
    }

    public static void ThemeSubtitle(this Label label) {
        label.ForeColor = ColorScheme.CurrentTheme.PrimaryForeground;
    }

    public static void ThemeError(this Label label) {
        label.ForeColor = ColorScheme.Red;
    }

    public static void ThemeStrong(this CustomButton button) {
        button.BackColor = ColorScheme.CurrentTheme.Foreground;
        button.ForeColor = ColorScheme.CurrentTheme.Background;
        button.HoverColor = ColorScheme.CurrentTheme.SecondaryForeground;
        button.ClickedColor = ColorScheme.CurrentTheme.SecondaryForeground;
        button.DisabledColor = ColorScheme.CurrentTheme.SecondaryForeground;
    }

    public static void ThemeWeak(this CustomButton button) {
        button.BackColor = ColorScheme.CurrentTheme.Background;
        button.HoverColor = ColorScheme.CurrentTheme.Primary;
        button.BorderColor = ColorScheme.CurrentTheme.Primary;
        button.ClickedColor = ColorScheme.CurrentTheme.Primary;
    }

    public static void Theme(this CustomPanel panel) {
        panel.BackColor = ColorScheme.CurrentTheme.Background;
        panel.BorderColor = ColorScheme.CurrentTheme.Primary;
    }

    public static void Theme(this CustomScrollBar scrollBar) {
        scrollBar.BackColor = ColorScheme.CurrentTheme.Background;
        scrollBar.ThumbColor = ColorScheme.CurrentTheme.Secondary;
        scrollBar.ThumbClickedColor = ColorScheme.CurrentTheme.Primary;
        scrollBar.ThumbHoverColor = ColorScheme.CurrentTheme.Primary;
    }
}
