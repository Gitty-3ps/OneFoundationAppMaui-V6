using OneFoundationAppMaui.ViewModels;

namespace OneFoundationAppMaui;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel loginViewModel)
	{
		InitializeComponent();
		BindingContext = loginViewModel;
	}
}