using a2_coursework.Interfaces;

namespace a2_coursework.Presenter;
public class NavigationEventArgs(IChildView view, IChildPresenter presenter) : EventArgs {
    public IChildView View { get; init; } = view;
    public IChildPresenter Presenter { get; init; } = presenter;
    public bool NavigateMenu { get; set; } = false;
    public string MenuItemName { get; set; } = string.Empty;
}
