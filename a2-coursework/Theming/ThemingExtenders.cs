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

    public static void Theme(this DateInput dateInput) {
        dateInput.BackColor = ColorScheme.CurrentTheme.Background;
        dateInput.ForeColor = ColorScheme.CurrentTheme.Foreground;
        dateInput.BorderColor = ColorScheme.CurrentTheme.Primary;
        dateInput.PlaceholderTextColor = ColorScheme.CurrentTheme.PrimaryForeground;
        dateInput.BorderErrorColor = ColorScheme.CurrentTheme.Danger;
    }

    public static void Theme(this CustomRadioButton radioButton) {
        radioButton.ForeColor = ColorScheme.CurrentTheme.Foreground;
        radioButton.CheckColor = ColorScheme.CurrentTheme.Foreground;
    }

    public static void Theme(this DataGridView dataGridView) {
        dataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorScheme.CurrentTheme.Background;
        dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = ColorScheme.CurrentTheme.Foreground;
        dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorScheme.CurrentTheme.Background;

        dataGridView.AdvancedColumnHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
        dataGridView.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
        dataGridView.AdvancedColumnHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
        dataGridView.AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

        dataGridView.RowHeadersDefaultCellStyle.BackColor = ColorScheme.CurrentTheme.Background;
        dataGridView.RowHeadersDefaultCellStyle.ForeColor = ColorScheme.CurrentTheme.Foreground;
        dataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = ColorScheme.CurrentTheme.Primary;
        dataGridView.RowHeadersDefaultCellStyle.SelectionForeColor = ColorScheme.CurrentTheme.Foreground;

        dataGridView.RowsDefaultCellStyle.BackColor = ColorScheme.CurrentTheme.Background;
        dataGridView.RowsDefaultCellStyle.ForeColor = ColorScheme.CurrentTheme.Foreground;
        dataGridView.RowsDefaultCellStyle.SelectionBackColor = ColorScheme.CurrentTheme.Primary;
        dataGridView.RowsDefaultCellStyle.SelectionForeColor = ColorScheme.CurrentTheme.Foreground;

        dataGridView.AdvancedRowHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
        dataGridView.AdvancedRowHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
        dataGridView.AdvancedRowHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
        dataGridView.AdvancedRowHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

        dataGridView.GridColor = ColorScheme.CurrentTheme.Primary;
        dataGridView.DefaultCellStyle.BackColor = ColorScheme.CurrentTheme.Background;
        dataGridView.DefaultCellStyle.ForeColor = ColorScheme.CurrentTheme.Foreground;
        dataGridView.DefaultCellStyle.SelectionBackColor = ColorScheme.CurrentTheme.Primary;
        dataGridView.DefaultCellStyle.SelectionForeColor = ColorScheme.CurrentTheme.Foreground;

        dataGridView.BackgroundColor = ColorScheme.CurrentTheme.Background;
        dataGridView.ForeColor = ColorScheme.CurrentTheme.Foreground;
    }
}
