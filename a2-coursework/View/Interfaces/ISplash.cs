namespace a2_coursework.View.Interfaces; 
internal interface ISplash {
    Task StartLoading(int duration);
    void Show();
    void Close();
}
