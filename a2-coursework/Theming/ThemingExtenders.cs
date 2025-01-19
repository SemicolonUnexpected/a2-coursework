using a2_coursework.CustomControls;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;

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
        label.BackColor = ColorScheme.CurrentTheme.Background;
    }

    public static void ThemeSubtitle(this Label label) {
        label.BackColor = ColorScheme.CurrentTheme.Background;
        label.ForeColor = ColorScheme.CurrentTheme.PrimaryForeground;
    }
}
