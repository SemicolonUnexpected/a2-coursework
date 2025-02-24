using a2_coursework.Interfaces.CleaningJobOption;

namespace a2_coursework.Presenter.CleaningJobOption;
public class ManageJobCleaningOptionPresenter : BasePresenter<IManageCleaningJobOptionView>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public event EventHandler<ValidationRequestEventArgs<string>>? ValidateNameRequest;

    public ManageJobCleaningOptionPresenter(IManageCleaningJobOptionView view) : base(view) {
        _view.NameChanged += OnNameChanged;
        _view.DescriptionChanged += OnDescriptionChanged;
        _view.UnitCostChanged += OnUnitCostChanged;
    }

    private void OnNameChanged(object? sender, EventArgs e) {
        ValidateName();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }
    private void OnDescriptionChanged(object? sender, EventArgs e) {
        SetCharacterCount();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }
    private void OnUnitCostChanged(object? sender, EventArgs e) => DetailsChanged?.Invoke(this, EventArgs.Empty);

    public string Name {
        get => _view.Name;
        set => _view.Name = value;
    }

    private bool _nameValid = true;
    public bool NameValid {
        get {
            ValidateName();
            return _nameValid;
        }
    }

    public string Description {
        get => _view.Description;
        set => _view.Description = value;
    }

    public decimal UnitCost {
        get => _view.UnitCost;
        set => _view.UnitCost = value;
    }

    private void SetCharacterCount() => _view.SetCharacterCount(_view.Description.Length);

    private async void ValidateName() {
        ValidationRequestEventArgs<string> validationRequestEventArgs = new(_view.Name);
        ValidateNameRequest?.Invoke(this, validationRequestEventArgs);
        if (validationRequestEventArgs.Valid is null && validationRequestEventArgs.ValidationTask is null) return;
        _nameValid = validationRequestEventArgs.Valid ?? await validationRequestEventArgs.ValidationTask!;

        _view.SetNameBorderError(!_nameValid);

        if (!_nameValid) _view.NameError = validationRequestEventArgs.ErrorMessage;
        else _view.NameError = "";
    }

    public bool CanExit() => true;
}
