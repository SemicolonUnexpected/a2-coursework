using a2_coursework.Interfaces.Staff.StaffManagement;
using a2_coursework.Model.Staff;
using System.Linq;

namespace a2_coursework.Presenter.Staff.StaffManagement;
public class ManageStaffCredentialsPresenter : BasePresenter<IManageStaffCredentialsView>, IChildPresenter, INotifyingChildPresenter {
    public event EventHandler? DetailsChanged;

    public event EventHandler<ValidationRequestEventArgs<string>>? ValidateUsernameRequest;

    public ManageStaffCredentialsPresenter(IManageStaffCredentialsView view) : base(view) {
        _view.PrivilegeLevels = Array.ConvertAll((Enum.GetValues(typeof(PrivilegeLevel)) as PrivilegeLevel[])!, x => x.ConvertToString());

        _view.PrivilegeLevelChanged += OnPrivilegeLevelChanged;
        _view.UsernameChanged += OnUsernameChanged;
    }

    private void OnUsernameChanged(object? sender, EventArgs e) {
        ValidateUsername();
        DetailsChanged?.Invoke(this, EventArgs.Empty);
    }
    private void OnPrivilegeLevelChanged(object? sender, EventArgs e) => DetailsChanged?.Invoke(this, EventArgs.Empty);

    public string SetSuggestedUsername(string suggestedUsername) => _view.SuggestedUsername = suggestedUsername;

    public string Username {
        get => _view.Username;
        set => _view.Username = value;
    }

    public bool UsernameValid {
        get {
            ValidateUsername();
            return _usernameValid;
        }
    }

    public PrivilegeLevel PrivilegeLevel {
        get => _view.SelectedPrivilegeLevel.ConvertFromString();
        set => _view.SelectedPrivilegeLevel = value.ConvertToString();
    }

    private bool _usernameValid = true;
    private async void ValidateUsername() {
        ValidationRequestEventArgs<string> validationRequestEventArgs = new(_view.Username);
        ValidateUsernameRequest?.Invoke(this, validationRequestEventArgs);
        if (validationRequestEventArgs.Valid is null && validationRequestEventArgs.ValidationTask is null) return;
        _usernameValid = validationRequestEventArgs.Valid ?? await validationRequestEventArgs.ValidationTask!;

        _view.SetUsernameBorderError(!_usernameValid);

        if (!_usernameValid) _view.UsernameError = validationRequestEventArgs.ErrorMessage;
        else _view.UsernameError = "";
    }

    public bool CanExit() => true;

    public override void CleanUp() {
        _view.PrivilegeLevelChanged -= OnPrivilegeLevelChanged;
        _view.UsernameChanged -= OnUsernameChanged;

        base.CleanUp();
    }
}
