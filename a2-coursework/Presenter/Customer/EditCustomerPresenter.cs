using a2_coursework.Factory;
using a2_coursework.Interfaces;
using a2_coursework.Model.Customer;
using a2_coursework.View.Customer;
using a2_coursework.View.Customer;

namespace a2_coursework.Presenter.Customer;
public class EditCustomerPresenter : ParentEditPresenter<IEditCustomerView, CustomerModel>, IChildPresenter, INavigatingPresenter {
    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public EditCustomerPresenter(IEditCustomerView view, CustomerModel model) : base(view, model) {
        _view.Back += OnBack;

        Navigate(GetPersonalDetails());
    }

    private void OnBack(object? sender, EventArgs e) => NavigateBack();

    private void NavigateBack() {
        if (!CanExit()) return;
        (IChildView view, IChildPresenter presenter) = CustomerFactory.CreateDisplayCustomer();
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void BindValidation() { }

    protected override void UnBindValidation() { }

    protected override (IChildView childView, INotifyingChildPresenter childPresenter) GetView(string selectedItem) => selectedItem switch {
        "Details" => GetPersonalDetails(),
        "Contact" => GetContactDetails(),
        _ => throw new NotImplementedException(),
    };

    #region Contact Details

    private (IChildView childView, INotifyingChildPresenter childPresenter) GetContactDetails() {
        (ManageCustomerContactDetailsView view, ManageCustomerContactDetailsPresenter presenter) = CustomerFactory.CreateManageCustomerContactDetails(_model);

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesContactDetails(presenter);
        AnyChangesCurrent = () => AnyChangesContactDetails(presenter);
        ValidateCurrent = () => ValidateInputsContactDetails(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabaseContactDetails(presenter);
        UpdateModelCurrent = () => UpdateModelContactDetails(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesContactDetails(ManageCustomerContactDetailsPresenter presenter) {
        presenter.Email = _model.Email;
        presenter.PhoneNumber = _model.PhoneNumber;
        presenter.Address = _model.Address;
    }

    private bool AnyChangesContactDetails(ManageCustomerContactDetailsPresenter presenter) => presenter.Email != _model.Email || presenter.PhoneNumber != _model.PhoneNumber || presenter.Address != _model.Address;

    private bool ValidateInputsContactDetails(ManageCustomerContactDetailsPresenter presenter) => presenter.EmailValid && presenter.PhoneNumberValid;

    private Task<bool> UpdateDatabaseContactDetails(ManageCustomerContactDetailsPresenter presenter) => CustomerDAL.UpdateContact(_model.Id, presenter.PhoneNumber, presenter.Email, presenter.Address);

    private void UpdateModelContactDetails(ManageCustomerContactDetailsPresenter presenter) {
        _model.Email = presenter.Email;
        _model.PhoneNumber = presenter.PhoneNumber;
        _model.Address = presenter.Address;
    }
    #endregion

    #region Personal Details

    private (IChildView childView, INotifyingChildPresenter childPresenter) GetPersonalDetails() {
        (ManageCustomerPersonalDetailsView view, ManageCustomerPersonalDetailsPresenter presenter) = CustomerFactory.CreateManageCustomerPersonalDetails(_model);

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesPersonalDetails(presenter);
        AnyChangesCurrent = () => AnyChangesPersonalDetails(presenter);
        ValidateCurrent = () => ValidateInputsPersonalDetails(presenter);
        UpdateDatabaseCurrent = () => UpdateDatabasePersonalDetails(presenter);
        UpdateModelCurrent = () => UpdateModelPersonalDetails(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesPersonalDetails(ManageCustomerPersonalDetailsPresenter presenter) {
        presenter.Forename = _model.Forename;
        presenter.Surname = _model.Surname;
        presenter.Archived = _model.Archived;
    }

    private bool AnyChangesPersonalDetails(ManageCustomerPersonalDetailsPresenter presenter) => presenter.Surname != _model.Surname || presenter.Forename != _model.Forename || presenter.Archived != _model.Archived;

    private bool ValidateInputsPersonalDetails(ManageCustomerPersonalDetailsPresenter presenter) => presenter.SurnameValid && presenter.ForenameValid;

    private Task<bool> UpdateDatabasePersonalDetails(ManageCustomerPersonalDetailsPresenter presenter) => CustomerDAL.UpdatePersonalDetails(_model.Id, presenter.Forename, presenter.Surname, presenter.Archived);

    private void UpdateModelPersonalDetails(ManageCustomerPersonalDetailsPresenter presenter) {
        _model.Forename = presenter.Forename;
        _model.Surname  = presenter.Surname;
        _model.Archived = presenter.Archived;
    }
    #endregion

    public override void CleanUp() {
        _view.Back -= OnBack;

        base.CleanUp();
    }
}
