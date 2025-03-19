using a2_coursework.Model.CleaningJob;
using a2_coursework.Model.Staff;
using a2_coursework.Model.Stock;
using QuestPDF.Fluent;

namespace a2_coursework.Model.Reports; 
public static class CleaningJobReportGenerator {
    public static  async Task<MemoryStream> CleaningJobItemsReport(CleaningJobModel model, List<StaffModel> cleaningStaff) {
        MemoryStream memoryStream = new();

        ReportGenerator.GetBaseReport("Staff security details", page => {
            //page.Content().
            page.Content().Table(table => {
                table.ColumnsDefinition(columns => {
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });

                table.Header(header => {
                    header.Cell().BorderBottom(2).Padding(8).Text("ID");
                    header.Cell().BorderBottom(2).Padding(8).Text("Name");
                });

                foreach (StaffModel staff in cleaningStaff) {
                    table.Cell().Padding(8).Text(staff.Id.ToString());
                    table.Cell().Padding(8).Text($"{staff.Forename} {staff.Surname}");
                }
            });
        }).GeneratePdf(memoryStream);

        return memoryStream;
    }
}
