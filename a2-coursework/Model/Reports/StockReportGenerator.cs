using a2_coursework.Model.Stock;
using QuestPDF.Fluent;

namespace a2_coursework.Model.Reports; 
public static class StockReportGenerator {
    public static  async Task<MemoryStream> StockItemsReport() {
        List<StockModel> models = await StockDAL.GetStock();
        MemoryStream memoryStream = new();

        ReportGenerator.GetBaseReport("Stock Report", page => {
            page.Content().Table(table => {
                table.ColumnsDefinition(columns => {
                    columns.ConstantColumn(30);
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.ConstantColumn(100);
                    columns.ConstantColumn(120);
                });

                table.Header(header => {
                    header.Cell().BorderBottom(2).Padding(8).Text("ID");
                    header.Cell().BorderBottom(2).Padding(8).Text("Name");
                    header.Cell().BorderBottom(2).Padding(8).Text("SKU");
                    header.Cell().BorderBottom(2).Padding(8).Text("Quantity");
                    header.Cell().BorderBottom(2).Padding(8).Text("Quantity Level");
                });

                foreach (StockModel stock in models) {
                    table.Cell().Padding(8).Text(stock.Id.ToString());
                    table.Cell().Padding(8).Text(stock.Name);
                    table.Cell().Padding(8).Text(stock.Sku);
                    table.Cell().Padding(8).Text(stock.Quantity.ToString());
                    table.Cell().Padding(8).Text(stock.Quantity >= stock.HighQuantity ? "High" : stock.Quantity <= stock.LowQuantity ? "Low" : "Medium").FontColor(stock.Quantity >= stock.HighQuantity ? "#00AA00" : stock.Quantity <= stock.LowQuantity ? "#FF0000" : "#FFA500");
                }
            });
        }).GeneratePdf(memoryStream);

        return memoryStream;
    }
}
