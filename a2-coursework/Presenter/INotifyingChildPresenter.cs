namespace a2_coursework.Presenter; 
public interface INotifyingChildPresenter : IChildPresenter {
    public event EventHandler? DetailsChanged;
}
