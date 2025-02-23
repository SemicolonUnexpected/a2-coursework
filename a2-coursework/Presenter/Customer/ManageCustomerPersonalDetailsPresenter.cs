using a2_coursework.Interfaces.Customer;

namespace a2_coursework.Presenter.Customer; 
public class ManageCustomerPersonalDetailsPresenter : BasePresenter<IManageCustomerPersonalDetailsView>, INotifyingChildPresenter, IChildPresenter {
    public event EventHandler? DetailsChanged;

    public ManageCustomerPersonalDetailsPresenter(IManageCustomerPersonalDetailsView view) : base(view) {
        _view.ForenameChanged += OnForenameChanged;
        _view.SurnameChanged += OnSurnameChanged;
        _view.ArchivedChanged += OnArchivedChanged;
    }

    private void OnSurnameChanged(object? sender, EventArgs e) {
        ValidateNames();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }
    private void OnForenameChanged(object? sender, EventArgs e) {
        ValidateNames();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }
    private void OnArchivedChanged(object? sender, EventArgs e) => DetailsChanged?.Invoke(this, EventArgs.Empty);

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
            (false, false) => "Fill in a valid forname and surname",
        };
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

    public bool Archived {
        get => _view.Archived;
        set => _view.Archived = value;
    }

    public bool CanExit() => true;

    public override void CleanUp() {
        _view.ForenameChanged -= OnForenameChanged;
        _view.SurnameChanged -= OnSurnameChanged;
        _view.ArchivedChanged -= OnArchivedChanged;

        base.CleanUp();
    }
}
