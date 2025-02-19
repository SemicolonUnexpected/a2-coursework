using a2_coursework.Interfaces.Staff.StaffManagement;

namespace a2_coursework.Presenter.Staff.StaffManagement;
public class ManageStaffPersonalInformationPresenter : BasePresenter<IManageStaffPersonalInformationView>, IChildPresenter, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public ManageStaffPersonalInformationPresenter(IManageStaffPersonalInformationView view) : base(view) {
        _view.ForenameChanged += OnForenameChanged;
        _view.SurnameChanged += OnSurnameChanged;
        _view.DateOfBirthChanged += OnDateOfBirthChanged;
    }

    private void OnSurnameChanged(object? sender, EventArgs e) {
        ValidateNames();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }
    private void OnForenameChanged(object? sender, EventArgs e) {
        ValidateNames();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }
    private void OnDateOfBirthChanged(object? sender, EventArgs e) {
        ValidateDateOfBirth();
    }

    private bool _forenameValid = true;
    private bool _surnameValid = true;
    private void ValidateNames() {
        _forenameValid = string.IsNullOrWhiteSpace(_view.Forename);
        _view.SetForenameBorderError(_forenameValid);

        _surnameValid = string.IsNullOrWhiteSpace(_view.Surname);
        _view.SetSurnameBorderError(_surnameValid);

        _view.NameError = (_forenameValid, _surnameValid) switch {
            (true, true) => "",
            (true, false) => "Fill in a valid forename",
            (false, true) => "Fill in a valid surname",
            (false, false) => "Fill in a valid forname and surname",
        };
    }

    private bool _dateOfBirthValid = true;
    private void ValidateDateOfBirth() {
        _dateOfBirthValid = _view.DateOfBirthValid;
        _view.DateOfBirthError = _dateOfBirthValid ? "" : "Invalid date of birth";
    }

    public void SetForname(string forename) => _view.Forename = forename;

    public bool TryGetForename(out string? forename) {
        forename = _forenameValid ? _view.Forename : null;
        return _forenameValid;
    }

    public void SetSurname(string surname) => _view.Surname = surname;

    public bool TryGetSurname(out string? surname) {
        surname = _surnameValid ? _view.Surname : null;
        return _surnameValid;
    }

    public void SetDateOfBirth(DateTime dateOfBirth) => _view.DateOfBirth = dateOfBirth;

    public bool TryGetDateOfBirth(out DateTime? dateOfBirth) {
        dateOfBirth = _dateOfBirthValid ? _view.DateOfBirth : null;
        return _dateOfBirthValid;
    }

    public bool CanExit() => true;
}
