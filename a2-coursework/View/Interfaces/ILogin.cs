using a2_coursework.Theming;

namespace a2_coursework.View.Interfaces;

public interface ILogin : IThemeable {
    public string Username { get; set; }
    public string Password { get; set; }
    public string ErrorText { get; set; }
    public string ButtonSignInText { get; set; }
    public bool ButtonSignInEnabled { get; set; }
    public bool TextBoxesEnabled { get; set; }
}
