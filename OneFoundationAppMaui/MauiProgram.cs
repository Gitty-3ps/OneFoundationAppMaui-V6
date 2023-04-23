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

		string dbPath = Path.Combine(FileSystem.AppDataDirectory, "songs.db3");
        builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<SongDatabaseService>(s, dbPath));

        builder.Services.AddTransient<SongApiService>();


        builder.Services.AddSingleton<SongListViewModel>();
        builder.Services.AddSingleton<LoadingPageViewModel>();
        builder.Services.AddSingleton<LoginViewModel>();
        builder.Services.AddSingleton<LogoutViewModel>();
        builder.Services.AddTransient<SongDetailsViewModel>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<LoadingPage>();
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<LogoutPage>();
        builder.Services.AddTransient<SongDetailsPage>();

        return builder.Build();
	}
}
