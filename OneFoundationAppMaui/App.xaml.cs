using OneFoundationAppMaui.Models;
using OneFoundationAppMaui.Services;
using SongListApp.Maui.Services;

namespace OneFoundationAppMaui;

public partial class App : Application
{
    public static UserInfo UserInfo;
    public static SongDatabaseService SongDatabaseService { get; private set; }
    public App(SongDatabaseService songDatabaseService)
    {
        InitializeComponent();

        MainPage = new AppShell();
        SongDatabaseService = songDatabaseService;
    }
}