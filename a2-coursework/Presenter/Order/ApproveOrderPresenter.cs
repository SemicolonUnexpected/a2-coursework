using a2_coursework.Interfaces.Order;

namespace a2_coursework.Presenter.Order;

public class ApproveOrderPresenter : BasePresenter<IApproveOrderView>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public event EventHandler? Approve;

    public ApproveOrderPresenter(IApproveOrderView view) : base(view) {
        _view.Approve += OnApprove;
        _view.DescriptionChanged += OnDescriptionChanged;
    }

    private void OnApprove(object? sender, EventArgs e) => Approve?.Invoke(this, EventArgs.Empty);
    private void OnDescriptionChanged(object? sender, EventArgs e) => DetailsChanged?.Invoke(this, EventArgs.Empty);

    public string Description {
        get => _view.Description;
        set => _view.Description = value;
    }
}
