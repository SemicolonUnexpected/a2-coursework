using a2_coursework.Model.Staff;
using QuestPDF.Fluent;

namespace a2_coursework.Model.Reports;
public static class StaffReportGenerator {
    public static  async Task<MemoryStream> StaffSecurityReport() {
        List<StaffModel> models = await StaffDAL.GetStaff();
        MemoryStream memoryStream = new();

        ReportGenerator.GetBaseReport("Staff Report", page => {
            page.Content().Table(table => {
                table.ColumnsDefinition(columns => {
                    columns.ConstantColumn(30);
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.ConstantColumn(120);
                    columns.RelativeColumn();
                });

                table.Header(header => {
                    header.Cell().BorderBottom(2).Padding(8).Text("ID");
                    header.Cell().BorderBottom(2).Padding(8).Text("Surname");
                    header.Cell().BorderBottom(2).Padding(8).Text("Forename");
                    header.Cell().BorderBottom(2).Padding(8).Text("Username");
                    header.Cell().BorderBottom(2).Padding(8).Text("Privilege Level");
                    header.Cell().BorderBottom(2).Padding(8).Text("Last Password Change");
                });

                foreach (StaffModel staff in models) {
                    table.Cell().Padding(8).Text(staff.Id.ToString());
                    table.Cell().Padding(8).Text(staff.Surname);
                    table.Cell().Padding(8).Text(staff.Forename);
                    table.Cell().Padding(8).Text(staff.Username);
                    table.Cell().Padding(8).Text(staff.PrivilegeLevel.ConvertToString());
                    table.Cell().Padding(8).Text(staff.LastPasswordChange.ToString("dd MMM yyyy"));
                }
            });
        }).GeneratePdf(memoryStream);

        return memoryStream;
    }
}
