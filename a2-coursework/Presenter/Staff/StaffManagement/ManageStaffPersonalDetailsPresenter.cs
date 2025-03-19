using a2_coursework.Interfaces.Staff.StaffManagement;

namespace a2_coursework.Presenter.Staff.StaffManagement;
public class ManageStaffPersonalDetailsPresenter : BasePresenter<IManageStaffPersonalInformationView>, IChildPresenter, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public ManageStaffPersonalDetailsPresenter(IManageStaffPersonalInformationView view) : base(view) {
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
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    private bool _forenameValid = true;
    private bool _surnameValid = true;
    private void ValidateNames() {
        _forenameValid = !string.IsNullOrWhiteSpace(_view.Forename);
        _view.SetForenameBorderError(!_forenameValid);

        _surnameValid = !string.IsNullOrWhiteSpace(_view.Surname);
        _view.SetSurnameBorderError(!_surnameValid);

        _view.NameError = (_forenameValid, _surnameValid) switch {
            (true, true) => "",
            (true, false) => "Fill in a valid forename",
            (false, true) => "Fill in a valid surname",
            (false, false) => "Fill in a valid forename and surname",
        };
    }

    private bool _dateOfBirthValid = true;
    private void ValidateDateOfBirth() {
        _dateOfBirthValid = _view.DateOfBirthValid;
        _view.DateOfBirthError = _dateOfBirthValid ? "" : "Invalid date of birth";
    }

    public string Forename {
        get => _view.Forename;
        set => _view.Forename = value;
    }

    public bool ForenameValid {
        get {
            ValidateNames();
            return _forenameValid;
        }
    }
    
    public string Surname {
        get => _view.Surname;
        set => _view.Surname = value;
    }

    public bool SurnameValid {
        get {
            ValidateNames();
            return _surnameValid;
        }
    }

    public DateTime? DateOfBirth {
        get => _view.DateOfBirth;
        set => _view.DateOfBirth = value;
    }

    public bool DateOfBirthValid {
        get {
            ValidateDateOfBirth();
            return _dateOfBirthValid; 
        }
    }

    public bool CanExit() => true;
}
