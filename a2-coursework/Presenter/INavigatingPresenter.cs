namespace a2_coursework.Presenter; 
public interface INavigatingPresenter {
    public event EventHandler<NavigationEventArgs>? NavigationRequest;
}
