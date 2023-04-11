using OneFoundationAppMaui.ViewModels;

namespace OneFoundationAppMaui.Views;

public partial class SongDetailsPage : ContentPage
{
    public SongDetailsPage(SongDetailsViewModel songDetailsViewModel)
    {
        InitializeComponent();
        BindingContext = songDetailsViewModel;
    }


    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        // Do fanciness 

        base.OnNavigatedTo(args);

    }
}