using a2_coursework.Presenter.Customer;
using a2_coursework.View.Customers;

namespace a2_coursework.Factory;
public static class CustomerFactory {
    public static (DisplayCustomerView view, DisplayCustomerPresenter presenter) CreateDisplayCustomer() {
        DisplayCustomerView view = new();
        DisplayCustomerPresenter presenter = new(view);

        return (view, presenter);
    }
}
