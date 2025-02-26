using a2_coursework.Model.Staff;
using a2_coursework.Model.Stock;
using QuestPDF.Fluent;

namespace a2_coursework.Model.Reports; 
public static class StockReportGenerator {
    public static  async Task<byte[]> StockItemsReport() {
        List<StockModel> models = await StockDAL.GetStock();

        Document document = ReportGenerator.GetBaseReport("Staff security details", page => {
            page.Content().Table(table => {
                table.ColumnsDefinition(columns => {
                    columns.ConstantColumn(30);
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.ConstantColumn(120);
                });

                table.Header(header => {
                    header.Cell().BorderBottom(2).Padding(8).Text("ID");
                    header.Cell().BorderBottom(2).Padding(8).Text("Name");
                    header.Cell().BorderBottom(2).Padding(8).Text("SKU");
                    header.Cell().BorderBottom(2).Padding(8).Text("Quantity");
                });

                foreach (StockModel stock in models) {
                    table.Cell().Padding(8).Text(stock.Id.ToString());
                    table.Cell().Padding(8).Text(stock.Name);
                    table.Cell().Padding(8).Text(stock.Sku);
                    table.Cell().Padding(8).Text(stock.Quantity.ToString());
                }
            });
        });

        return document.GeneratePdf();
    }
}
