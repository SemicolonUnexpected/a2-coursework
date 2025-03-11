using a2_coursework.Model.Order;
using a2_coursework.Model.Staff;
using a2_coursework.Presenter.Order;
using a2_coursework.View.Order;
using a2_coursework.View.Stock;

namespace a2_coursework.Factory;
public static class OrderFactory {
    public static (DisplayOrderView view, DisplayOrderPresenter presenter) CreateDisplayOrder(StaffModel staff) {
        DisplayOrderView view = new();
        DisplayOrderPresenter presenter = new(view, staff);

        return (view, presenter);
    }

    public static (SelectOrderStockView view, SelectOrderStockPresenter presenter) CreateSelectOrderStock() {
        SelectOrderStockView view = new();
        SelectOrderStockPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (ManageOrderStockView view, ManageOrderStockPresenter presenter) CreateManageOrderStock() {
        ManageOrderStockView view = new();
        ManageOrderStockPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (SubmitOrderView view, SubmitOrderPresenter presenter) CreateSubmitOrder() {
        SubmitOrderView view = new();
        SubmitOrderPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (EditOrderView view, EditOrderPresenter presenter) CreateEditOrder(OrderModel order, StaffModel staff) {
        EditOrderView view = new();
        EditOrderPresenter presenter = new(view, order, staff);
        return (view, presenter);
    }

    public static (AddOrderView view, AddOrderPresenter presenter) CreateAddOrder(StaffModel staff) {
        AddOrderView view = new();
        AddOrderPresenter presenter = new(view, staff);
        return (view, presenter);
    }
}
