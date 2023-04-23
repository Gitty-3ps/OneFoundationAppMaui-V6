using OneFoundationAppMaui.ViewModels;

namespace OneFoundationAppMaui.Views;

public partial class SongDetailsPage : ContentPage
{
    private readonly SongDetailsViewModel songDetailsViewModel;

    public SongDetailsPage(SongDetailsViewModel songDetailsViewModel)
    {
        InitializeComponent();
        BindingContext = songDetailsViewModel;
        this.songDetailsViewModel = songDetailsViewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await songDetailsViewModel.GetSongData();
    }

}