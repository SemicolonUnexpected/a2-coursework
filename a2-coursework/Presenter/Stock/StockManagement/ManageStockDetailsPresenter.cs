using a2_coursework.Interfaces.Stock.StockManagement;

namespace a2_coursework.Presenter.Stock.StockManagement;
public class ManageStockDetailsPresenter : BasePresenter<IManageStockDetailsView>, INotifyingChildPresenter {
    private bool _nameValid;
    private bool _skuValid;

    public event EventHandler<ValidationRequestEventArgs<string>>? ValidateSkuRequest;
    public event EventHandler? DetailsChanged;

    public ManageStockDetailsPresenter(IManageStockDetailsView view) : base(view) {
        _view.DescriptionChanged += OnDescriptionChanged;
        _view.SkuChanged += OnSKUChanged;
        _view.NameChanged += OnNameChanged;
        _view.ArchivedChanged += OnArchivedChanged;
    }

    private void OnArchivedChanged(object? sender, EventArgs e) => DetailsChanged?.Invoke(this, EventArgs.Empty);
    private void OnDescriptionChanged(object? sender, EventArgs e) {
        DetailsChanged?.Invoke(this, EventArgs.Empty);
        DescriptionChanged();
    }
    private void OnNameChanged(object? sender, EventArgs e) {
        DetailsChanged?.Invoke(this, EventArgs.Empty);
        Validate();
    }
    private void OnSKUChanged(object? sender, EventArgs e) {
        DetailsChanged?.Invoke(this, EventArgs.Empty);
        Validate();
    }

    public bool NameValid {
        get {
            Validate();
            return _nameValid;
        }
    }

    public string Name {
        get => _view.StockName;
        set => _view.StockName = value;
    }

    public bool SkuValid {
        get {
            Validate();
            return _skuValid;
        }
    }

    public string Sku {
        get => _view.Sku;
        set => _view.Sku = value;
    }

    public string Description {
        get => _view.Description;
        set => _view.Description = value;
    }

    public bool Archived {
        get => _view.Archived;
        set => _view.Archived = value;
    }

    private void DescriptionChanged() => _view.SetCharacterCount(_view.Description.Length);

    private async void Validate() {
        _nameValid = _view.StockName != "";

        ValidationRequestEventArgs<string> validationRequestEventArgs = new(_view.Sku);
        ValidateSkuRequest?.Invoke(this, validationRequestEventArgs);
        if (validationRequestEventArgs.Valid is null && validationRequestEventArgs.ValidationTask is null) return;
        _skuValid = validationRequestEventArgs.Valid ?? await validationRequestEventArgs.ValidationTask!;

        _view.SetNameBorderError(!_nameValid);
        _view.SetSKUBorderError(!_skuValid);

        if (!_skuValid && !_nameValid) _view.NameSkuError = $"Fill in a name. {validationRequestEventArgs.ErrorMessage}";
        else if (!_skuValid) _view.NameSkuError = validationRequestEventArgs.ErrorMessage;
        else if (!_nameValid) _view.NameSkuError = "Fill in a name";
        else _view.NameSkuError = "";
    }

    public bool CanExit() => _skuValid && _nameValid;

    public override void CleanUp() {
        _view.DescriptionChanged -= OnDescriptionChanged;
        _view.SkuChanged -= OnNameChanged;
        _view.NameChanged -= OnSKUChanged;
        _view.ArchivedChanged -= OnArchivedChanged;
    }
}
