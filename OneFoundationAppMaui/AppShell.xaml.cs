using OneFoundationAppMaui.Views;

namespace OneFoundationAppMaui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(SongDetailsPage), typeof(SongDetailsPage));
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(SongDetailsPage), typeof(SongDetailsPage));
  
    }
}
