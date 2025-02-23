using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Staff.StaffManagement;
using a2_coursework.Model.Security;
using a2_coursework.Model.Staff;
using a2_coursework.View;
using a2_coursework.View.StaffView;

namespace a2_coursework.Presenter.Staff.StaffManagement;
public class AddStaffPresenter : AddPresenter<IAddStaffView, StaffModel>, IChildPresenter, INavigatingPresenter {
    private readonly StaffModel _staff;

    private string _password = "";
    private string _confirmPassword = "";

    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public AddStaffPresenter(IAddStaffView view, StaffModel staff) : base(view, new StaffModel(-1, [], [], DateTime.MinValue, "", false, PrivilegeLevel.Office, "", "", null, "", "", "", "", "", "", new Theming.Theme())) {
        _staff = staff;

        _viewFactories.Add(GetPersonalInformation);
        _viewFactories.Add(GetCredentials);
        _viewFactories.Add(GetContactDetails);
        _viewFactories.Add(GetEmergencyContactDetails);
        _viewFactories.Add(GetAppearanceSettings);
        _viewFactories.Add(GetPassword);

        _view.Back += OnBack;

        NavigateToCurrentView();
    }

    private void OnBack(object? sender, EventArgs e) {
        if (CanExit()) NavigateBack();
    }
    private void OnValidateUsernameRequest(object? sender, ValidationRequestEventArgs<string> e) => IsValidUsername(e);

