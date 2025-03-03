using a2_coursework.Model.Customer;
using a2_coursework.Presenter.Customer;
using a2_coursework.View.CleaningJob;

namespace a2_coursework.Factory;
public static class CustomerFactory {
    public static (DisplayCustomerView view, DisplayCustomerPresenter presenter) CreateDisplayCustomer() {
        DisplayCustomerView view = new();
        DisplayCustomerPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (AddCustomerView view, AddCustomerPresenter presenter) CreateAddCustomer() {
        AddCustomerView view = new();
        AddCustomerPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (EditCustomerView view, EditCustomerPresenter presenter) CreateEditCustomer(CustomerModel model) {
        EditCustomerView view = new();
        EditCustomerPresenter presenter = new(view, model);

        return (view, presenter);
    }

    public static (ManageCustomerContactDetailsView view, ManageCustomerContactDetailsPresenter presenter) CreateManageCustomerContactDetails(CustomerModel model) {
        ManageCustomerContactDetailsView view = new();
        ManageCustomerContactDetailsPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (ManageCustomerPersonalDetailsView view, ManageCustomerPersonalDetailsPresenter presenter) CreateManageCustomerPersonalDetails(CustomerModel model) {
        ManageCustomerPersonalDetailsView view = new();
        ManageCustomerPersonalDetailsPresenter presenter = new(view);

        return (view, presenter);
    }
}
