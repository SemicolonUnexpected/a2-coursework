using a2_coursework.Presenter;
using a2_coursework.View;

namespace a2_coursework; 
internal static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.EnableVisualStyles();

        Splash splash = new();
        SplashPresenter splashPresenter = new(splash);

        Master master;
        MasterPresenter masterPresenter;

        Task.Run(async () => {
            await splashPresenter.ShowLoading();

            splash.Invoke(() => {
                master = new();
                masterPresenter = new();

                splashPresenter.Close();
                master.Show();
            });
        });

        Application.Run();
    }
}