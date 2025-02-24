using a2_coursework.Model.Reports;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace a2_coursework;
internal static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        ApplicationConfiguration.Initialize();
        Application.EnableVisualStyles();

        QuestPDF.Settings.License = LicenseType.Community;

        // Start the application
        //File.WriteAllBytes("test.pdf", StaffReportGenerator.StaffSecurityReport().Result);
        Application.Run(new AppContext());
    }
}