using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Staff.StaffManagement;
using a2_coursework.Model.Staff;
using a2_coursework.View;

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
        (IChildView view, IChildPresenter presenter) = ViewFactory.CreateDisplayStaff(_staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void BindValidation() {
        if (_childPresenter is ManageStaffCredentialsPresenter manageStaffCredentialsPresenter) manageStaffCredentialsPresenter.ValidateUsernameRequest += OnValidateUsername;
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
        (IManageStaffPersonalInformationView view, ManageStaffPersonalInformationPresenter presenter) = ViewFactory.CreateManageStaffPersonalInformation();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesPersonalInformation(presenter);
        AnyChangesCurrent = () => AnyChangesPersonalInformation(presenter);
        ValidateInputsCurrent = () => ValidateInputsPersonalInformation(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabasePersonalInformation(presenter);
        UpdateModelCurrent = () => UpdateModelPersonalInformation(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesPersonalInformation(ManageStaffPersonalInformationPresenter presenter) {
        presenter.SetForname(_model.Forename);
        presenter.SetSurname(_model.Surname);
        presenter.SetDateOfBirth(_model.DateOfBirth);
    }

    private bool AnyChangesPersonalInformation(ManageStaffPersonalInformationPresenter presenter) {
        bool forenameValid = presenter.TryGetForename(out string? forename);
        bool surnameValid = presenter.TryGetSurname(out string? surname);
        bool dateOfBirthValid = presenter.TryGetDateOfBirth(out DateTime? dateOfBirth);

        if (!forenameValid || !surnameValid || !dateOfBirthValid) return true;

        return forename != _model.Forename || surname != _model.Surname || dateOfBirth != _model.DateOfBirth;
    }

    private bool ValidateInputsPersonalInformation(ManageStaffPersonalInformationPresenter presenter) {
        return presenter.TryGetForename(out _) && presenter.TryGetSurname(out _) && presenter.TryGetDateOfBirth(out _);
    }

    private Task<bool> UpdateDatabasePersonalInformation(ManageStaffPersonalInformationPresenter presenter) {
        presenter.TryGetForename(out string? forename);
        presenter.TryGetSurname(out string? surname);
        presenter.TryGetDateOfBirth(out DateTime? dateOfBirth);

        return StaffDAL.UpdatePersonalInformation(_model.Id, forename!, surname!, dateOfBirth!.Value);
    }

    private void UpdateModelPersonalInformation(ManageStaffPersonalInformationPresenter presenter) {
        presenter.TryGetForename(out string? forename);
        presenter.TryGetSurname(out string? surname);
        presenter.TryGetDateOfBirth(out DateTime? dateOfBirth);

        _model.Forename = forename!;
        _model.Surname = surname!;
        _model.DateOfBirth = dateOfBirth!.Value;
    }
    #endregion

    #region Contact Details
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetContactDetails() {
        (IManageStaffContactDetailsView view, ManageStaffContactDetailsPresenter presenter) = ViewFactory.CreateManageStaffContactDetails();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesContactDetails(presenter);
        AnyChangesCurrent = () => AnyChangesContactDetails(presenter);
        ValidateInputsCurrent = () => ValidateInputsContactDetails(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseContactDetails(presenter);
        UpdateModelCurrent = () => UpdateModelContactDetails(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesContactDetails(ManageStaffContactDetailsPresenter presenter) {
        presenter.SetEmail(_model.Email);
        presenter.SetPhoneNumber(_model.PhoneNumber);
        presenter.Address = _model.Address;
    }

    private bool AnyChangesContactDetails(ManageStaffContactDetailsPresenter presenter) {
        bool emailValid = presenter.TryGetEmail(out string? email);
        bool phoneNumberValid = presenter.TryGetPhoneNumber(out string? phoneNumber);

        if (!emailValid || !phoneNumberValid) return true;

        return email != _model.Email || phoneNumber != _model.PhoneNumber || presenter.Address != _model.Address;
    }

    private bool ValidateInputsContactDetails(ManageStaffContactDetailsPresenter presenter) {
        return presenter.TryGetEmail(out _) && presenter.TryGetPhoneNumber(out _);
    }

    private Task<bool> UpdateDatabaseContactDetails(ManageStaffContactDetailsPresenter presenter) {
        presenter.TryGetEmail(out string? email);
        presenter.TryGetPhoneNumber(out string? phoneNumber);

        return StaffDAL.UpdateContactDetails(_model.Id, email!, phoneNumber!, presenter.Address);
    }

    private void UpdateModelContactDetails(ManageStaffContactDetailsPresenter presenter) {
        presenter.TryGetEmail(out string? email);
        presenter.TryGetPhoneNumber(out string? phoneNumber);

        _model.Email = email!;
        _model.PhoneNumber = phoneNumber!;
        _model.Address = presenter.Address;
    }
    #endregion

    #region Emergency Contact Details
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetEmergencyContactDetails() {
        (IManageStaffEmergencyContactDetailsView view, ManageStaffEmergencyContactDetailsPresenter presenter) = ViewFactory.CreateManageStaffEmergencyContactDetails();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesEmergencyContactDetails(presenter);
        AnyChangesCurrent = () => AnyChangesEmergencyContactDetails(presenter);
        ValidateInputsCurrent = () => ValidateInputsEmergencyContactDetails(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseEmergencyContactDetails(presenter);
        UpdateModelCurrent = () => UpdateModelEmergencyContactDetails(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesEmergencyContactDetails(ManageStaffEmergencyContactDetailsPresenter presenter) {
        presenter.EmergencyContactForename = _model.EmergencyContactForename;
        presenter.EmergencyContactSurname = _model.EmergencyContactSurname;
        presenter.SetEmergencyContactPhoneNumber(_model.EmergencyContactPhoneNumber);
    }

    private bool AnyChangesEmergencyContactDetails(ManageStaffEmergencyContactDetailsPresenter presenter) {
        bool phoneNumberValid = presenter.TryGetEmergencyContactPhoneNumber(out string? phoneNumber);

        if (!phoneNumberValid) return true;

        return presenter.EmergencyContactForename != _model.EmergencyContactForename ||
               presenter.EmergencyContactSurname != _model.EmergencyContactSurname ||
               phoneNumber != _model.EmergencyContactPhoneNumber;
    }

    private bool ValidateInputsEmergencyContactDetails(ManageStaffEmergencyContactDetailsPresenter presenter) {
        return presenter.TryGetEmergencyContactPhoneNumber(out _);
    }

    private Task<bool> UpdateDatabaseEmergencyContactDetails(ManageStaffEmergencyContactDetailsPresenter presenter) {
        presenter.TryGetEmergencyContactPhoneNumber(out string? phoneNumber);

        return StaffDAL.UpdateEmergencyContactInformation(_model.Id, presenter.EmergencyContactForename, presenter.EmergencyContactSurname, phoneNumber!);
    }

    private void UpdateModelEmergencyContactDetails(ManageStaffEmergencyContactDetailsPresenter presenter) {
        presenter.TryGetEmergencyContactPhoneNumber(out string? phoneNumber);

        _model.EmergencyContactForename = presenter.EmergencyContactForename;
        _model.EmergencyContactSurname = presenter.EmergencyContactSurname;
        _model.EmergencyContactPhoneNumber = phoneNumber!;
    }
    #endregion

    #region Appearance Settings
    private (IChildView childView, INotifyingChildPresenter childPresenter) GetAppearanceSettings() {
        (IManageStaffAppearanceSettingsView view, ManageStaffAppearanceSettingsPresenter presenter) = ViewFactory.CreateManageStaffAppearanceSettings();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesAppearanceSettings(presenter);
        AnyChangesCurrent = () => AnyChangesAppearanceSettings(presenter);
        ValidateInputsCurrent = () => true;
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
        return StaffDAL.UpdateAppearanceSettings(_model.Id, new Theming.Theme(
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
        (IManageStaffCredentialsView view, ManageStaffCredentialsPresenter presenter) = ViewFactory.CreateManageStaffCredentials();

        presenter.ValidateUsernameRequest += OnValidateUsername;

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesCredentials(presenter);
        AnyChangesCurrent = () => AnyChangesCredentials(presenter);
        ValidateInputsCurrent = () => ValidateInputsCredentials(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseCredentials(presenter);
        UpdateModelCurrent = () => UpdateModelCredentials(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesCredentials(ManageStaffCredentialsPresenter presenter) {
        string suggestedUsername = (_model.Forename[..1] + _model.Surname).ToLower() + _model.Id;

        presenter.PrivilegeLevel = _model.PrivilegeLevel;
        presenter.SetUsername(_model.Username);
        presenter.SetSuggestedUsername(suggestedUsername);
    }

    private bool AnyChangesCredentials(ManageStaffCredentialsPresenter presenter) {
        bool usernameValid = presenter.TryGetUsername(out string? username);

        if (!usernameValid) return true;

        return username != _model.Username || presenter.PrivilegeLevel != _model.PrivilegeLevel;
    }

    private bool ValidateInputsCredentials(ManageStaffCredentialsPresenter presenter) {
        return presenter.TryGetUsername(out _);
    }

    private Task<bool> UpdateDatabaseCredentials(ManageStaffCredentialsPresenter presenter) {
        presenter.TryGetUsername(out string? username);

        return StaffDAL.UpdateCredentials(_model.Id, username!, presenter.PrivilegeLevel);
    }

    private void UpdateModelCredentials(ManageStaffCredentialsPresenter presenter) {
        presenter.TryGetUsername(out string? username);

        _model.Username = username!;
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