using OneFoundationAppMaui.ViewModels;

namespace OneFoundationAppMaui;

public partial class MainPage : ContentPage
{
    private readonly SongListViewModel songListViewModel;

    public MainPage(SongListViewModel songListViewModel)
    {
        InitializeComponent();
        BindingContext = songListViewModel;
        this.songListViewModel = songListViewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await songListViewModel.GetSongList();
    }
}

