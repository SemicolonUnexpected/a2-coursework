namespace a2_coursework.Presenter;
public interface INotifyingChildPresenter : ICleanable {
    public event EventHandler? DetailsChanged;
}
