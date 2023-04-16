using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Layouts;
using OneFoundationAppMaui.Models;
using OneFoundationAppMaui.Services;
using OneFoundationAppMaui.Views;
using SongListApp.Maui.Services;
using System.Collections.ObjectModel;
using Debug = System.Diagnostics.Debug;

namespace OneFoundationAppMaui.ViewModels
{
    public partial class SongListViewModel : BaseViewModel
    {
        const string editButtonText = "Update Song";
        const string createButtonText = "Add Song";
        private readonly SongApiService songApiService;

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
                /*var songs = new List<Song>();
                songs = await songApiService.GetSongs();*/

                var songs = App.SongDatabaseService.GetSongs();
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
                await Shell.Current.DisplayAlert("Invalid Data", "Please insert valid data", "Ok");
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
                App.SongDatabaseService.UpdateSong(song);
                await Shell.Current.DisplayAlert("Info", App.SongDatabaseService.StatusMessage, "Ok");
            }
            else
            {
                App.SongDatabaseService.AddSong(song);
                await Shell.Current.DisplayAlert("Info", App.SongDatabaseService.StatusMessage, "Ok");
            }

            await GetSongList();
            await ClearForm();                
        }

        /*    [RelayCommand]
            async Task SaveSong()
            {
                if (string.IsNullOrEmpty(Title) || string.IsNullOrEmpty(Authors) || string.IsNullOrEmpty(Lyrics))
                {
                    await Shell.Current.DisplayAlert("Invalid Data", "Please insert valid data", "Ok");
                    return;
                }

                var song = new Song
                {
                    Title = Title,
                    Authors = Authors,
                    Lyrics = Lyrics
                };

                if (SongId != 0)
                {
                    song.Id = SongId;
                    App.SongDatabaseService.UpdateSong(song);
                    await Shell.Current.DisplayAlert("Info", App.SongDatabaseService.StatusMessage, "Ok");
                }
                else
                {
                    App.SongDatabaseService.AddSong(song);
                    await Shell.Current.DisplayAlert("Info", App.SongDatabaseService.StatusMessage, "Ok");
                }

                await GetSongList();
                await ClearForm();
            }*/

        [RelayCommand]
        async Task DeleteSong(int id)
        {
            if (id == 0)
            {
                await Shell.Current.DisplayAlert("Invalid Record", "Please try again", "Ok");
                return;
            }
            var result = App.SongDatabaseService.DeleteSong(id);
            if (result == 0) await Shell.Current.DisplayAlert("Failed", "Please insert valid data", "Ok");
            else
            {
                await Shell.Current.DisplayAlert("Deletion Successful", "Record Removed Successfully", "Ok");
                await GetSongList();
            }
        }

        [RelayCommand]
        async Task SetEditMode(int id)
        {
            AddEditButtonText = editButtonText;
            SongId = id;
            var song = App.SongDatabaseService.GetSong(id);
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

        /*[RelayCommand]
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
            var song = App.SongDatabaseService.GetSong(id);
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
        }*/
    }
}
