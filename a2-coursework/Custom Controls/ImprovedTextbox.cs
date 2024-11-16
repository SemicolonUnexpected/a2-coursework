namespace AS_Coursework.Custom_Controls; 
// This class is needed for the customTextBox so that unwanted features of the default textbox can be disabled
public partial class ImprovedTextbox : TextBox {

    // WndProc flags
    private const int EM_SHOWBALLOONTIP = 0x1503;

    public ImprovedTextbox() { }

    protected override void WndProc(ref Message m) {
        // If the textbox recieves the show tooltip message return
        if (m.Msg == EM_SHOWBALLOONTIP) {
            m.Result = 0;
            return;
        }
        base.WndProc(ref m);
    }
}
