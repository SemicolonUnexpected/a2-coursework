namespace a2_coursework.Interfaces.SignIn;
public interface IDashboardView : IChildView {
    public event EventHandler? ChangePasswordClicked;

    public string Welcome { get; set; }
    public DateTime? LastPasswordChange { get; set; }
    public bool ShowChangePassword { get; set; }
}