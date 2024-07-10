using Avalonia.MusicStore.Models;

namespace Avalonia.MusicStore.ViewModels;

public class AlbumViewModel : ViewModelBase 
{
    private readonly Album _album;

    public AlbumViewModel(Album album)
    {
        _album = album;
    }

    // As the view model properties will not change in the UI during runtime, they have no setter and a plain getter -
    // there is no need to use the RaiseAndSetIfChanged method here
    public string Artist => _album.Artist;

    public string Title => _album.Title;
}