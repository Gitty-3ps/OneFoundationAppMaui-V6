using CommunityToolkit.Mvvm.Input;
using OneFoundationAppMaui.Models;
using OneFoundationAppMaui.Services;
using OneFoundationAppMaui.Views;
using System.Collections.ObjectModel;
using Debug = System.Diagnostics.Debug;

namespace OneFoundationAppMaui.ViewModels
{
    public partial class SongListViewModel : BaseViewModel
    {
        private readonly SongService songService;
        public ObservableCollection<Song> Songs { get; private set; } = new ();

        public SongListViewModel(SongService songService)
        {
            Title = "Song List";
            this.songService = songService;
        }

        [RelayCommand]
        async Task GetSongList()
        {
            if (IsLoading) return;
            try
            {
                IsLoading = true;
                if (Songs.Any()) Songs.Clear();

                var songs = songService.GetSongs();

                foreach (var song in songs) Songs.Add(song);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get songs: {ex.Message}");
                await Shell.Current.DisplayAlert("Error", "Falied to retrieve list of songs.", "OK");
                throw;
            }
            finally
            {
                IsLoading = false;
            }
        }

        [RelayCommand]
        async Task GetSongDetails(Song song)
        {
            if (song == null) return;

            await Shell.Current.GoToAsync(nameof(SongDetailsPage), true, new Dictionary<string, object>
            { 
                {nameof(Song), song}
            });
        }
    }
}
