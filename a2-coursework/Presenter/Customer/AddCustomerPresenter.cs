
using a2_coursework.Interfaces;
using a2_coursework.Interfaces.Customer;
using a2_coursework.Model.Customer;
using a2_coursework.View.Order;
using a2_coursework.Factory;

namespace a2_coursework.Presenter.Customer;
public class AddCustomerPresenter : AddPresenter<IAddCustomerView, CustomerModel>, IChildPresenter, INavigatingPresenter {
    public event EventHandler<NavigationEventArgs>? NavigationRequest;

    public AddCustomerPresenter(IAddCustomerView view) : base(view, new CustomerModel(-1, "", "", "", "", "", false)) {

        _viewFactories.Add(GetPersonalDetails);
        _viewFactories.Add(GetContactDetails);

        _view.Back += OnBack;

        NavigateToCurrentView();
    }

    private void OnBack(object? sender, EventArgs e) {
        if (CanExit()) NavigateBack();
    }

    private void NavigateBack() {
        (IChildView view, IChildPresenter presenter) = CustomerFactory.CreateDisplayCustomer();
        NavigationRequest?.Invoke(this, new NavigationEventArgs(view, presenter));
    }

    protected override void BindValidation(ICleanable presenter) { }

    protected override void UnBindValidation(ICleanable presenter) { }

    protected override Task<bool> UpdateDatabase() => CustomerDAL.AddCustomer(_model);
    #region Contact Details

    private (IChildView childView, ICleanable childPresenter) GetContactDetails() {
        (SubmitOrderView view, ManageCustomerContactDetailsPresenter presenter) = CustomerFactory.CreateManageCustomerContactDetails(_model);

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesContactDetails(presenter);
        ValidateCurrent = () => ValidateInputsContactDetails(presenter);
        UpdateModelCurrent = () => UpdateModelContactDetails(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesContactDetails(ManageCustomerContactDetailsPresenter presenter) {
        presenter.Email = _model.Email;
        presenter.PhoneNumber = _model.PhoneNumber;
        presenter.Address = _model.Address;
    }

    private bool ValidateInputsContactDetails(ManageCustomerContactDetailsPresenter presenter) => presenter.EmailValid && presenter.PhoneNumberValid;

    private void UpdateModelContactDetails(ManageCustomerContactDetailsPresenter presenter) {
        _model.Email = presenter.Email;
        _model.PhoneNumber = presenter.PhoneNumber;
        _model.Address = presenter.Address;
    }
    #endregion

    #region Personal Details

    private (IChildView childView, ICleanable childPresenter) GetPersonalDetails() {
        (ManageCustomerPersonalDetailsView view, ManageCustomerPersonalDetailsPresenter presenter) = CustomerFactory.CreateManageCustomerPersonalDetails(_model);

        PopulateDefaultValuesCurrent = () => PopulateDefaultValuesPersonalDetails(presenter);
        ValidateCurrent = () => ValidateInputsPersonalDetails(presenter);
        UpdateModelCurrent = () => UpdateModelPersonalDetails(presenter);

        return (view, presenter);
    }

    private void PopulateDefaultValuesPersonalDetails(ManageCustomerPersonalDetailsPresenter presenter) {
        presenter.Forename = _model.Forename;
        presenter.Surname = _model.Surname;
        presenter.Archived = _model.Archived;
    }

    private bool ValidateInputsPersonalDetails(ManageCustomerPersonalDetailsPresenter presenter) => presenter.SurnameValid && presenter.ForenameValid;

    private void UpdateModelPersonalDetails(ManageCustomerPersonalDetailsPresenter presenter) {
        _model.Forename = presenter.Forename;
        _model.Surname  = presenter.Surname;
        _model.Archived = presenter.Archived;
    }
    #endregion

    protected override void OnAddSuccessful() => NavigateBack();

    public override void CleanUp() {
        _view.Back -= OnBack;

        base.CleanUp();
    }
}
