namespace a2_coursework.CustomControls; 
public static class CustomMessageBox {

    public static DialogResult Show(string text, string caption) {
        CustomMessageBoxView messageBox = new(text, caption, MessageBoxButtons.OK);
        return messageBox.ShowDialog();
    }

    public static DialogResult Show(string text, string caption, MessageBoxButtons buttons) {
        CustomMessageBoxView messageBox = new(text, caption, buttons);
        return messageBox.ShowDialog();
    }
}