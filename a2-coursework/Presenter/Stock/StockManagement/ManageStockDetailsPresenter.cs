using a2_coursework.Interfaces.Stock.StockManagement;

namespace a2_coursework.Presenter.Stock.StockManagement;
public class ManageStockDetailsPresenter : BasePresenter<IManageStockDetailsView>, INotifyingChildPresenter {
    private bool _nameValid;
    private bool _skuValid;

    public event EventHandler<ValidationRequestEventArgs<string>>? ValidateSKU;
    public event EventHandler? DetailsChanged;

    public ManageStockDetailsPresenter(IManageStockDetailsView view) : base(view) {
        _view.DescriptionChanged += OnDescriptionChanged;
        _view.SKUChanged += OnSKUChanged;
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

    public bool TryGetName(out string? name) {
        name = _nameValid ? _view.StockName : null;
        return _nameValid;
    }

    public void SetName(string name) => _view.StockName = name;

    public bool TryGetSKU(out string? sku) {
        sku = _skuValid ? _view.SKU : null;
        return _skuValid;
    }

    public void SetSKU(string SKU) => _view.SKU = SKU;

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

        ValidationRequestEventArgs<string> validationRequestEventArgs = new(_view.SKU);
        ValidateSKU?.Invoke(this, validationRequestEventArgs);
        if (validationRequestEventArgs.Valid is null && validationRequestEventArgs.ValidationTask is null) return;
        _skuValid = validationRequestEventArgs.Valid ?? await validationRequestEventArgs.ValidationTask!;

        _view.SetNameBorderError(!_nameValid);
        _view.SetSKUBorderError(!_skuValid);

        if (!_skuValid && !_nameValid) _view.NameSKUError = $"Fill in a name. {validationRequestEventArgs.ErrorMessage}";
        else if (!_skuValid) _view.NameSKUError = validationRequestEventArgs.ErrorMessage;
        else if (!_nameValid) _view.NameSKUError = "Fill in a name";
        else _view.NameSKUError = "";
    }

    public bool CanExit() => _skuValid && _nameValid;

    public override void CleanUp() {
        _view.DescriptionChanged -= OnDescriptionChanged;
        _view.SKUChanged -= OnNameChanged;
        _view.NameChanged -= OnSKUChanged;
        _view.ArchivedChanged -= OnArchivedChanged;
    }
}
