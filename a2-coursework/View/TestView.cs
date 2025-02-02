using a2_coursework.UserControls;

namespace a2_coursework.Theming;
public partial class TestView : Form {
    public TestView() {
        InitializeComponent();

        comboBox1.Items.AddRange(new string[] { "Item 1", "Item 2", "Item 3" });
        comboBox1.DrawItem += ComboBox1_DrawItem;

    }


    private void ComboBox1_DrawItem(object sender, DrawItemEventArgs e) {
        if (e.Index < 0) return; // Avoid drawing issues when no item is selected

        e.DrawBackground(); // Default background (system color)

        // Change the selection highlight color
        Color backgroundColor = (e.State & DrawItemState.Selected) != 0 ? Color.Orange : Color.White;
        Color textColor = (e.State & DrawItemState.Selected) != 0 ? Color.Black : Color.Black;

        using (SolidBrush bgBrush = new SolidBrush(backgroundColor))
        using (SolidBrush textBrush = new SolidBrush(textColor)) {
            e.Graphics.FillRectangle(bgBrush, e.Bounds);
            e.Graphics.DrawString(comboBox1.Items[e.Index].ToString(), e.Font, textBrush, e.Bounds);
        }

        e.DrawFocusRectangle(); // Optional: Draw focus rectangle
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void button1_Click(object sender, EventArgs e) {
        SuspendLayout();
        comboBox1.DroppedDown = true;

        comboBox1.Location = new Point(comboBox1.Location.X, comboBox1.Location.Y - 10);
        ResumeLayout(true);
    }

    private void button2_Click(object sender, EventArgs e) {

        comboBox1.Visible = !comboBox1.Visible;

    }
}
