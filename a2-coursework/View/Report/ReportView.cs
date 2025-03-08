using a2_coursework.CustomControls;
using a2_coursework.Interfaces.Report;
using a2_coursework.Theming;
using PdfiumViewer;

namespace a2_coursework.View;
public partial class ReportView : Form, IThemeable, IReportView {
    public event EventHandler? Download;
    public event EventHandler? Back;

    public ReportView() {
        InitializeComponent();

        pdfViewer.MouseWheel += pdfViewer_MouseWheel;
        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        btnDownload.Click += (s, e) => Download?.Invoke(this, EventArgs.Empty);
        btnBack.Click += (s, e) => Back?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        btnDownload.Theme();
        btnDownload.Image = IconTheme.Current.Download;

        btnDownload.Theme();
        btnBack.Image = IconTheme.Current.BackArrow;
    }

    public void SetFont() { }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        toolTip.Active = showToolTips;
    }

    private byte[]? _pdf;
    public byte[]? Pdf {
        get => _pdf;
        set {
            _pdf = value;
            if (_pdf != null) {
                var stream = new MemoryStream(_pdf);
                var document = PdfDocument.Load(stream);
                pdfRenderer1.Load(document);
            }
        }
    }

    private string _reportName = "";
    public string ReportName {
        get => _reportName;
        set => _reportName = value;
    }

    public bool BackVisible {
        set => btnBack.Visible = value;
    }

    public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK) => CustomMessageBox.Show(text, caption, buttons);

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.FontNameChanged -= SetFont;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
    }

    public bool GetFileName(out string name) {
        saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
        saveFileDialog.Title = "Save PDF File";
        saveFileDialog.FileName = $"{ReportName}.pdf";

        if (saveFileDialog.ShowDialog() == DialogResult.OK) {
            name = saveFileDialog.FileName;
            return true;
        }
        else {
            name = "";
            return false;
        }
    }

    private void pdfViewer_MouseWheel(object? sender, MouseEventArgs e) {
        if (pdfViewer.Document == null) return;

        if ((ModifierKeys & Keys.Control) == Keys.Control) {
            float zoomFactor = 1.1f;
            float newZoom = pdfViewer.Zoom;

            if (e.Delta > 0) {
                newZoom *= zoomFactor;
            }
            else if (e.Delta < 0) {
                newZoom /= zoomFactor;
            }

            newZoom = Math.Max(0.1f, Math.Min(5.0f, newZoom));

            pdfViewer.Zoom = newZoom;
        }
    }
}
