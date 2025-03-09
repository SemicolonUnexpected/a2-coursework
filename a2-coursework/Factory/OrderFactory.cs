using a2_coursework.Model.Staff;
using a2_coursework.Presenter.Order;
using a2_coursework.View.Order;

namespace a2_coursework.Factory;
public static class OrderFactory {
    public static (DisplayOrderView view, DisplayOrderPresenter presenter) CreateDisplayOrder(StaffModel staff) {
        DisplayOrderView view = new();
        DisplayOrderPresenter presenter = new(view, staff);

        return (view, presenter);
    }

}
