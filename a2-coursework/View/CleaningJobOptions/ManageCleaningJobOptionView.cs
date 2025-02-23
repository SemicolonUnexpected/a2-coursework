using a2_coursework._Helpers;
using a2_coursework.Interfaces.CleaningJobOption;
using a2_coursework.Theming;

namespace a2_coursework.View;
public partial class ManageCleaningJobOptionView : Form, IManageCleaningJobOptionView, IThemeable {
    public event EventHandler? NameChanged;
    public event EventHandler? DescriptionChanged;
    public event EventHandler? UnitCostChanged;

    public ManageCleaningJobOptionView() {
        InitializeComponent();

        tbName.TextChanged += (s, e) => NameChanged?.Invoke(this, EventArgs.Empty);
        tbDescription.TextChanged += (s, e) => DescriptionChanged?.Invoke(this, EventArgs.Empty);
        nudUnitCost.ValueChanged += (s, e) => UnitCostChanged?.Invoke(this, EventArgs.Empty);

        Theme();
        Theming.Theme.AppearanceThemeChanged += Theme;

        SetToolTipVisibility();
        Theming.Theme.ShowToolTipsChanged += SetToolTipVisibility;

        SetFont();
        Theming.Theme.FontNameChanged += SetFont;
    }

    public void Theme() {
        BackColor = ColorScheme.Current.Background;

        lblName.ThemeTitle();
        tbName.Theme();
        lblNameError.ThemeError();
        lblDescription.ThemeTitle();
        tbDescription.Theme();
        lblCharacterLimit.ThemeSubtitle();
        pnlUnitCost.Theme();
        lblUnitCost.ThemeTitle();
    }

    public void SetToolTipVisibility() { }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblName.SetFontName(fontName);
        tbName.SetFontName(fontName);
        lblNameError.SetFontName(fontName);
        lblDescription.SetFontName(fontName);
        tbDescription.SetFontName(fontName);
        lblCharacterLimit.SetFontName(fontName);
        pnlUnitCost.SetFontName(fontName);
        lblUnitCost.SetFontName(fontName);
    }

    public string Name {
        get => tbName.Text;
        set => tbName.Text = value;
    }

    public string Description {
        get => tbDescription.Text;
        set => tbDescription.Text = value;
    }

    public decimal UnitCost {
        get => nudUnitCost.Value;
        set => nudUnitCost.Value = value;
    }

    public string NameError {
        get => lblNameError.Text;
        set => lblNameError.Text = value;
    }

    private bool _nameError = false;
    public void SetNameBorderError(bool isError) {
        _nameError = isError;

        tbName.BorderColor = _nameError ? ColorScheme.Current.Danger : ColorScheme.Current.Primary;
    }

    public void SetCharacterCount(int number) => lblCharacterLimit.Text = $"{number}/{lblCharacterLimit.MaximumSize}";
    
    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
