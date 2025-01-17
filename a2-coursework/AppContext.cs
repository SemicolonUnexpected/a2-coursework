namespace a2_coursework;
internal class AppContext : ApplicationContext {

    public AppContext() {
        Application.ApplicationExit += OnApplicationExit;

        ApplicationStartupManager startupManager = new();
        startupManager.StartApplication();
    }

    private void OnApplicationExit(object? sender, EventArgs e) {
        // CLean up code
    }
}
