namespace a2_coursework;
internal class AppContext : ApplicationContext {
    public AppContext() {
        // When he AppContext is instantiated, attatch the application exit event to allow code cleanup when the application exits
        Application.ApplicationExit += OnApplicationExit;

        // Start the applciation
        ApplicationStartupManager startupManager = new();
        startupManager.StartApplicationAsync();
    }

    private void OnApplicationExit(object? sender, EventArgs e) {
        // Clean up code
    }
}
