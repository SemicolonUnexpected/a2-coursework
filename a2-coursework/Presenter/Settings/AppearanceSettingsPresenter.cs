using a2_coursework.Model;
using a2_coursework.View.Interfaces.Settings;

namespace a2_coursework.Presenter.Settings;
public class AppearanceSettingsPresenter
{
    private readonly Staff _staff;
    private readonly IAppearanceSettings _view;

    public AppearanceSettingsPresenter(IAppearanceSettings view, Staff staff)
    {
        _view = view;
        _staff = staff;

        _view.DarkModeCheckedChanged += (s, e) => SetApproveChangesBarVisibility();
        _view.ToolTipsCheckedChanged += (s, e) => SetApproveChangesBarVisibility();
        _view.FontNameChanged += (s, e) => SetApproveChangesBarVisibility();
        _view.Save += (s, e) => Save();
        _view.Cancel += (s, e) => Cancel();

        PopulateDefaultValues();
    }

    private void SetApproveChangesBarVisibility()
    {
        if (AnyChanges()) _view.SaveVisible = true;
        else _view.SaveVisible = false;
    }

    public bool AnyChanges() => _view.DarkModeChecked != _staff.Theme.IsDarkMode() || _view.ToolTipsChecked != _staff.Theme.ShowToolTips || _view.FontName != _staff.Theme.FontName;

    private void PopulateDefaultValues()
    {
        _view.DarkModeChecked = _staff.Theme.IsDarkMode();
        _view.ToolTipsChecked = _staff.Theme.ShowToolTips;
        _view.FontName = _staff.Theme.FontName;
    }

    private void UpdateStaff()
    {
        _staff.Theme.AppearanceTheme = _view.DarkModeChecked ? Theming.AppearanceTheme.Dark : Theming.AppearanceTheme.Light;
        _staff.Theme.ShowToolTips = _view.ToolTipsChecked;
        _staff.Theme.FontName = _view.FontName;
    }

    private async void Save()
    {
        try
        {
            _view.IsLoading = true;

            bool success = await StaffDAL.UpdateAppearanceSettings(_staff.StaffID, new Theming.Theme(_view.DarkModeChecked ? Theming.AppearanceTheme.Dark : Theming.AppearanceTheme.Light, _view.ToolTipsChecked, _view.FontName));

            _view.IsLoading = false;
            if (success)
            {
                UpdateStaff();
                _view.ShowMessageBox("Your appearance settings has been successfully updated.", "Saved");
            }
            else _view.ShowMessageBox("Could not update your appearance settings.", "Save failed");
        }
        catch
        {
            _view.IsLoading = false;
            _view.ShowMessageBox("Could not update your appearance settings.", "Save failed");
        }
        finally
        {
            SetApproveChangesBarVisibility();
        }
    }

    private void Cancel()
    {
        PopulateDefaultValues();
        SetApproveChangesBarVisibility();
    }
}
