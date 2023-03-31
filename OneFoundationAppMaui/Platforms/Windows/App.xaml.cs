using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace OneFoundationAppMaui.WinUI;

/// <summary>
/// Provides application-specific behavior to supplement the default Application class.
/// </summary>
public partial class App : MauiWinUIApplication
{
	/// <summary>
	/// Initializes the singleton application object.  This is the first line of authored code
	/// executed, and as such is the logical equivalent of main() or WinMain().
	/// </summary>
	public App()
	{
		this.InitializeComponent();

		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) =>
		{
#if __ANDRIOD__
			handler.PatformView.SetBackgroundColor(Andriod.Graphics.Color.Transparent);
#elif __IOS__
			handler.Platform.BackgroundColor = UIKit.UIColor.Clear;
			handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
		});
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}

