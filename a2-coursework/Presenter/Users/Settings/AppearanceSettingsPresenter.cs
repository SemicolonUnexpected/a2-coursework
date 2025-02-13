using a2_coursework.Model;
using a2_coursework.View.Interfaces.Users.Settings;

namespace a2_coursework.Presenter.Users.Settings;
public class AppearanceSettingsPresenter : SettingsPresenter<IAppearanceSettings> {
    public AppearanceSettingsPresenter(IAppearanceSettings view, Staff staff) : base(view, staff) {
        _view.DarkModeCheckedChanged += OnAppearanceSettingChanged;
        _view.ToolTipsCheckedChanged += OnAppearanceSettingChanged;
        _view.FontNameChanged += OnAppearanceSettingChanged;
    }

    private void OnAppearanceSettingChanged(object? sender, EventArgs e) => SetApproveChangesBarVisibility();

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

    protected override Task<bool> UpdateDatabase() => StaffDAL.UpdateAppearanceSettings(_staff.Id, new Theming.Theme(_view.DarkModeChecked ? Theming.AppearanceTheme.Dark : Theming.AppearanceTheme.Light, _view.ToolTipsChecked, _view.FontName));

    public override void CleanUp() {
        _view.DarkModeCheckedChanged -= OnAppearanceSettingChanged;
        _view.ToolTipsCheckedChanged -= OnAppearanceSettingChanged;
        _view.FontNameChanged -= OnAppearanceSettingChanged;

        base.CleanUp();
    }
}
