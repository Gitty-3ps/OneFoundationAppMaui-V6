namespace OneFoundationAppMaui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		var getuserSavedKey = Preferences.Get("UserAlreadyloggedIn", false);

		if (getuserSavedKey == true)
		{
			MyAppShell.CurrentItem = MyDashboardPage;
		}
		else
		{
            MyAppShell.CurrentItem = MyLoginPage;
        }
    }
}
