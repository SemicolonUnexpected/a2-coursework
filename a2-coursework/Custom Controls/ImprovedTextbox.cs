using Microsoft.IdentityModel.Tokens;
using System.ComponentModel;

namespace a2_coursework.CustomControls;

// This class is needed for the customTextBox so that unwanted features of the default textbox can be disabled
public partial class ImprovedTextBox : TextBox {

    // WndProc flags
    private const int EM_SHOWBALLOONTIP = 0x1503;

    protected override void WndProc(ref Message m) {
        // If the textbox recieves the show tooltip message return
        if (m.Msg == EM_SHOWBALLOONTIP) {
            m.Result = 0;
            return;
        }

        base.WndProc(ref m);
    }

    private bool _isPlaceholderText = false;
    private string _placeholderText = "";
    [Category("Placeholder Text")]
    public new string PlaceholderText {
        get => _placeholderText;
        set {
            _placeholderText = value;
            TrySetPlaceholderText();
        }
    }

    private Color _placeholderTextColor;
    [Category("Placeholder Text")]
    public Color PlaceholderTextColor {
        get => _placeholderTextColor;
        set {
            _placeholderTextColor = value;
            TrySetPlaceholderText();
        }
    }

    private Color _foreColor;
    public new Color ForeColor {
        get => _foreColor;
        set {
            _foreColor = value;
            if (!_isPlaceholderText) base.ForeColor = _foreColor;
        }
    }

    public new string Text {
        get {
            if (_isPlaceholderText) return "";
            return base.Text;
        }
        set {
            TryRemovePlaceholderText();
            base.Text = value;
            TrySetPlaceholderText();
        }
    }

    private bool _usePasswordChar = false;
    [DefaultValue(false)]
    public bool UsePasswordChar {
        get => _usePasswordChar;
        set {
            _usePasswordChar = value;
            if (!_isPlaceholderText) UseSystemPasswordChar = _usePasswordChar;
        }
    }

    protected override void OnEnter(EventArgs e) {
        base.OnEnter(e);
        TryRemovePlaceholderText();
    }

    protected override void OnGotFocus(EventArgs e) {
        base.OnGotFocus(e);
        TryRemovePlaceholderText();
    }

    protected override void OnLeave(EventArgs e) {
        base.OnLeave(e);
        TrySetPlaceholderText();
    }

    protected override void OnLostFocus(EventArgs e) {
        base.OnLostFocus(e);
        TrySetPlaceholderText();
    }

    private void TrySetPlaceholderText() {
        if (_placeholderText.IsNullOrEmpty() || !Text.IsNullOrEmpty() || Focused) return;

        _isPlaceholderText = true;

        base.ForeColor = PlaceholderTextColor;
        base.Text = PlaceholderText;
        if (UsePasswordChar) UseSystemPasswordChar = false;
    }

    private void TryRemovePlaceholderText() {
        if (!_isPlaceholderText) return;

        base.Text = "";
        base.ForeColor = _foreColor;
        if (UsePasswordChar) UseSystemPasswordChar = true;

        _isPlaceholderText = false;
    }

    protected override void OnTextChanged(EventArgs e) {
        if (!_isPlaceholderText) base.OnTextChanged(e);
    }
}
