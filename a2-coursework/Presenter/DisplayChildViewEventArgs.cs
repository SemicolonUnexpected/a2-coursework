namespace a2_coursework.Presenter; 
public class DisplayChildViewEventArgs : EventArgs {

    public IChildView ChildView { get; init; }

    public ValidationRequestEventArgs(IChildView value) {
        ChildView = value;
    }
}
