using a2_coursework.Model;
using a2_coursework.View.Interfaces.Stock;

namespace a2_coursework.Presenter.Stock;
public class StockDisplayPresenter {
    private readonly IStockDisplay _view;
    private List<StockItem>? _stockItems;

    public StockDisplayPresenter(IStockDisplay view) {
        _view = view;

        LoadData();
    }

    public async void LoadData() {
        try {
            _stockItems = await StockDAL.GetStock();


        }
        catch {

        }
    }

    private void DisplayData() {
    }
}
