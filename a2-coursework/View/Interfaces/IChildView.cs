namespace a2_coursework.View.Interfaces; 
public interface IChildView {
    #region Winforms Properties
    public event MouseEventHandler? MouseWheel;
    public void Dispose();
    public bool TopLevel { set; }
    public int Width { set; }
    public int Height { get; }
    public Point Location { get; set; }
    public AnchorStyles Anchor { set; }
    public void Show();
    public DockStyle Dock { get; set; }
    #endregion

    public bool CanExit();
    public bool DockInParent { get; }
}