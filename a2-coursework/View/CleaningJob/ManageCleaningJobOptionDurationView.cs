using a2_coursework._Helpers;
using a2_coursework.Interfaces.CleaningJob;
using a2_coursework.Theming;

namespace a2_coursework.View.Customer;
public partial class ManageCleaningJobOptionDurationView : Form, IManageCleaningJobDuration, IThemeable {
    public event EventHandler? DateChanged;
    public event EventHandler? StartTimeChanged;
    public event EventHandler? EndTimeChanged;

    public ManageCleaningJobOptionDurationView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblDate.ThemeTitle();
        dateInput.Theme();
        lblDateError.ThemeError();

        pnlTime.Theme();
        lblStartTime.ThemeTitle();
        tiStartTime.Theme();
        lblEndTime.ThemeTitle();
        lblTimeError.ThemeError();
    }

    public void SetToolTipVisibility() {
        bool showToolTips = Theming.Theme.Current.ShowToolTips;

        dateInput.ToolTipsActive = showToolTips;
    }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblDate.SetFontName(fontName);
        dateInput.SetFontName(fontName);
        lblDateError.SetFontName(fontName);

        lblStartTime.SetFontName(fontName);
        tiStartTime.SetFontName(fontName);
        lblEndTime.SetFontName(fontName);
        lblTimeError.SetFontName(fontName);
    }

    public TimeOnly StartTime {
        get => tiStartTime.Time;
        set => tiEndTime.Time = value;
    }

    public bool StartTimeValid => tiStartTime.TimeValid;

    public TimeOnly EndTime {
        get => tiEndTime.Time;
        set => tiEndTime.Time = value;
    }

    public bool EndTimeValid => tiStartTime.TimeValid;

    public DateTime? Date {
        get => dateInput.Date;
        set => dateInput.Date = value;
    }

    public bool DateValid => dateInput.DateValid;

    public string DateError {
        get => lblDateError.Text;
        set => lblDateError.Text = value;
    }

    public string TimeError {
        get => lblTimeError.Text;
        set => lblTimeError.Text = value;
    }

    private bool _readOnly;
    public bool ReadOnly {
        get => _readOnly;
        set {
            _readOnly = value;

            dateInput.ReadOnly = _readOnly;
            tiStartTime.ReadOnly = _readOnly;
            tiEndTime.ReadOnly = _readOnly;
        }
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
