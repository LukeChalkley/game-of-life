using CommunityToolkit.Mvvm.ComponentModel;

namespace wpf.Settings;

public class StartupSettings : ObservableObject
{
    public int SideLength { get; set; }
    
    public StartupSettings()
    {
        
    }
}