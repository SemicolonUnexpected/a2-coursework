using a2_coursework.View.Interfaces.Stock;

namespace a2_coursework.Presenter.Stock;
public class ManageStockDetailsPresenter : BasePresenter<IManageStockDetailsView>, IChildPresenter {
    private bool _nameValid;
    private bool _skuValid;

    public event EventHandler<CanExitEventArgs>? ValidateCanExit;
    public event EventHandler<ValidationRequestEventArgs<string>>? ValidateSKU;
    public event EventHandler? DetailsChanged;

    public ManageStockDetailsPresenter(IManageStockDetailsView view) : base(view) {
        _view.DescriptionChanged += OnDescriptionChanged;
        _view.SKUChanged += OnNameChanged;
        _view.NameChanged += OnSKUChanged;
    }

    private void OnDescriptionChanged(object? sender, EventArgs e) => DescriptionChanged();
    private void OnNameChanged(object? sender, EventArgs e) => Validate();
    private void OnSKUChanged(object? sender, EventArgs e) => Validate();

    public bool TryGetName(out string? name) {
        if (_nameValid) name = _view.StockName;
        else name = null;

        return _nameValid;
    }

    public void SetName(string name) => _view.StockName = name;

    public bool TryGetSKU(out string? sku) {
        if (_skuValid) sku = _view.SKU;
        else sku = null;

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
        _skuValid = validationRequestEventArgs.Valid ?? await validationRequestEventArgs.ValidationTask!;

        _view.SetNameBorderError(!_nameValid);
        _view.SetSKUBorderError(!_skuValid);

        if (!_skuValid && !_nameValid) _view.NameSKUError = $"Fill in a name. {validationRequestEventArgs.ErrorMessage}";
        else if (!_skuValid) _view.NameSKUError = validationRequestEventArgs.ErrorMessage;
        else if (!_nameValid) _view.NameSKUError = "Fill in a name";
    }

    public bool CanExit() {
        _skuValid && _nameValid;
    }

    public override void CleanUp() {
        _view.DescriptionChanged -= OnDescriptionChanged;
        _view.SKUChanged -= OnNameChanged;
        _view.NameChanged -= OnSKUChanged;
    }
}