    private void NavigateBack() {
        (IChildView view, IChildPresenter presenter) = StaffFactory.CreateDisplayStaff(_staff);
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void BindValidation(ICleanable presenter) {
        if (presenter is ManageStaffCredentialsPresenter manageStaffCredentialsPresenter) manageStaffCredentialsPresenter.ValidateUsernameRequest += OnValidateUsernameRequest;
    }

    protected override void UnBindValidation(ICleanable presenter) {
        if (presenter is ManageStaffCredentialsPresenter manageStaffCredentialsPresenter) manageStaffCredentialsPresenter.ValidateUsernameRequest -= OnValidateUsernameRequest;
    }

    protected override Task<bool> UpdateDatabase() {
        byte[] hash = CryptographyManager.GetHash(_password, out byte[] salt);

        return StaffDAL.CreateStaff(_model.Username, Convert.ToHexString(hash), Convert.ToHexString(salt), _model.Forename, _model.Surname, _model.DateOfBirth, _model.Email, _model.PhoneNumber, _model.Address, _model.EmergencyContactForename, _model.EmergencyContactSurname, _model.EmergencyContactPhoneNumber, (int)_model.PrivilegeLevel);
    }

    #region Personal Information
    private (IChildView childView, ICleanable childPresenter) GetPersonalInformation() {
        (ManageStaffPersonalDetailsView view, ManageStaffPersonalDetailsPresenter presenter) = StaffFactory.CreateManageStaffPersonalInformation();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesPersonalInformation(presenter);
        ValidateCurrent = () => ValidateInputsPersonalInformation(presenter);
        UpdateModelCurrent = () => UpdateModelPersonalInformation(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesPersonalInformation(ManageStaffPersonalDetailsPresenter presenter) {
        presenter.Surname = _model.Surname;
        presenter.Forename = _model.Forename;
        presenter.DateOfBirth = _model.DateOfBirth;
    }

    private bool ValidateInputsPersonalInformation(ManageStaffPersonalDetailsPresenter presenter) => presenter.SurnameValid && presenter.ForenameValid && presenter.DateOfBirthValid;

    private void UpdateModelPersonalInformation(ManageStaffPersonalDetailsPresenter presenter) {
        _model.Surname = presenter.Surname;
        _model.Forename = presenter.Forename;
        _model.DateOfBirth = presenter.DateOfBirth;
    }
    #endregion

    #region Contact Details
    private (IChildView childView, ICleanable childPresenter) GetContactDetails() {
        (IManageStaffContactDetailsView view, ManageStaffContactDetailsPresenter presenter) = StaffFactory.CreateManageStaffContactDetails();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesContactDetails(presenter);
        ValidateCurrent = () => ValidateInputsContactDetails(presenter);
        UpdateModelCurrent = () => UpdateModelContactDetails(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesContactDetails(ManageStaffContactDetailsPresenter presenter) {
        presenter.Email = _model.Email;
        presenter.PhoneNumber = _model.PhoneNumber;
        presenter.Address = _model.Address;
    }

    private bool ValidateInputsContactDetails(ManageStaffContactDetailsPresenter presenter) => presenter.EmailValid && presenter.PhoneNumberValid;

    private void UpdateModelContactDetails(ManageStaffContactDetailsPresenter presenter) {
        _model.Email = presenter.Email;
        _model.PhoneNumber = presenter.PhoneNumber;
        _model.Address = presenter.Address;
    }
    #endregion

    #region Emergency Contact Details
    private (IChildView childView, ICleanable childPresenter) GetEmergencyContactDetails() {
        (IManageStaffEmergencyContactDetailsView view, ManageStaffEmergencyContactDetailsPresenter presenter) = StaffFactory.CreateManageStaffEmergencyContactDetails();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesEmergencyContactDetails(presenter);
        ValidateCurrent = () => ValidateInputsEmergencyContactDetails(presenter);
        UpdateModelCurrent = () => UpdateModelEmergencyContactDetails(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesEmergencyContactDetails(ManageStaffEmergencyContactDetailsPresenter presenter) {
        presenter.EmergencyContactForename = _model.EmergencyContactForename;
        presenter.EmergencyContactSurname = _model.EmergencyContactSurname;
        presenter.EmergencyContactPhoneNumber = _model.EmergencyContactPhoneNumber;
    }

    private bool ValidateInputsEmergencyContactDetails(ManageStaffEmergencyContactDetailsPresenter presenter) => presenter.EmergencyContactPhoneNumberValid;

    private void UpdateModelEmergencyContactDetails(ManageStaffEmergencyContactDetailsPresenter presenter) {
        _model.EmergencyContactForename = presenter.EmergencyContactForename;
        _model.EmergencyContactSurname = presenter.EmergencyContactSurname;
        _model.EmergencyContactPhoneNumber = presenter.EmergencyContactPhoneNumber;
    }
    #endregion

    #region Appearance Settings
    private (IChildView childView, ICleanable childPresenter) GetAppearanceSettings() {
        (IManageStaffAppearanceSettingsView view, ManageStaffAppearanceSettingsPresenter presenter) = StaffFactory.CreateManageStaffAppearanceSettings();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesAppearanceSettings(presenter);
        ValidateCurrent = () => true;
        UpdateModelCurrent = () => UpdateModelAppearanceSettings(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesAppearanceSettings(ManageStaffAppearanceSettingsPresenter presenter) {
        presenter.DarkMode = _model.Theme.IsDarkMode;
        presenter.ShowToolTips = _model.Theme.ShowToolTips;
        presenter.FontName = _model.Theme.FontName;
    }

    private void UpdateModelAppearanceSettings(ManageStaffAppearanceSettingsPresenter presenter) {
        _model.Theme = new Theming.Theme(
            presenter.DarkMode ? Theming.AppearanceTheme.Dark : Theming.AppearanceTheme.Light,
            presenter.ShowToolTips,
            presenter.FontName);
    }
    #endregion

    #region Credentials
    private (IChildView childView, ICleanable childPresenter) GetCredentials() {
        (IManageStaffCredentialsView view, ManageStaffCredentialsPresenter presenter) = StaffFactory.CreateManageStaffCredentials();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesCredentials(presenter);
        ValidateCurrent = () => ValidateInputsCredentials(presenter);
        UpdateModelCurrent = () => UpdateModelCredentials(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesCredentials(ManageStaffCredentialsPresenter presenter) {
        string suggestedUsername;
        
        if (_model.Forename.Length > 0) suggestedUsername = (_model.Forename[..1] + _model.Surname).ToLower();
        else suggestedUsername = (_model.Forename + _model.Surname).ToLower();

        presenter.PrivilegeLevel = _model.PrivilegeLevel;
        presenter.Username = _model.Username;
        presenter.SetSuggestedUsername(suggestedUsername);
    }

    private bool ValidateInputsCredentials(ManageStaffCredentialsPresenter presenter) => presenter.UsernameValid;

    private void UpdateModelCredentials(ManageStaffCredentialsPresenter presenter) {
        _model.Username = presenter.Username;
        _model.PrivilegeLevel = presenter.PrivilegeLevel;
    }

    private void IsValidUsername(ValidationRequestEventArgs<string> validateUsernameRequest) {
        string username = validateUsernameRequest.Value;

        if (string.IsNullOrWhiteSpace(username)) validateUsernameRequest.SetValidation(false, "Please fill in a username");
        else validateUsernameRequest.SetValidation(StaffDAL.GetStaffByUsername(username).ContinueWith(x => x.Result is null), "This username already exists. Please pick a different one");
    }
    #endregion

    #region Password
    private (IChildView childView, ICleanable childPresenter) GetPassword() {
        (IManageStaffPasswordView view, ManageStaffPasswordPresenter presenter) = StaffFactory.CreateManageStaffPassword();

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesPassword(presenter);
        ValidateCurrent = () => ValidateInputsPassword(presenter);
        UpdateModelCurrent = () => UpdateModelPassword(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesPassword(ManageStaffPasswordPresenter presenter) {
        presenter.Password = _password;
        presenter.ConfirmPassword = _confirmPassword;
    }

    private bool ValidateInputsPassword(ManageStaffPasswordPresenter presenter) => presenter.PasswordValid;

    private void UpdateModelPassword(ManageStaffPasswordPresenter presenter) {
        _password = presenter.Password;
        _confirmPassword = presenter.ConfirmPassword;
    }
    #endregion

    protected override void OnAddSuccessful() => NavigateBack();

    public override void CleanUp() {
        _view.Back -= OnBack;

        base.CleanUp();
    }
}
