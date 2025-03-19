using a2_coursework.Interfaces.Order;

namespace a2_coursework.Presenter.Order;

public class SubmitOrderPresenter : BasePresenter<ISubmitOrderView>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public event EventHandler? Submit;
    public event EventHandler? Receive;

    public SubmitOrderPresenter(ISubmitOrderView view) : base(view) {
        _view.Submit += OnSubmit;
        _view.Receive += OnReceive;
        _view.DescriptionChanged += OnDescriptionChanged;
    }

    private void OnReceive(object? sender, EventArgs e) => Receive?.Invoke(this, EventArgs.Empty);

    private void OnSubmit(object? sender, EventArgs e) => Submit?.Invoke(this, EventArgs.Empty);

    private void OnDescriptionChanged(object? sender, EventArgs e) {
        SetCharacterCount();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    public string Description {
        get => _view.Description;
        set => _view.Description = value;
    }

    public bool ReadOnly {
        get => _view.ReadOnly;
        set => _view.ReadOnly = value;
    }

    public bool Receivable {
        get => _view.Receivable;
        set => _view.Receivable = value;
    }

    public bool ButtonVisible {
        get => _view.ButtonVisible;
        set => _view.ButtonVisible = value;
    }

    private void SetCharacterCount() => _view.SetCharacterCount(_view.Description.Length);
}
