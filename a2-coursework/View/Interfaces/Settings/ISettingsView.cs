using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces; 
public interface ISettingsView : IChildView, IThemeable {
    public event EventHandler? Save;
    public event EventHandler? Cancel;

    public bool SaveVisible { set; }
    public bool IsLoading { set; }

    public void ShowMessageBox(string text, string caption);
}
