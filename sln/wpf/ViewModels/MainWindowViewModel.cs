using CommunityToolkit.Mvvm.ComponentModel;

namespace wpf.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{

    /// <summary>
    /// Gets the side length of the game grid.
    /// </summary>
    [ObservableProperty] private int _sideLength;
    
    public MainWindowViewModel()
    {
        
    }
}