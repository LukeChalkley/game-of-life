using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using wpf.Settings;
using wpf.ViewModels;

namespace wpf;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public App()
    {
        Services = ConfigureServices();
        ParseCommandLine(Environment.GetCommandLineArgs());
        SetupMainWindow();
        MainWindow.Show();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    private void ParseCommandLine(String[] args)
    {
        StartupSettings settings = Services.GetService<StartupSettings>();
        
        if (args[1] == "--sideLength") settings.SideLength = int.Parse(args[2]);
    }

    /// <summary>
    /// 
    /// </summary>
    private void SetupMainWindow()
    {
        MainWindow = Services.GetService<MainWindow>();
        StartupSettings settings = Services.GetService<StartupSettings>();
        MainWindowViewModel mainWindowViewModel = Services.GetService<MainWindowViewModel>();
        MainWindow.DataContext = mainWindowViewModel;
        
        mainWindowViewModel.SideLength = settings.SideLength;
        
        
    }
    
    /// <summary>
    /// Gets the <see cref="IServiceProvider"/> instance to resolve application services.
    /// </summary>
    public IServiceProvider Services { get; }
    
    private static IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();
        
        services.AddSingleton<MainWindow>();
        services.AddSingleton<MainWindowViewModel>();
        services.AddSingleton<StartupSettings>();

        return services.BuildServiceProvider();
    }
}