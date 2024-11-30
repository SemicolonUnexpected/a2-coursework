// using AS_Coursework._Helpers;

namespace AS_Coursework.Custom_Controls;
public partial class formCustomMessageBox : Form {
    public formCustomMessageBox(string text, string caption, MessageBoxButtons buttons) {
        InitializeComponent();

        Text = text;
        lblText.Text = caption;

        btnOk.DialogResult = DialogResult.OK;
        btnCancel.DialogResult = DialogResult.Cancel;

        SetupButtons(buttons);
    }

    public void SetupButtons(MessageBoxButtons buttons) {
        switch (buttons) {
            case MessageBoxButtons.OK:
                btnOk.Visible = true;
                btnCancel.Visible = false;

//                 btnOk.CenterY();
                btnOk.Location = new Point(pnlBottom.Width - (btnOk.Width + btnOk.Margin.Right), btnOk.Location.Y);
                btnOk.Anchor = AnchorStyles.Right;
                break;
            case MessageBoxButtons.OKCancel:
                btnOk.Visible = true;
                btnCancel.Visible = true;

//                 btnOk.CenterY();
                btnOk.Location = new Point(pnlBottom.Width - (btnCancel.Width + btnCancel.Margin.Horizontal + btnOk.Width + btnOk.Margin.Right), btnOk.Location.Y);
                btnOk.Anchor = AnchorStyles.Right;

//                 btnCancel.CenterY();
                btnCancel.Location = new Point(pnlBottom.Width - (btnCancel.Width + btnCancel.Margin.Right), btnCancel.Location.Y);
                btnCancel.Anchor = AnchorStyles.Right;
                break;
            default:
                throw new NotImplementedException();
        }
    }
}
