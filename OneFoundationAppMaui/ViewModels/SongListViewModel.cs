using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OneFoundationAppMaui.Models;
using OneFoundationAppMaui.Services;
using OneFoundationAppMaui.Views;
using System.Collections.ObjectModel;
using System.Reflection;
using Debug = System.Diagnostics.Debug;

namespace OneFoundationAppMaui.ViewModels
{
    public partial class SongListViewModel : BaseViewModel
    {
        const string editButtonText = "Update Song";
        const string createButtonText = "Add Song";
        private readonly SongApiService songApiService;
        NetworkAccess accessType = Connectivity.Current.NetworkAccess;
        string message = string.Empty;

        public ObservableCollection<Song> Songs { get; private set; } = new();

        public SongListViewModel(SongApiService songApiService)
        {
            //Title = "Song List";
            AddEditButtonText = createButtonText;
            this.songApiService = songApiService;
        }

        [ObservableProperty]
        bool isRefreshing;
        [ObservableProperty]
        string title;
        [ObservableProperty]
        string authors;
        [ObservableProperty]
        string lyrics;
        [ObservableProperty]
        string addEditButtonText;
        [ObservableProperty]
        int songId;

        [RelayCommand]
        async Task GetSongList()
        {
            if (IsLoading) return;
            try
            {
                IsLoading = true;
                if (Songs.Any()) Songs.Clear();
                var songs = new List<Song>();
                if(accessType == NetworkAccess.Internet)
                {
                    songs = await songApiService.GetSongs();
                }
                else
                {
                    songs = App.SongDatabaseService.GetSongs();
                }               
                foreach (var song in songs) Songs.Add(song);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get songs: {ex.Message}");
                await ShowAlert("Failed to retrieve list of songs");
            }
            finally
            {
                IsLoading = false;
                IsRefreshing = false;
            }
        }

        [RelayCommand]
        async Task GetSongDetails(int id)
        {
            if (id == 0) return;

            await Shell.Current.GoToAsync($"{nameof(SongDetailsPage)}?Id={id}", true);
        }

        [RelayCommand]
        async Task SaveSong()
        {
            if (string.IsNullOrEmpty(Title) || string.IsNullOrEmpty(Authors) || string.IsNullOrEmpty(Lyrics))
            {
                await ShowAlert("Please insert valid data");
                return;
            }

            var song = new Song
            {
                Id = SongId,
                Title = Title,
                Authors = Authors,
                Lyrics = Lyrics
            };

            if (SongId != 0)
            {
                if (accessType == NetworkAccess.Internet)
                {
                    await songApiService.UpdateSong(SongId, song);
                    message = songApiService.StatusMessage;
                }
                else
                {
                    App.SongDatabaseService.UpdateSong(song);
                    message = App.SongDatabaseService.StatusMessage;
                }
            }
            else
            {
                if (accessType == NetworkAccess.Internet)
                {
                    await songApiService.AddSong(song);
                    message = songApiService.StatusMessage;
                }
                else
                {
                    App.SongDatabaseService.AddSong(song);
                    message = App.SongDatabaseService.StatusMessage;
                }

            }

            await ShowAlert(message);
            await GetSongList();
            await ClearForm();                
        }

        [RelayCommand]
        async Task DeleteSong(int id)
        {
            if (id == 0)
            {
                await ShowAlert("Please try again");
                return;
            }

            if (accessType == NetworkAccess.Internet)
            {
                await songApiService.DeleteSong(id);
                message = songApiService.StatusMessage;
            }
            else
            {
                App.SongDatabaseService.DeleteSong(id);
                message = App.SongDatabaseService.StatusMessage;
            }

            await ShowAlert(message);
            await GetSongList();
            
        }

        [RelayCommand]
        async Task UpdateSong(int id)
        {
            AddEditButtonText = editButtonText;
            return;
        }

        [RelayCommand]
        async Task SetEditMode(int id)
        {
            AddEditButtonText = editButtonText;
            SongId = id;
            Song song;
            if (accessType == NetworkAccess.Internet)
            {
                song = await songApiService.GetSong(SongId);
            }
            else
            {
                song = App.SongDatabaseService.GetSong(SongId);
            }

            Title = song.Title;
            Authors = song.Authors;
            Lyrics = song.Lyrics;
        }

        [RelayCommand]
        async Task ClearForm()
        {
            AddEditButtonText = createButtonText;
            SongId = 0;
            Title = string.Empty;
            Authors = string.Empty;
            Lyrics = string.Empty;
        }

        private async Task ShowAlert(string message)
        {
            await Shell.Current.DisplayAlert("Info", message, "OK");
        }
    }
}
