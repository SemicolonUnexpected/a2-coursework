using System.ComponentModel;
using System.Windows.Forms.Design;
using System.Drawing.Drawing2D;

namespace AS_Coursework.Custom_Controls;
[Designer(typeof(ParentControlDesigner))]
public partial class CustomTextbox : UserControl {

    #region Fields

    // Border related fields
    private CustomTextboxBorderStyle _borderStyle = CustomTextboxBorderStyle.Underlined;
    private Color _borderColor = Color.White;
    private Color _borderFocusColor = Color.White;
    private int _borderSize = 2;

    // Placeholder related fields
    private Color _placeholderTextColor = Color.White;
    private string _placeholderText = "";
    private bool _isPlaceholderText = false;

    // Other fields
    private Keys[] _notAcceptedChars = Array.Empty<Keys>();

    private bool _usePasswordChar = false;

    #endregion

    public CustomTextbox() {
        InitializeComponent();

        tb.Enter += tb_Enter;
        tb.Leave += tb_Leave;
        tb.TextChanged += tb_TextChanged;
        tb.KeyDown += tb_KeyDown;
        tb.KeyPress += tb_KeyPress;

        TrySetPlaceholderText();
    }

    #region Properties


    [Category("_CustomTextbox Behaviour")]
    public bool UsePasswordChar {
        get => _usePasswordChar;
        set {
            _usePasswordChar = value;
            if (!_isPlaceholderText) tb.UseSystemPasswordChar = value;
        }
    }

    [Category("_CustomTextbox Behaviour")]
    public bool IsMultiline {
        get => tb.Multiline;
        set => tb.Multiline = value;
    }

    [Category("_CustomTextbox Appearance")]
    public override Color BackColor {
        get => base.BackColor;
        set {
            base.BackColor = value;
            tb.BackColor = value;
        }
    }

    [Category("_CustomTextbox Text")]
    public override Color ForeColor {
        get => base.ForeColor;
        set {
            base.ForeColor = value;
            tb.ForeColor = value;
        }
    }

    [Category("_CustomTextbox Text")]
    public override Font Font {
        get => base.Font;
        set {
            base.Font = value;
            tb.Font = value;
            UpdateControlHeight();
        }
    }

    [Category("_CustomTextbox Behaviour")]
    public bool ShortcutEnabled {
        get => tb.ShortcutsEnabled;
        set => tb.ShortcutsEnabled = value;
    }

    [Category("_CustomTextbox Text")]
    new public string Text {
        get => _isPlaceholderText ? "" : tb.Text;
        set {
            TryRemovePlaceholderText();
            tb.Text = value;
            TrySetPlaceholderText();
        }
    }

    [Category("_CustomTextbox Border")]
    public CustomTextboxBorderStyle CustomBorderStyle {
        get => _borderStyle;
        set {
            _borderStyle = value;
            Invalidate();
        }
    }

    [Category("_CustomTextbox Border")]
    public Color BorderColor {
        get => _borderColor;
        set {
            _borderColor = value;
            Invalidate();
        }
    }

    [Category("_CustomTextbox Border")]
    public Color BorderFocusColor {
        get => _borderFocusColor;
        set {
            _borderFocusColor = value;
            Invalidate();
        }
    }

    [Category("_CustomTextbox Border")]
    public int BorderSize {
        get => _borderSize;
        set {
            _borderSize = value;
            Invalidate();
        }
    }

    [Category("_CustomTextbox Text")]
    public string PlaceholderText {
        get => _placeholderText;
        set {
            TryRemovePlaceholderText();
            _placeholderText = value;
            TrySetPlaceholderText();
        }
    }

    [Category("_CustomTextbox Text")]
    public Color PlaceholderTextColor {
        get => _placeholderTextColor;
        set {
            _placeholderTextColor = value;
            if (_isPlaceholderText) tb.ForeColor = value;
        }
    }

    [Category("_CustomTextbox Appearance")]
    public int InternalTextboxHeight {
        get => tb.Height;
    }

