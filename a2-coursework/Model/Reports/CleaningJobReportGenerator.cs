using a2_coursework.Model.CleaningJob;
using a2_coursework.Model.CleaningJobOption;
using a2_coursework.Model.Customer;
using a2_coursework.Model.Staff;
using QuestPDF.Fluent;

namespace a2_coursework.Model.Reports; 
public static class CleaningJobReportGenerator {
    public static async Task<MemoryStream> CleaningJobItemsReport(CleaningJobModel model) {
        StaffModel staff = (await StaffDAL.GetStaffById(model.StaffId))!;

        List<StaffModel> cleaningStaff = [];
        foreach (int staffId in model.StaffIds) { cleaningStaff.Add((await StaffDAL.GetStaffById(staffId))!); }

        CustomerModel customer = (await CustomerDAL.GetCustomerById(model.CustomerId))!;

        MemoryStream memoryStream = new();

        ReportGenerator.GetBaseReport("Staff security details", page => {
            page.Content().Element(container => container.Column(column => {
                column.Item().Text("Cleaning Job Details").FontSize(16).Bold();

                column.Item().PaddingVertical(10);

                column.Item().Column(innerColumn => {
                    innerColumn.Spacing(5);

                    innerColumn.Item().Text(text => {
                        text.Span("Cleaning Job ID: ").Bold();
                        text.Span($"{model.Id}");
                    });

                    innerColumn.Item().Text(text => {
                        text.Span("Booked by: ").Bold();
                        text.Span($"{staff.Forename} {staff.Surname}");
                    });

                    innerColumn.Item().PaddingVertical(5);

                    innerColumn.Item().Text(text => {
                        text.Span("Customer ID: ").Bold();
                        text.Span($"{customer.Id}");
                    });

                    innerColumn.Item().Text(text => {
                        text.Span("Customer Name: ").Bold();
                        text.Span($"{customer.Forename} {customer.Surname}");
                    });

                    innerColumn.Item().Text(text => {
                        text.Span("Customer Email: ").Bold();
                        text.Span($"{customer.Email}");
                    });

                    innerColumn.Item().Text(text => {
                        text.Span("Customer Phone Number: ").Bold();
                        text.Span($"{customer.PhoneNumber}");
                    });

                    innerColumn.Item().PaddingVertical(5);

                    innerColumn.Item().Text(text => {
                        text.Span("Date: ").Bold();
                        text.Span($"{model.StartDate:dd/mm/yyyy}");
                    });

                    innerColumn.Item().Text(text => {
                        text.Span("Start Time: ").Bold();
                        text.Span($"{model.StartDate:HH:mm}");
                    });

                    innerColumn.Item().Text(text => {
                        text.Span("End Time: ").Bold();
                        text.Span($"{model.StartDate:HH:mm}");
                    });

                    innerColumn.Item().PaddingVertical(5);

                    innerColumn.Item().Text("Address").Bold();
                    innerColumn.Item().MinHeight(80).Border(1).Padding(5).Text(model.Address);

                    innerColumn.Item().PaddingVertical(5);

                    innerColumn.Item().Text("Extra Information").Bold();
                    innerColumn.Item().MinHeight(80).Border(1).Padding(5).Text(model.ExtraInformation);
                });

                column.Item().PageBreak();

                column.Item().Text("Cleaning Job Staff").FontSize(16).Bold();

                column.Item().PaddingVertical(10);

                column.Item().Table(table => {
                    table.ColumnsDefinition(columns => {
                        columns.ConstantColumn(50);
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

                column.Item().PageBreak();

                column.Item().Text("Cleaning Job Options").FontSize(16).Bold();

                column.Item().PaddingVertical(10);

                column.Item().Text(text => {
                    text.Span("Total Cost: ").Bold();
                    text.Span($"£{model.CleaningJobOptions.Sum(x => x.CostAtTime * x.Quantity):0.00}");
                });

                column.Item().PaddingVertical(5);

                column.Item().Table(table => {
                    table.ColumnsDefinition(columns => {
                        columns.ConstantColumn(50);
                        columns.RelativeColumn();
                        columns.RelativeColumn();
                        columns.RelativeColumn();
                        columns.RelativeColumn();
                    });

                    table.Header(header => {
                        header.Cell().BorderBottom(2).Padding(8).Text("ID");
                        header.Cell().BorderBottom(2).Padding(8).Text("Name");
                        header.Cell().BorderBottom(2).Padding(8).Text("Unit Cost (£)");
                        header.Cell().BorderBottom(2).Padding(8).Text("Quantity");
                        header.Cell().BorderBottom(2).Padding(8).Text("Subtotal (£)");
                    });

                    foreach (CleaningJobOptionModel cleaningJobModel in model.CleaningJobOptions) {
                        table.Cell().Padding(8).Text(cleaningJobModel.Id.ToString());
                        table.Cell().Padding(8).Text($"{cleaningJobModel.Name}");
                        table.Cell().Padding(8).Text($"{cleaningJobModel.CostAtTime:0.00}");
                        table.Cell().Padding(8).Text($"{cleaningJobModel.Quantity}");
                        table.Cell().Padding(8).Text($"{cleaningJobModel.Quantity * cleaningJobModel.CostAtTime}");
                    }
                });
            }));
        }).GeneratePdf(memoryStream);

        return memoryStream;
    }
}
