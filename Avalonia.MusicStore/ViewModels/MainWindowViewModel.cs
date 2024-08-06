using System.Collections.ObjectModel;
using System.Reactive.Concurrency;
using System.Linq;
using System.Reactive.Linq;
using System.Windows.Input;
using Avalonia.MusicStore.Models;
using ReactiveUI;

namespace Avalonia.MusicStore.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            ShowDialog = new Interaction<MusicStoreViewModel, AlbumViewModel?>();

            BuyMusicCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                var store = new MusicStoreViewModel();

                var result = await ShowDialog.Handle(store);
                
                if (result != null)
                {
                    Albums.Add(result);
                    await result.SaveToDiskAsync();
                }
            });
            
            RxApp.MainThreadScheduler.Schedule(LoadAlbums);
        }

        public ObservableCollection<AlbumViewModel> Albums { get; } = new();
        
        public ICommand BuyMusicCommand { get; }

        public Interaction<MusicStoreViewModel, AlbumViewModel?> ShowDialog { get; }
        
        /// <summary>
        /// Load the user's album collections from disk.
        /// </summary>
        private async void LoadAlbums()
        {
            var cachedAlbums = await Album.LoadCachedAsync();
            var albums = cachedAlbums.Select(x => new AlbumViewModel(x));

            foreach (var album in albums)
            {
                Albums.Add(album);
            }

            foreach (var album in Albums.ToList())
            {
                await album.LoadCover();
            }
        }
    }
}
