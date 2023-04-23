using OneFoundationAppMaui.Models;
using OneFoundationAppMaui.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OneFoundationAppMaui.ViewModels
{
    [QueryProperty(nameof(Id), nameof(Id))]
    public partial class SongDetailsViewModel : BaseViewModel, IQueryAttributable
    {
        private readonly SongApiService carApiService;

        public SongDetailsViewModel(SongApiService carApiService)
        {
            this.carApiService = carApiService;
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
                Song = await carApiService.GetSong(Id);
            }
            else
            {
                Song = App.SongDatabaseService.GetSong(Id);
            }
        }
    }
}
