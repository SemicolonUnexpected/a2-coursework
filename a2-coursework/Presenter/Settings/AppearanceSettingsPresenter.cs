using a2_coursework.Model;
using a2_coursework.View.Interfaces.Users.Settings;

namespace a2_coursework.Presenter.Settings;
public class AppearanceSettingsPresenter : SettingsPresenter<IAppearanceSettings> {
    public AppearanceSettingsPresenter(IAppearanceSettings view, Staff staff) : base(view, staff) {
        _view.DarkModeCheckedChanged += (s, e) => SetApproveChangesBarVisibility();
        _view.ToolTipsCheckedChanged += (s, e) => SetApproveChangesBarVisibility();
        _view.FontNameChanged += (s, e) => SetApproveChangesBarVisibility();
    }

    protected override void PopulateDefaultValues() {
        _view.DarkModeChecked = _staff.Theme.IsDarkMode;
        _view.ToolTipsChecked = _staff.Theme.ShowToolTips;
        _view.FontName = _staff.Theme.FontName;
    }

    protected override void UpdateStaff() {
        _staff.Theme.AppearanceTheme = _view.DarkModeChecked ? Theming.AppearanceTheme.Dark : Theming.AppearanceTheme.Light;
        _staff.Theme.ShowToolTips = _view.ToolTipsChecked;
        _staff.Theme.FontName = _view.FontName;
    }

    protected override bool AnyChanges() => _view.DarkModeChecked != _staff.Theme.IsDarkMode || _view.ToolTipsChecked != _staff.Theme.ShowToolTips || _view.FontName != _staff.Theme.FontName;

    protected override Task<bool> UpdateDatabase() => StaffDAL.UpdateAppearanceSettings(_staff.StaffID, new Theming.Theme(_view.DarkModeChecked ? Theming.AppearanceTheme.Dark : Theming.AppearanceTheme.Light, _view.ToolTipsChecked, _view.FontName));
}
