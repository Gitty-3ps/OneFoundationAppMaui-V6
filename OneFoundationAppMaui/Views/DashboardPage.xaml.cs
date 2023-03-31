using OneFoundationAppMaui.ViewModels;

namespace OneFoundationAppMaui.Views;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
		BindingContext = new DashboardPageViewModel();
	}
}