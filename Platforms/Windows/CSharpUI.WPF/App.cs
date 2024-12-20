using System.Windows;

namespace CSharpUI.WPF;

public class App : Application
{
    [STAThread]
    public static void Main()
    {
        var app = new App();
        app.Run();
    }

    public App()
    {
        // Application startup logic here (no XAML)
        Startup += OnStartup;
    }

    private void OnStartup(object sender, StartupEventArgs e)
    {
        // Define and show the MainWindow (instead of using StartupUri in XAML)
        var mainWindow = new MainWindow
        {
            Title = "My WPF Application",
            Width = 800,
            Height = 600
        };
        mainWindow.Show();
    }
}