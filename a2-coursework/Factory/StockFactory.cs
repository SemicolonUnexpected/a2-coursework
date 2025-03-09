using a2_coursework.Model.Staff;
using a2_coursework.Model.Stock;
using a2_coursework.Presenter.Stock.StockManagement;
using a2_coursework.Presenter.Stock.StockQuantityChanges;
using a2_coursework.Presenter.StockPresenter.StockQuantityChanges;
using a2_coursework.View;
using a2_coursework.View.Stock;

namespace a2_coursework.Factory;

public static class StockFactory {
    public static (AddStockView view, AddStockPresenter presenter) CreateAddStock(StaffModel staff) {
        AddStockView view = new();
        AddStockPresenter presenter = new(view, staff);

        return (view, presenter);
    }

    public static (DisplayStockQuantityChangesView view, DisplayStockQuantityChangesPresenter presenter) CreateDisplayStockQuantityChanges() {
        DisplayStockQuantityChangesView view = new();
        DisplayStockQuantityChangesPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (EditStockView view, EditStockPresenter presenter) CreateEditStock(StockModel stockItem, StaffModel staff) {
        EditStockView view = new();
        EditStockPresenter presenter = new(view, stockItem, staff);

        return (view, presenter);
    }

    public static (ManageStockDetailsView view, ManageStockDetailsPresenter presenter) CreateManageStockDetails() {
        ManageStockDetailsView view = new();
        ManageStockDetailsPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (ManageStockQuantityView view, ManageStockQuantityPresenter presenter) CreateManageStockQuantity() {
        ManageStockQuantityView view = new();
        ManageStockQuantityPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (ManageStockWarningView view, ManageStockWarningPresenter presenter) CreateManageStockWarning() {
        ManageStockWarningView view = new();
        ManageStockWarningPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (ManageStockUnitCostView view, ManageStockUnitCostPresenter presenter) CreateManageStockUnitCost() {
        ManageStockUnitCostView view = new();
        ManageStockUnitCostPresenter presenter = new(view);

        return (view, presenter);
    }

    public static (DisplayStockView view, DisplayStockPresenter presenter) CreateStockDisplay(StaffModel staff) {
        DisplayStockView view = new();
        DisplayStockPresenter presenter = new(view, staff);

        return (view, presenter);
    }

    public static (ViewStockQuantityChangeView view, ViewStockQuantityChangePresenter presenter) CreateViewStockQuantityChange(StockQuantityChange stockQuantityChange) {
        ViewStockQuantityChangeView view = new();
        ViewStockQuantityChangePresenter presenter = new(view, stockQuantityChange);

        return (view, presenter);
    }
}
