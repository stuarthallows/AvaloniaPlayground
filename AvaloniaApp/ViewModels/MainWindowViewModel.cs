using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _textBlockName = "Welcome to Avalonia!";
    
    [RelayCommand]
    private void ButtonOnClick()
    {
        TextBlockName = "Hello, Avalonia!";
    }
}