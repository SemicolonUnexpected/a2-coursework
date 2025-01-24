using a2_coursework.Theming;
using a2_coursework.View.Interfaces;

namespace a2_coursework.View;
public partial class PersonalInfromationSettingsView : Form, IThemable {
    public PersonalInfromationSettingsView() {
        InitializeComponent();
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        tbForename.Theme();
        tbSurname.Theme();

        diDateOfBirth.Theme();

        lblPersonalInfo.ThemeTitle();
    }

    private void sb_ValueChanged(object sender, EventArgs e) {
    }

    private void dateInput1_ErrorChanged(object sender, EventArgs e) {
        lblDateOfBirthErrorText.Text = diDateOfBirth.ErrorMessage;
    }
}
