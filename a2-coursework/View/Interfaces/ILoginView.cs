namespace a2_coursework.View.Interfaces; 
internal interface ILoginView {
    public event FormClosedEventHandler? FormClosed;
    public void Show();
}