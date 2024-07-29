using System.Threading.Tasks;
using Avalonia.Media.Imaging;
using Avalonia.MusicStore.Models;
using ReactiveUI;

namespace Avalonia.MusicStore.ViewModels;

public class AlbumViewModel : ViewModelBase 
{
    private readonly Album _album;

    public AlbumViewModel(Album album)
    {
        _album = album;
    }
    
    private Bitmap? _cover;
    public Bitmap? Cover
    {
        get => _cover;
        private set => this.RaiseAndSetIfChanged(ref _cover, value);
    }
    
    public async Task LoadCover()
    {
        await using var imageStream = await _album.LoadCoverBitmapAsync();
        Cover = await Task.Run(() => Bitmap.DecodeToWidth(imageStream, 400));
    }

    // As the view model properties will not change in the UI during runtime, they have no setter and a plain getter -
    // there is no need to use the RaiseAndSetIfChanged method here
    public string Artist => _album.Artist;

    public string Title => _album.Title;
}