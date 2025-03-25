using a2_coursework._Helpers;
using a2_coursework.Interfaces.CleaningJob;
using a2_coursework.Theming;

namespace a2_coursework.View.Order;
public partial class ViewCleaningJobCustomerView : Form, IViewCleaningJobCustomerView, IThemeable {
    public event EventHandler? EmailChanged;
    public event EventHandler? PhoneNumberChanged;
    public event EventHandler? AddressChanged;

    public ViewCleaningJobCustomerView () {
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

        lblName.ThemeTitle();
        tbName.Theme();
        lblEmail.ThemeTitle();
        tbEmail.Theme();
        lblPhoneNumber.ThemeTitle();
        tbPhoneNumber.Theme();
    }

    public void SetToolTipVisibility() { }

    public void SetFont() {
        string fontName = Theming.Theme.Current.FontName;

        lblName.SetFontName(fontName);
        tbName.SetFontName(fontName);
        lblEmail.SetFontName(fontName);
        tbEmail.SetFontName(fontName);
        lblPhoneNumber.SetFontName(fontName);
        tbPhoneNumber.SetFontName(fontName);
    }

    public string CustomerEmail {
        get => tbEmail.Text;
        set => tbEmail.Text = value;
    }

    public string CustomerPhoneNumber {
        get => tbPhoneNumber.Text;
        set => tbPhoneNumber.Text = value;
    }

    public string CustomerName {
        get => tbName.Text;
        set => tbName.Text = value;
    }

    public void CleanUp() {
        Theming.Theme.AppearanceThemeChanged -= Theme;
        Theming.Theme.ShowToolTipsChanged -= SetToolTipVisibility;
        Theming.Theme.FontNameChanged -= SetFont;
    }
}
