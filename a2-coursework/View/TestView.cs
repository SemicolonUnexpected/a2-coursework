using a2_coursework.UserControls;

namespace a2_coursework.Theming;
public partial class TestView : Form {
    public TestView() {
        InitializeComponent();

    }

    private void button1_Click(object sender, EventArgs e) {
        MessageBox.Show(dateInput1.Date.ToString());
        toggleButton1.PreviewToggleChanged -= toggleButton1_PreviewToggleChanged;
    }

    private void toggleButton1_ToggleChanged(object sender, EventArgs e) {

    }

    private void toggleButton1_PreviewToggleChanged(object sender, ToggleEventArgs e) {
        e.Handled = true;
    }
}
