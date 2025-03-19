using a2_coursework.Interfaces.Order;

namespace a2_coursework.Presenter.Order;

public class ManageOrderDiscrepanciesPresenter : BasePresenter<IOrderDiscrepanciesView>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public ManageOrderDiscrepanciesPresenter(IOrderDiscrepanciesView view) : base(view) {
        _view.DescriptionChanged += OnDescriptionChanged;
    }

    private void OnDescriptionChanged(object? sender, EventArgs e) {
        SetCharacterCount();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }

    public string Discrepancies {
        get => _view.Description;
        set => _view.Description = value;
    }

    public bool ReadOnly {
        get => _view.ReadOnly;
        set => _view.ReadOnly = value;
    }

    private void SetCharacterCount() => _view.SetCharacterCount(_view.Description.Length);
}
