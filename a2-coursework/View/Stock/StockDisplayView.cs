using a2_coursework.Model;
namespace a2_coursework.View;
public partial class StockDisplayView : Form {
    public StockDisplayView() {
        InitializeComponent();

        columnID.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        columnQuantity.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        columnArchived.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        columnStockHealth.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
    }

    private void StockDisplayView_Load(object sender, EventArgs e) {

    }

    public void DisplayData(List<Model.Stock> stocks) {
    }
}
