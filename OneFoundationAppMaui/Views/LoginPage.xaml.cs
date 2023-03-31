using OneFoundationAppMaui.ViewModels;

namespace OneFoundationAppMaui.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel();
	}
}