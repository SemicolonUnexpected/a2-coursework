using a2_coursework.Model.Reports;
using Patagames.Pdf;
using Patagames.Pdf.Net.Controls.WinForms;
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


        byte[] value = StaffReportGenerator.StaffSecurityReport().Result;

        // Start the application
        Application.Run(new AppContext());
    }
}