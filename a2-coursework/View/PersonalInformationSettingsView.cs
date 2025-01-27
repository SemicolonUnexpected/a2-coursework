using a2_coursework.Presenter;
using a2_coursework.Theming;
using a2_coursework.View.Interfaces;

namespace a2_coursework.View;
public partial class PersonalInformationSettingsView : Form, IPersonalInformationSettings, IChildView {
    private PersonalInformationSettingsPresenter? _presenter;

    private bool _forenameError = false;
    private bool _surnameError = false;

    public PersonalInformationSettingsView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += (s, e) => Theme();
    }

    public void SetPresenter(PersonalInformationSettingsPresenter presenter) {
        _presenter = presenter;
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        tbForename.Theme();
        SetForenameBorderError(_forenameError);

        tbSurname.Theme();
        SetForenameBorderError(_surnameError);

        diDateOfBirth.Theme();

        lblPersonalInfo.ThemeTitle();
    }

    public void tbForename_TextChanged(object sender, EventArgs e) {
        _presenter?.NameInputError();
    }

    public void tbSurname_TextChanged(object sender, EventArgs e) {
        _presenter?.NameInputError();
    }

    public void diDateOfBirth_DateChanged(object sender, EventArgs e) {
        _presenter?.DateOfBirthInputError();
    }

    public void approveChangesBar_Save(object sender, EventArgs e) {
        _presenter?.TrySaveChanges();
    }

    private void approveChangesBar_Cancel(object sender, EventArgs e) {
        _presenter?.Cancel();
    }

    public bool ApproveChangesBarVisible {
        set => approveChangesBar.Visible = value;
    }

    public string ForenameInput {
        get => tbForename.Text;
        set => tbForename.Text = value;
    }

    public string SurnameInput {
        get => tbSurname.Text;
        set => tbSurname.Text = value;
    }

    public DateTime? DateOfBirthInput {
        get => diDateOfBirth.Date;
        set => diDateOfBirth.Date = value;
    }

    public string NameErrorText {
        set => lblNameError.Text = value;
    }

    public string DateOfBirthErrorText {
        set => lblDateOfBirthErrorText.Text = value;
    }

    public string DayInput => diDateOfBirth.DayText;
    public string MonthInput => diDateOfBirth.MonthText;
    public string YearInput => diDateOfBirth.YearText;

    public void SetForenameBorderError(bool isError) {
        _forenameError = isError;
        tbForename.BorderColor = _forenameError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
    }

    public void SetSurnameBorderError(bool isError) {
        _surnameError = isError;
        tbSurname.BorderColor = _surnameError ? ColorScheme.CurrentTheme.Danger : ColorScheme.CurrentTheme.Primary;
    }

    public bool CanExit() {
        throw new NotImplementedException();
    }
}
