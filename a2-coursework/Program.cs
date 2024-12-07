using System.Runtime.InteropServices;

namespace a2_coursework; 
internal static class Program {
    [DllImport("shcore.dll")]
    static extern int SetProcessDpiAwareness(PROCESS_DPI_AWARENESS awareness);

    enum PROCESS_DPI_AWARENESS {
        Process_DPI_Unaware = 0,
        Process_System_DPI_Aware = 1,
        Process_Per_Monitor_DPI_Aware = 2
    }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        SetProcessDpiAwareness(PROCESS_DPI_AWARENESS.Process_Per_Monitor_DPI_Aware);

        ApplicationConfiguration.Initialize();
        Application.EnableVisualStyles();

        // Start the application
        Application.Run(new AppContext());
    }
}