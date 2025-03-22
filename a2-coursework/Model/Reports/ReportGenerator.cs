using QuestPDF.Fluent;

namespace a2_coursework.Model.Reports;
public static class ReportGenerator {
    public static Document GetBaseReport(string reportName, Action<PageDescriptor> content) {
        return Document.Create(container => {
            container.Page(page => {
                page.DefaultTextStyle(x => x.FontSize(12));
                page.Margin(20);

                page.Header().PaddingBottom(15).Column(column => {
                    column.Item().Row(row => {
                         row.RelativeItem().AlignLeft().Column(col => {
                             col.Item().PaddingBottom(10).Text($"Report Name: {reportName}").FontSize(12).Bold();
                             col.Item().Text($"Report Date: {DateTime.Now:dd MMM yyyy HH:mm}").FontSize(12).Bold();
                         });
                         row.ConstantItem(150).AlignRight().AlignMiddle().Image(ConvertImage(Properties.Resources.Logo_Title_Condensed));
                     });

                    column.Item().PaddingVertical(10).LineHorizontal(2);
                });


                content(page);
            });
        });
    }

    public static byte[] ConvertImage(Bitmap bitmap) {
        using MemoryStream memoryStream = new();
        ImageConverter imageConverter = new();

        return (byte[])imageConverter.ConvertTo(bitmap, typeof(byte[]))!;
    }
}
