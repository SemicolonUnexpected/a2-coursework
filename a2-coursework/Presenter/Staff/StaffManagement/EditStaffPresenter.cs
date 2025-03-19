using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Staff.StaffManagement;
using a2_coursework.Model.Staff;

namespace a2_coursework.Presenter.Staff.StaffManagement;
public class EditStaffPresenter : ParentEditPresenter<IEditStaffView, StaffModel>, IChildPresenter, INavigatingPresenter {
    private readonly StaffModel _staff;

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public EditStaffPresenter(IEditStaffView view, StaffModel model, StaffModel staff) : base(view, model) {
        _staff = staff;

        _view.Back += OnBack;

        Navigate(GetCredentials());
    }

    private void OnBack(object? sender, EventArgs e) => NavigateBack();
    private void OnValidateUsername(object? sender, ValidationRequestEventArgs<string> e) => IsValidUsername(e);

    private void NavigateBack() {
        if (!CanExit()) return;
        (IChildView view, IChildPresenter presenter) = StaffFactory.CreateDisplayStaff(_staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void BindValidation() {
        if (_childPresenter is ManageStaffCredentialsPresenter manageStaffCredentialsPresenter) manageStaffCredentialsPresenter.ValidateUsernameRequest += OnValidateUsername;
    }

    protected override void UnBindValidation() {
        if (_childPresenter is ManageStaffCredentialsPresenter manageStaffCredentialsPresenter) manageStaffCredentialsPresenter.ValidateUsernameRequest -= OnValidateUsername;
    }

    protected override (IChildView childView, INotifyingChildPresenter childPresenter) GetView(string selectedItem) => selectedItem switch {
        "Credentials" => GetCredentials(),
        "Details" => GetPersonalInformation(),
        "Contact" => GetContactDetails(),
        "Emergency" => GetEmergencyContactDetails(),
        "Appearance" => GetAppearanceSettings(),
        _ => throw new NotImplementedException(),
    };

    #region Personal Information

    private (IChildView childView, INotifyingChildPresenter childPresenter) GetPersonalInformation() {
        (IManageStaffPersonalInformationView view, ManageStaffPersonalDetailsPresenter presenter) = StaffFactory.CreateManageStaffPersonalInformation();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesPersonalInformation(presenter);
        AnyChangesCurrent = () => AnyChangesPersonalInformation(presenter);
        ValidateCurrent = () => ValidateInputsPersonalInformation(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabasePersonalInformation(presenter);
        UpdateModelCurrent = () => UpdateModelPersonalInformation(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesPersonalInformation(ManageStaffPersonalDetailsPresenter presenter) {
        presenter.Forename = _model.Forename;
        presenter.Surname = _model.Surname;
        presenter.DateOfBirth = _model.DateOfBirth;
    }

    private bool AnyChangesPersonalInformation(ManageStaffPersonalDetailsPresenter presenter) => presenter.Forename != _model.Forename || presenter.Surname != _model.Surname || presenter.DateOfBirth != _model.DateOfBirth;

    private bool ValidateInputsPersonalInformation(ManageStaffPersonalDetailsPresenter presenter) => presenter.ForenameValid && presenter.ForenameValid && presenter.ForenameValid;

    private Task<bool> UpdateDatabasePersonalInformation(ManageStaffPersonalDetailsPresenter presenter) {
        return StaffDAL.UpdateStaffPersonalInformation(_model.Id, presenter.Forename, presenter.Surname, presenter.DateOfBirth);
    }

    private void UpdateModelPersonalInformation(ManageStaffPersonalDetailsPresenter presenter) {
        _model.Forename = presenter.Forename;
        _model.Surname = presenter.Surname;
        _model.DateOfBirth = presenter.DateOfBirth;
    }
    #endregion

    #region Contact Details
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetContactDetails() {
        (IManageStaffContactDetailsView view, ManageStaffContactDetailsPresenter presenter) = StaffFactory.CreateManageStaffContactDetails();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesContactDetails(presenter);
        AnyChangesCurrent = () => AnyChangesContactDetails(presenter);
        ValidateCurrent = () => ValidateInputsContactDetails(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseContactDetails(presenter);
        UpdateModelCurrent = () => UpdateModelContactDetails(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesContactDetails(ManageStaffContactDetailsPresenter presenter) {
        presenter.Email = _model.Email;
        presenter.PhoneNumber = _model.PhoneNumber;
        presenter.Address = _model.Address;
    }

    private bool AnyChangesContactDetails(ManageStaffContactDetailsPresenter presenter) => presenter.Email != _model.Email || presenter.PhoneNumber != _model.PhoneNumber || presenter.Address != _model.Address;

    private bool ValidateInputsContactDetails(ManageStaffContactDetailsPresenter presenter) => presenter.EmailValid && presenter.PhoneNumberValid;

    private Task<bool> UpdateDatabaseContactDetails(ManageStaffContactDetailsPresenter presenter) => StaffDAL.UpdateStaffContactDetails(_model.Id, presenter.Email, presenter.PhoneNumber, presenter.Address);

    private void UpdateModelContactDetails(ManageStaffContactDetailsPresenter presenter) {
        _model.Email = presenter.Email;
        _model.PhoneNumber = presenter.PhoneNumber;
        _model.Address = presenter.Address;
    }
    #endregion

    #region Emergency Contact Details
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetEmergencyContactDetails() {
        (IManageStaffEmergencyContactDetailsView view, ManageStaffEmergencyContactDetailsPresenter presenter) = StaffFactory.CreateManageStaffEmergencyContactDetails();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesEmergencyContactDetails(presenter);
        AnyChangesCurrent = () => AnyChangesEmergencyContactDetails(presenter);
        ValidateCurrent = () => ValidateInputsEmergencyContactDetails(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseEmergencyContactDetails(presenter);
        UpdateModelCurrent = () => UpdateModelEmergencyContactDetails(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesEmergencyContactDetails(ManageStaffEmergencyContactDetailsPresenter presenter) {
        presenter.EmergencyContactForename = _model.EmergencyContactForename;
        presenter.EmergencyContactSurname = _model.EmergencyContactSurname;
        presenter.EmergencyContactPhoneNumber = _model.EmergencyContactPhoneNumber;
    }

    private bool AnyChangesEmergencyContactDetails(ManageStaffEmergencyContactDetailsPresenter presenter) => presenter.EmergencyContactForename != _model.EmergencyContactForename || presenter.EmergencyContactSurname != _model.EmergencyContactSurname || presenter.EmergencyContactPhoneNumber != _model.EmergencyContactPhoneNumber;

    private bool ValidateInputsEmergencyContactDetails(ManageStaffEmergencyContactDetailsPresenter presenter) => presenter.EmergencyContactPhoneNumberValid;

    private Task<bool> UpdateDatabaseEmergencyContactDetails(ManageStaffEmergencyContactDetailsPresenter presenter) => StaffDAL.UpdateStaffEmergencyContactInformation(_model.Id, presenter.EmergencyContactForename, presenter.EmergencyContactSurname, presenter.EmergencyContactPhoneNumber);

    private void UpdateModelEmergencyContactDetails(ManageStaffEmergencyContactDetailsPresenter presenter) {
        _model.EmergencyContactForename = presenter.EmergencyContactForename;
        _model.EmergencyContactSurname = presenter.EmergencyContactSurname;
        _model.EmergencyContactPhoneNumber = presenter.EmergencyContactPhoneNumber;
    }
    #endregion

    #region Appearance Settings
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetAppearanceSettings() {
        (IManageStaffAppearanceSettingsView view, ManageStaffAppearanceSettingsPresenter presenter) = StaffFactory.CreateManageStaffAppearanceSettings();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesAppearanceSettings(presenter);
        AnyChangesCurrent = () => AnyChangesAppearanceSettings(presenter);
        ValidateCurrent = () => true;
        UpdateDatabaseCurrent = () => UpdateDatabaseAppearanceSettings(presenter);
        UpdateModelCurrent = () => UpdateModelAppearanceSettings(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesAppearanceSettings(ManageStaffAppearanceSettingsPresenter presenter) {
        presenter.DarkMode = _model.Theme.IsDarkMode;
        presenter.ShowToolTips = _model.Theme.ShowToolTips;
        presenter.FontName = _model.Theme.FontName;
    }

    private bool AnyChangesAppearanceSettings(ManageStaffAppearanceSettingsPresenter presenter) {
        return presenter.DarkMode != _model.Theme.IsDarkMode ||
               presenter.ShowToolTips != _model.Theme.ShowToolTips ||
               presenter.FontName != _model.Theme.FontName;
    }

    private Task<bool> UpdateDatabaseAppearanceSettings(ManageStaffAppearanceSettingsPresenter presenter) {
        return StaffDAL.UpdateStaffAppearanceSettings(_model.Id, new Theming.Theme(
            presenter.DarkMode ? Theming.AppearanceTheme.Dark : Theming.AppearanceTheme.Light,
            presenter.ShowToolTips,
            presenter.FontName));
    }

    private void UpdateModelAppearanceSettings(ManageStaffAppearanceSettingsPresenter presenter) {
        _model.Theme = new Theming.Theme(
            presenter.DarkMode ? Theming.AppearanceTheme.Dark : Theming.AppearanceTheme.Light,
            presenter.ShowToolTips,
            presenter.FontName);
    }
    #endregion

    #region Credentials
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetCredentials() {
        (IManageStaffCredentialsView view, ManageStaffCredentialsPresenter presenter) = StaffFactory.CreateManageStaffCredentials();

        presenter.ValidateUsernameRequest += OnValidateUsername;

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesCredentials(presenter);
        AnyChangesCurrent = () => AnyChangesCredentials(presenter);
        ValidateCurrent = () => ValidateInputsCredentials(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseCredentials(presenter);
        UpdateModelCurrent = () => UpdateModelCredentials(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesCredentials(ManageStaffCredentialsPresenter presenter) {
        string suggestedUsername = (_model.Forename[..1] + _model.Surname).ToLower() + _model.Id;

        presenter.PrivilegeLevel = _model.PrivilegeLevel;
        presenter.Username = _model.Username;
        presenter.SetSuggestedUsername(suggestedUsername);
    }

    private bool AnyChangesCredentials(ManageStaffCredentialsPresenter presenter) {
        return presenter.Username != _model.Username || presenter.PrivilegeLevel != _model.PrivilegeLevel;
    }

    private bool ValidateInputsCredentials(ManageStaffCredentialsPresenter presenter) => presenter.UsernameValid;

    private Task<bool> UpdateDatabaseCredentials(ManageStaffCredentialsPresenter presenter) => StaffDAL.UpdateStaffCredentials(_model.Id, presenter.Username, presenter.PrivilegeLevel);

    private void UpdateModelCredentials(ManageStaffCredentialsPresenter presenter) {
        _model.Username = presenter.Username;
        _model.PrivilegeLevel = presenter.PrivilegeLevel;
    }

    private void IsValidUsername(ValidationRequestEventArgs<string> validateUsernameRequest) {
        string username = validateUsernameRequest.Value;

        if (username == _model.Username) {
            validateUsernameRequest.SetValidation(true);
            return;
        }

        if (string.IsNullOrWhiteSpace(username)) validateUsernameRequest.SetValidation(false, "Please fill in a username");
        else validateUsernameRequest.SetValidation(StaffDAL.GetStaffByUsername(username).ContinueWith(x => x.Result is null), "This username already exists. Please pick a different one");
    }

    #endregion

    public override void CleanUp() {
        if (_childPresenter is ManageStaffCredentialsPresenter manageStaffCredentialsPresenter) manageStaffCredentialsPresenter.ValidateUsernameRequest -= OnValidateUsername;
        base.CleanUp();
    }
}