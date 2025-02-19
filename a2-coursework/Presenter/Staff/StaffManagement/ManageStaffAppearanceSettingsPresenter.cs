using a2_coursework.Interfaces.Staff.StaffManagement;

namespace a2_coursework.Presenter.Staff.ManageStaff;
public class ManageStaffAppearanceSettingsPresenter : BasePresenter<IManageStaffAppearanceSettingsView>, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public ManageStaffAppearanceSettingsPresenter(IManageStaffAppearanceSettingsView view) : base(view) {
        _view.DarkModeCheckedChanged += OnDarkModeCheckedChanged;
        _view.ToolTipsCheckedChanged += OnToolTipsCheckedChanged;
        _view.FontNameChanged += OnFontNameChanged;
    }

    private void OnDarkModeCheckedChanged(object? sender, EventArgs e) => DetailsChanged?.Invoke(this, EventArgs.Empty);
    private void OnToolTipsCheckedChanged(object? sender, EventArgs e) => DetailsChanged?.Invoke(this, EventArgs.Empty);
    private void OnFontNameChanged(object? sender, EventArgs e) => DetailsChanged?.Invoke(this, EventArgs.Empty);

    public bool DarkMode {
        get => _view.DarkModeChecked;
        set => _view.DarkModeChecked = value;
    }

    public bool ShowToolTips {
        get => _view.ShowToolTipsChecked;
        set => _view.ShowToolTipsChecked = value;
    }

    public string FontName {
        get => _view.FontName;
        set => _view.FontName = value;
    }

    public bool CanExit() => true;

    public override void CleanUp() {
        _view.DarkModeCheckedChanged -= OnDarkModeCheckedChanged;
        _view.ToolTipsCheckedChanged -= OnToolTipsCheckedChanged;
        _view.FontNameChanged -= OnFontNameChanged;

        base.CleanUp();
    }
}
