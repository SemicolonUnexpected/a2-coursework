using a2_coursework.UserControls;

namespace a2_coursework.Theming;
public partial class TestView : Form {
    public TestView() {
        InitializeComponent();

        dataGridView1.EnableHeadersVisualStyles = false;

        dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorScheme.CurrentTheme.Background;
        dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = ColorScheme.CurrentTheme.Foreground;
        dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorScheme.CurrentTheme.Primary;
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


        dataGridView1.Rows.Add("item one",   false, DateTime.Now);
        dataGridView1.Rows.Add("item two",   false, DateTime.Now);
        dataGridView1.Rows.Add("item three", false, DateTime.Now);
        dataGridView1.Rows.Add("item four",  false, DateTime.Now);

        //dataGridView1.Columns["Column2"].CellTemplate = new DataGridViewCheckBoxCell();
    }
}
