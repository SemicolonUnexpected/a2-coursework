using System.Text;

namespace a2_coursework.User_Controls; 
public partial class JaggedStringArrayEditorForm : Form {
    public string[][]? JaggedStringArray { get; private set; }

    public MenuItemData Data => new MenuItemData() { Strings = JaggedStringArray };

    public JaggedStringArrayEditorForm(MenuItemData data) {
        InitializeComponent();

        JaggedStringArray = data.Strings;
        GetArrayText();
    }

    private void GetArrayText() {
        if (JaggedStringArray is null) {
            tb.Text = "";
            return;
        }

        StringBuilder stringBuilder = new StringBuilder();
        foreach (string[] array in JaggedStringArray) {
            stringBuilder.AppendLine(string.Join(", ", array));
        }

        tb.Text = stringBuilder.ToString();
    }

    private void ConvertArrayText() {
        string[] lines = tb.Lines;

        JaggedStringArray = new string[lines.Length][];
        for (int i = 0; i < lines.Length; i++) {
            JaggedStringArray[i] = lines[i].Split(", ");
        }
    }

    private void btnDone_Click(object sender, EventArgs e) {
        try {
            ConvertArrayText();
            DialogResult = DialogResult.OK;
        }
        catch {
            MessageBox.Show("Invalid jagged string array");
        }
    }

    private void btnCancel_Click(object sender, EventArgs e) {
        DialogResult = DialogResult.Cancel;
    }
}
