using a2_coursework.Interfaces.CleaningJob;

namespace a2_coursework.Presenter.CleaningJob;

public class ManageCleaningJobDetailsPresenter : BasePresenter<IManageCleaningJobOptionDetails>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public ManageCleaningJobDetailsPresenter(IManageCleaningJobOptionDetails view) : base(view) {
        _view.AddressChanged += OnAddressChanged;
        _view.ExtraInformationChanged += OnExtraInformationChanged;
    }

    private void OnExtraInformationChanged(object? sender, EventArgs e) {
        SetExtraInformationCharacterCount();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    private void OnAddressChanged(object? sender, EventArgs e) {
        SetAddressCharacterCount();
        ValidateAddress();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    public bool ReadOnly {
        get => _view.ReadOnly;
        set => _view.ReadOnly = value;
    }

    private bool _addressValid;
    public bool AddressValid {
        get {
            ValidateAddress();
            return _addressValid;
        }
    }

    public string Address {
        get => _view.Address;
        set => _view.Address = value;
    }

    public string ExtraInformation {
        get => _view.ExtraInformation;
        set => _view.ExtraInformation = value;
    }

    private void ValidateAddress() {
        _addressValid = !string.IsNullOrEmpty(_view.Address);
        _view.SetAddressBorderError(!_addressValid);
        _view.AddressError = _addressValid ? "" : "Address cannot be empty";
    }

    private void SetAddressCharacterCount() => _view.SetAddressCharacterCount(_view.Address.Length);
    private void SetExtraInformationCharacterCount() => _view.SetExtraInformationCharacterCount(_view.ExtraInformation.Length);

    public override void CleanUp() {
        _view.AddressChanged -= OnAddressChanged;
        _view.ExtraInformationChanged -= OnExtraInformationChanged;

        base.CleanUp();
    }
}
