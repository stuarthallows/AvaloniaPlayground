using System.Threading.Tasks;
using Avalonia.Media.Imaging;
using AvaloniaApp.Helpers;

namespace AvaloniaApp.ViewModels;

public class ImagePageViewModel: ViewModelBase
{
    public Task<Bitmap?> ImageSourceBitmapWeb
        => ImageHelper.LoadFromWeb("https://avatars.githubusercontent.com/u/44047697");
}