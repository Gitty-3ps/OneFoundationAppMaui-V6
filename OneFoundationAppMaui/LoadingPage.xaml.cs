using OneFoundationAppMaui.ViewModels;

namespace OneFoundationAppMaui;

public partial class LoadingPage : ContentPage
{
	public LoadingPage(LoadingPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}