using Microsoft.Extensions.Logging;
using OneFoundationAppMaui.Services;
using OneFoundationAppMaui.ViewModels;
using OneFoundationAppMaui.Views;

namespace OneFoundationAppMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<SongService>();

        builder.Services.AddSingleton<SongListViewModel>();
        builder.Services.AddTransient<SongDetailsViewModel>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<SongDetailsPage>();


        /*
        #if DEBUG
                builder.Logging.AddDebug();
        #endif
        */
        return builder.Build();
	}
}
