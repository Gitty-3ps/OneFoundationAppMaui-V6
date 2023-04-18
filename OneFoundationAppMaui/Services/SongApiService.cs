using Newtonsoft.Json;
using OneFoundationAppMaui.Models;
using System.Net.Http.Json;

namespace OneFoundationAppMaui.Services
{
    public class SongApiService
    {
        HttpClient _httpClient;
        public static string BaseAddress = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:8097" :
            "http://localhost:8097";

        public string StatusMessage;
        public SongApiService()
        {
            _httpClient = new() { BaseAddress = new Uri(BaseAddress) };
        }

        public async Task <List<Song>> GetSongs()
        {
            try
            {
                var response = await _httpClient.GetStringAsync("/cars");
                return JsonConvert.DeserializeObject<List<Song>>(response);
            }
            catch (Exception ex)
            {
                StatusMessage = "Failed to retrieve data.";
            }

            return null;
        }

        public async Task<Song> GetSong(int id)
        {
            try
            {
                var response = await _httpClient.GetStringAsync("/cars/" + id);
                return JsonConvert.DeserializeObject<Song>(response);
            }
            catch (Exception)
            {
                StatusMessage = "Failed to retrieve data.";
            }

            return null;
        }

        public async Task AddSong(Song song)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("/cars/", song);
                response.EnsureSuccessStatusCode();
                StatusMessage = "Insert Successful";
            }
            catch (Exception ex)
            {
                StatusMessage = "Failed to add data.";
            }
        }

        public async Task DeleteSong(int id)
        {
            try
            {

                var response = await _httpClient.DeleteAsync("/cars/" + id);
                response.EnsureSuccessStatusCode();
                StatusMessage = "Delete Successful";
            }
            catch (Exception)
            {
                StatusMessage = "Failed to delete data.";
            }
        }

        public async Task UpdateSong(int id, Song song)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync("/cars/" + id, song);
                response.EnsureSuccessStatusCode();
                StatusMessage = "Update Successful";
            }
            catch (Exception)
            {
                StatusMessage = "Failed to update data.";
            }
        }

    }
}
