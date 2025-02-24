using QuestPDF.Fluent;
using QuestPDF.Helpers;

namespace a2_coursework.Model.Reports;
public static class ReportGenerator {
    public static Document GetBaseReport(string reportName, Action<PageDescriptor> content) {
        return Document.Create(container => {
            container.Page(page => {
                page.DefaultTextStyle(x => x.FontSize(12));
                page.Margin(20);

                page.Header().PaddingBottom(50)
                    .Row(row => {
                        row.RelativeItem().AlignLeft().Column(col => {
                            col.Item().PaddingBottom(20).Text($"Report Name: {reportName}").FontSize(12).Bold();
                            col.Item().Text($"Date: {DateTime.Now:dd MMM yyyy}").FontSize(12).Bold();
                        });
                        row.ConstantItem(150).AlignRight().AlignMiddle().Image(ConvertImage(Properties.Resources.Logo_Title_Condensed));
                    });

                content(page);
            });
        });
    }
    //public static Document GetBaseReport(string reportName) {
    //    return Document.Create(container => {
    //        container.Page(page => {
    //            page.Size(PageSizes.A4);
    //            page.Margin(2, Unit.Centimetre);
    //            page.DefaultTextStyle(x => x.FontSize(12));

    //            page.Header().

    //            page.Content()
    //                .PaddingVertical(25)
    //                .Text(Placeholders.LoremIpsum())
    //                .Justify();

    //            page.Footer()
    //                .AlignRight()
    //                .Text(text => {
    //                    text.CurrentPageNumber();
    //                    text.Span("/");
    //                    text.TotalPages();
    //                });
    //        });

    //    });
    //}

    public static byte[] ConvertImage(Bitmap bitmap) {
        using MemoryStream memoryStream = new();
        ImageConverter imageConverter = new();

        return (byte[])imageConverter.ConvertTo(bitmap, typeof(byte[]))!;
    }
}
