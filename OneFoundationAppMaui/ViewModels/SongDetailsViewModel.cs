using CommunityToolkit.Mvvm.ComponentModel;
using OneFoundationAppMaui.Models;
using System.Web;

namespace OneFoundationAppMaui.ViewModels
{
    [QueryProperty(nameof(Id), nameof(Id))]
    public partial class SongDetailsViewModel : BaseViewModel, IQueryAttributable
    {
        [ObservableProperty]
        Song song;

        [ObservableProperty]
        int id;

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Id = Convert.ToInt32(HttpUtility.UrlDecode(query["Id"].ToString()));
            Song = App.SongDatabaseService.GetSong(Id);
        }
    }
}
