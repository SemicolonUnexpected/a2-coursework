using a2_coursework.CustomControls;

namespace a2_coursework.Theming;
internal static class ThemingExtenders {

    public static void Theme(this Form form) {
        form.BackColor = ColorScheme.Current.Background;
        form.ForeColor = ColorScheme.Current.Foreground;
    }

    public static void Theme(this CustomTextBox customTextBox) {
        customTextBox.BackColor = ColorScheme.Current.Background;
        customTextBox.ForeColor = ColorScheme.Current.Foreground;
        customTextBox.BorderColor = ColorScheme.Current.Primary;
        customTextBox.PlaceholderTextColor = ColorScheme.Current.PrimaryForeground;
    }

    public static void ThemeTitle(this Label label) {
        label.ForeColor = ColorScheme.Current.Foreground;
    }

    public static void ThemeSubtitle(this Label label) {
        label.ForeColor = ColorScheme.Current.PrimaryForeground;
    }

    public static void ThemeError(this Label label) {
        label.ForeColor = ColorScheme.Red;
    }

    public static void ThemeStrong(this CustomButton button) {
        button.BackColor = ColorScheme.Current.Foreground;
        button.ForeColor = ColorScheme.Current.Background;
        button.HoverColor = ColorScheme.Current.SecondaryForeground;
        button.ClickedColor = ColorScheme.Current.SecondaryForeground;
        button.DisabledColor = ColorScheme.Current.SecondaryForeground;
    }

    public static void ThemeWeak(this CustomButton button) {
        button.BackColor = ColorScheme.Current.Background;
        button.HoverColor = ColorScheme.Current.Primary;
        button.BorderColor = ColorScheme.Current.Primary;
        button.ClickedColor = ColorScheme.Current.Primary;
    }

    public static void Theme(this CustomPanel panel) {
        panel.BackColor = ColorScheme.Current.Background;
        panel.BorderColor = ColorScheme.Current.Primary;
    }

    public static void Theme(this CustomScrollBar scrollBar) {
        scrollBar.BackColor = ColorScheme.Current.Background;
        scrollBar.ThumbColor = ColorScheme.Current.Secondary;
        scrollBar.ThumbClickedColor = ColorScheme.Current.Primary;
        scrollBar.ThumbHoverColor = ColorScheme.Current.Primary;
    }

    public static void Theme(this DateInput dateInput) {
        dateInput.BackColor = ColorScheme.Current.Background;
        dateInput.ForeColor = ColorScheme.Current.Foreground;
        dateInput.BorderColor = ColorScheme.Current.Primary;
        dateInput.PlaceholderTextColor = ColorScheme.Current.PrimaryForeground;
        dateInput.BorderErrorColor = ColorScheme.Current.Danger;
    }

    public static void Theme(this CustomRadioButton radioButton) {
        radioButton.ForeColor = ColorScheme.Current.Foreground;
        radioButton.CheckColor = ColorScheme.Current.Foreground;
    }

    public static void Theme(this DataGridView dataGridView) {
        dataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorScheme.Current.Background;
        dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = ColorScheme.Current.Foreground;
        dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorScheme.Current.Background;

        dataGridView.AdvancedColumnHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
        dataGridView.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
        dataGridView.AdvancedColumnHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
        dataGridView.AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

        dataGridView.RowHeadersDefaultCellStyle.BackColor = ColorScheme.Current.Background;
        dataGridView.RowHeadersDefaultCellStyle.ForeColor = ColorScheme.Current.Foreground;
        dataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = ColorScheme.Current.Primary;
        dataGridView.RowHeadersDefaultCellStyle.SelectionForeColor = ColorScheme.Current.Foreground;

        dataGridView.RowsDefaultCellStyle.BackColor = ColorScheme.Current.Background;
        dataGridView.RowsDefaultCellStyle.ForeColor = ColorScheme.Current.Foreground;
        dataGridView.RowsDefaultCellStyle.SelectionBackColor = ColorScheme.Current.Primary;
        dataGridView.RowsDefaultCellStyle.SelectionForeColor = ColorScheme.Current.Foreground;

        dataGridView.AdvancedRowHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
        dataGridView.AdvancedRowHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
        dataGridView.AdvancedRowHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
        dataGridView.AdvancedRowHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

        dataGridView.GridColor = ColorScheme.Current.Primary;
        dataGridView.DefaultCellStyle.BackColor = ColorScheme.Current.Background;
        dataGridView.DefaultCellStyle.ForeColor = ColorScheme.Current.Foreground;
        dataGridView.DefaultCellStyle.SelectionBackColor = ColorScheme.Current.Primary;
        dataGridView.DefaultCellStyle.SelectionForeColor = ColorScheme.Current.Foreground;

        dataGridView.BackgroundColor = ColorScheme.Current.Background;
        dataGridView.ForeColor = ColorScheme.Current.Foreground;
    }
}
