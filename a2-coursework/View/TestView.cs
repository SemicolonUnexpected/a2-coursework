using a2_coursework.UserControls;

namespace a2_coursework.Theming;
public partial class TestView : Form {
    public TestView() {
        InitializeComponent();

        dataGridView1.EnableHeadersVisualStyles = false;

        dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorScheme.CurrentTheme.Background;
        dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = ColorScheme.CurrentTheme.Foreground;
        dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorScheme.CurrentTheme.Background;
        dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = ColorScheme.CurrentTheme.Foreground;

        dataGridView1.AdvancedColumnHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
        dataGridView1.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
        dataGridView1.AdvancedColumnHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
        dataGridView1.AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

        dataGridView1.RowHeadersDefaultCellStyle.BackColor = ColorScheme.CurrentTheme.Background;
        dataGridView1.RowHeadersDefaultCellStyle.ForeColor = ColorScheme.CurrentTheme.Foreground;
        dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = ColorScheme.CurrentTheme.Primary;
        dataGridView1.RowHeadersDefaultCellStyle.SelectionForeColor = ColorScheme.CurrentTheme.Foreground;

        dataGridView1.AdvancedRowHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
        dataGridView1.AdvancedRowHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
        dataGridView1.AdvancedRowHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
        dataGridView1.AdvancedRowHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

        dataGridView1.GridColor = ColorScheme.CurrentTheme.Primary;
        dataGridView1.DefaultCellStyle.BackColor = ColorScheme.CurrentTheme.Background;
        dataGridView1.DefaultCellStyle.ForeColor = ColorScheme.CurrentTheme.Foreground;
        dataGridView1.DefaultCellStyle.SelectionBackColor = ColorScheme.CurrentTheme.Primary;
        dataGridView1.DefaultCellStyle.SelectionForeColor = ColorScheme.CurrentTheme.Foreground;

        dataGridView1.BackgroundColor = ColorScheme.CurrentTheme.Background;
        dataGridView1.ForeColor = ColorScheme.CurrentTheme.Foreground;


        dataGridView1.Rows.Add("item one", false, DateTime.Now);
        dataGridView1.Rows.Add("item two", false, DateTime.Now);
        dataGridView1.Rows.Add("item three", false, DateTime.Now);
        dataGridView1.Rows.Add("item four", false, DateTime.Now);
        for (int i = 0; i < 100; i++) {
            dataGridView1.Rows.Add($"item {i}", false, DateTime.Now, "abc");
        }

        foreach (DataGridViewRow row in dataGridView1.Rows) {
            row.Height = 50;
        }

        //dataGridView1.Columns["Column2"].CellTemplate = new DataGridViewCheckBoxCell();
    }

    private void dataGridView1_Scroll(object sender, ScrollEventArgs e) {
        MessageBox.Show($"{e.OldValue}, {e.NewValue}");
    }

    private void customNumericUpDown1_Load(object sender, EventArgs e) {

    }

    private void customNumericUpDown1_ValueChanged(object sender, EventArgs e) {
        dataGridView1.FirstDisplayedScrollingRowIndex += 1;
    }

    private void topMenu1_SelectedIndexChanged(object sender, EventArgs e) {
        MessageBox.Show(topMenu1.SelectedIndex.ToString());
    }
}
