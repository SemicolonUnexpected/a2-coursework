using a2_coursework.Model;
using a2_coursework.View.Interfaces.Settings;

namespace a2_coursework.Presenter.Settings; 
public abstract class SettingsPresenter<TView> where TView : ISettingsView {
    protected readonly TView _view;
    protected readonly Staff _staff;

    public SettingsPresenter(TView view, Staff staff) {
        _view = view;
        _staff = staff;

        PopulateDefaultValues();

        _view.Save += (s, e) => Save();
        _view.Cancel += (s, e) => Cancel();
    }

    protected abstract void PopulateDefaultValues();
    protected abstract void UpdateStaff();
}
