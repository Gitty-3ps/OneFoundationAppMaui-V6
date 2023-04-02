using CommunityToolkit.Mvvm.Input;
using OneFoundationAppMaui.Models;
using OneFoundationAppMaui.Services;
using System.Collections.ObjectModel;
using Debug = System.Diagnostics.Debug;

namespace OneFoundationAppMaui.ViewModels
{
    public partial class SongListViewModel : BaseViewModel
    {
        private readonly SongService songService;
        public ObservableCollection<Song> Songs { get; set; } = new ();

        public SongListViewModel(SongService songService)
        {
            Title = "Song List";
            this.songService = songService;
        }

        [RelayCommand]
        async Task GetCarListAsync()
        {
            if (IsLoading) return;
            try
            {
                IsLoading = true;
                if (Songs.Any()) Songs.Clear();

                var songs = songService.GetSongs();

                foreach (var song in songs) songs.Add(song);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get songs: {ex.Message}");
                await Shell.Current.DisplayAlert("Error", "Falied to retrieve list of cars.", "OK");
                throw;
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}
