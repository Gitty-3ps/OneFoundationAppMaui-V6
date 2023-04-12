using CommunityToolkit.Mvvm.ComponentModel;
using OneFoundationAppMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneFoundationAppMaui.ViewModels
{
    [QueryProperty(nameof(Song), "Song")]
    public partial class SongDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        Song song;      
    }
}
