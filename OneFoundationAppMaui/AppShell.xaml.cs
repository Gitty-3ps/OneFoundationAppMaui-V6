using OneFoundationAppMaui.Views;

namespace OneFoundationAppMaui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(SongDetailsPage), typeof(SongDetailsPage));
/*
        var getuserSavedKey = Preferences.Get("UserAlreadyloggedIn", false);

		if (getuserSavedKey == true)
		{
			MyAppShell.CurrentItem = MyDashboardPage;
		}
		else
		{
            MyAppShell.CurrentItem = MyLoginPage;
        }*/
    }
}
