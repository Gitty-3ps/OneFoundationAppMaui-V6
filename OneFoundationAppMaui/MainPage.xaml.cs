using OneFoundationAppMaui.ViewModels;

namespace OneFoundationAppMaui;

public partial class MainPage : ContentPage
{
    private readonly SongListViewModel songListViewModel;

    public MainPage(SongListViewModel songListViewModel)
	{
		InitializeComponent();
        BindingContext = songListViewModel;
    }
}

