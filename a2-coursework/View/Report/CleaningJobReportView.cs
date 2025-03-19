using a2_coursework._Helpers;
using a2_coursework.Interfaces.Report;
using a2_coursework.Theming;

namespace a2_coursework.View.Reports;
public partial class CleaningJobReportView : Form, IThemeable, ICleaningJobReportView {
    public event EventHandler? GenerateReport;

    public CleaningJobReportView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.FontNameChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;

        btnGenerateReport.Click += (sender, e) => GenerateReport?.Invoke(this, EventArgs.Empty);
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        pnl.Theme();
        lblCleaningJobReports.ThemeTitle();
        lblError.ThemeError();
        btnGenerateReport.ThemeStrong();
        lblID.ThemeTitle();
        tbID.Theme();
    }

    public void SetToolTipVisibility() { }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        pnl.SetFontName(fontName);
        lblCleaningJobReports.SetFontName(fontName);
        lblError.SetFontName(fontName);
        btnGenerateReport.SetFontName(fontName);
        lblID.SetFontName(fontName);
        tbID.SetFontName(fontName);
    }

    public string Id {
        get => tbID.Text;
        set => tbID.Text = value;
    }

    public string ErrorMessage {
        get => lblError.Text;
        set => lblError.Text = value;
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.FontNameChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