    [Category("_CustomTextbox Text")]
    public Keys[] NotAcceptedKeys {
        get => _notAcceptedChars;
        set => _notAcceptedChars = value;
    }

    #endregion

    #region Custom events

    // Event handlers
    [Browsable(true), Category("Textbox")]
    new public event EventHandler? TextChanged;

    [Browsable(true), Category("Textbox")]
    new public event EventHandler? Enter;

    [Browsable(true), Category("Textbox")]
    new public event EventHandler? Leave;

    [Browsable(true), Category("Textbox")]
    new public event EventHandler<KeyPressEventArgs>? KeyPress;

    [Browsable(true), Category("Textbox")]
    new public event EventHandler<KeyEventArgs>? KeyDown;

    // Event methods
    private void tb_Enter(object? sender, EventArgs e) {
        TryRemovePlaceholderText();
        Enter?.Invoke(sender, e);
    }
    private void tb_Leave(object? sender, EventArgs e) {
        TrySetPlaceholderText();
        Leave?.Invoke(sender, e);
    }

    private void tb_TextChanged(object? sender, EventArgs e) {
        foreach (char notAccepted in _notAcceptedChars) {
            tb.Text.Replace(notAccepted.ToString(), "");
        }
        TextChanged?.Invoke(sender, e);
    }

    private void tb_KeyPress(object? sender, KeyPressEventArgs e) {
        KeyPress?.Invoke(sender, e);
    }

    private void tb_KeyDown(object? sender, KeyEventArgs e) {
        if (NotAcceptedKeys.Contains(e.KeyData)) {
            e.SuppressKeyPress = true;
        }
        KeyDown?.Invoke(sender, e);
    }

    #endregion

    #region Overriden methods

    protected override void OnPaint(PaintEventArgs e) {
        base.OnPaint(e);

        if (_borderStyle == CustomTextboxBorderStyle.None) return;

        using Pen pen = new(_borderColor, _borderSize);

        Graphics graphics = e.Graphics;
        pen.Alignment = PenAlignment.Inset;

        // Draw the correct graphic for the slected border
        if (_borderStyle == CustomTextboxBorderStyle.Rectangle) {
            graphics.DrawRectangle(pen, 0, 0, Width - 0.5f, Height - 0.5f);
        }
        else if (_borderStyle == CustomTextboxBorderStyle.Underlined) {
            graphics.DrawLine(pen, 0, Height - 0.5f, Width - 0.5f, Height - 0.5f);
        }
    }


    protected override void OnResize(EventArgs e) {
        base.OnResize(e);
        UpdateControlHeight();
    }

    protected override void OnLoad(EventArgs e) {
        base.OnLoad(e);
        UpdateControlHeight();
    }

    protected override void OnPaddingChanged(EventArgs e) {
        base.OnPaddingChanged(e);
        UpdateControlHeight();
    }

    protected override void OnBackColorChanged(EventArgs e) {
        base.OnBackColorChanged(e);
        tb.BackColor = BackColor;
    }

    #endregion

    #region Private methods

    private void UpdateControlHeight() {
        if (tb.Multiline == false) {
            int textHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
            tb.Multiline = true;
            tb.MinimumSize = new Size(0, textHeight);
            tb.Multiline = false;

            Height = tb.Height + Padding.Top + Padding.Bottom;
        }
    }

    private void TrySetPlaceholderText() {
        if (string.IsNullOrEmpty(tb.Text) && PlaceholderText != "") {
            _isPlaceholderText = true;
            tb.Text = PlaceholderText;
            tb.ForeColor = PlaceholderTextColor;
            if (UsePasswordChar) tb.UseSystemPasswordChar = false;
        }
    }

    private void TryRemovePlaceholderText() {
        if (_isPlaceholderText && PlaceholderText != "") {
            _isPlaceholderText = false;
            tb.Text = "";
            tb.ForeColor = ForeColor;
            if (UsePasswordChar) tb.UseSystemPasswordChar = true;
        }
    }

    #endregion

    #region Enums

    [Flags]
    public enum CustomTextboxBorderStyle {
        None,
        Rectangle,
        Underlined
    }

    #endregion
}
