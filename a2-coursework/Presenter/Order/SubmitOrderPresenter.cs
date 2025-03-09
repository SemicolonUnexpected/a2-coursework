using a2_coursework.View.Order;

namespace a2_coursework.Presenter.Order;

public class SubmitOrderPresenter : BasePresenter<ISubmitOrderView>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public event EventHandler? Submit;

    public SubmitOrderPresenter(ISubmitOrderView view) : base(view) {
        _view.Submit += OnSubmit;
        _view.DescriptionChanged += OnDescriptionChanged;
    }

    private void OnSubmit(object? sender, EventArgs e) => Submit?.Invoke(this, EventArgs.Empty);
    private void OnDescriptionChanged(object? sender, EventArgs e) => DetailsChanged?.Invoke(this, EventArgs.Empty);

    public string Description {
        get => _view.Description;
        set => _view.Description = value;
    }
}
