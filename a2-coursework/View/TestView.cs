namespace a2_coursework.Theming;
public partial class TestView : Form {
    public TestView() {
        InitializeComponent();

    }

    private void button1_Click(object sender, EventArgs e) {
        MessageBox.Show(dateInput1.Date.ToString());
    }
}
