using Microsoft.IdentityModel.Tokens;

namespace a2_coursework.CustomControls; 

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

    protected override void OnKeyDown(KeyEventArgs e) {
        if (Text.IsNullOrEmpty()) {
            _showPlaceholderText = false;
            Invalidate();
        }
        base.OnKeyDown(e);
    }


    private bool _showPlaceholderText;
    private string _placeholderText;
    public override string PlaceholderText {
        get => _placeholderText;
        set {
            _placeholderText = value;
        }
    }

    protected override void OnPaint(PaintEventArgs e) {
        if (!string.IsNullOrWhiteSpace(_placeholderText) && _showPlaceholderText) {
            e.Graphics.DrawString(_placeholderText, Font, new SolidBrush(ForeColor), new Point(2, 2));
        }
        base.OnPaint(e);
    }
}
