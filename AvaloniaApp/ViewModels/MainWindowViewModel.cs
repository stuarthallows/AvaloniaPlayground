namespace AvaloniaApp.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string _textBlockName = "Welcome to Avalonia!";

    public string TextBlockName
    {
        get => _textBlockName;
        set => SetField(ref _textBlockName, value);
    }

    public void ButtonOnClick()
    {
        TextBlockName = "Hello, Avalonia!";
    }
}