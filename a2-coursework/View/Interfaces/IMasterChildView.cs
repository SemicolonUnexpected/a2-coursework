namespace a2_coursework.View.Interfaces; 
public interface IMasterChildView : IChildView {
    public bool CanExit();
    public bool DockInParent { get; }
}