using a2_coursework.UserControls;

namespace a2_coursework.Theming;
public partial class TestView : Form {
    public TestView() {
        InitializeComponent();

        customComboBox1.Items.AddRange(["one", "two", "Three"]);
    }
}
