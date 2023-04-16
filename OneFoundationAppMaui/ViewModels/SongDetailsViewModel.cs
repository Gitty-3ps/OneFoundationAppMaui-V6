using CommunityToolkit.Mvvm.ComponentModel;
using OneFoundationAppMaui.Models;
using OneFoundationAppMaui.Services;
using System.Web;

namespace OneFoundationAppMaui.ViewModels
{
    [QueryProperty(nameof(Id), nameof(Id))]
    public partial class SongDetailsViewModel : BaseViewModel, IQueryAttributable
    {
        private readonly SongApiService songApiService;

        public SongDetailsViewModel(SongApiService songApiService)
        {
            this.songApiService = songApiService;
        }

        NetworkAccess accessType = Connectivity.Current.NetworkAccess;

        [ObservableProperty]
        Song song;

        [ObservableProperty]
        int id;

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Id = Convert.ToInt32(HttpUtility.UrlDecode(query["Id"].ToString()));
        }

        public async Task GetSongData()
        {
            if (accessType == NetworkAccess.Internet)
            {
                Song = await songApiService.GetSong(Id);
            }
            else
            {
                Song = App.SongDatabaseService.GetSong(Id);
            }
        }
    }
}
