using OneFoundationAppMaui.ViewModels;

namespace OneFoundationAppMaui;

public partial class MainPage : ContentPage
{
    public MainPage(SongListViewModel songListViewModel)
	{
		InitializeComponent();
        BindingContext = songListViewModel;
    }
}

