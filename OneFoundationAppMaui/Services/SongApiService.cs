using System;

namespace OneFoundationAppMaui.Services
{
    public class SongApiService
    {
        HttpClient _httpClient;
        public static string BaseAddress = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:8097" :
            "http://localhost:8099";

        public string StatusMessage;
        public SongApiService()
        {
            _httpClient = new() { BaseAddress = new Uri(BaseAddress) };
        }

        //public async Task <List<SongApiService>>GetSongs
    }
}
