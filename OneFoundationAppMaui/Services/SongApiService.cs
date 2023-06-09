﻿using Newtonsoft.Json;
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
                await SetAuthToken();
                var response = await _httpClient.GetStringAsync("/songs");
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
                var response = await _httpClient.GetStringAsync("/songs/" + id);
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
                var response = await _httpClient.PostAsJsonAsync("/songs/", song);
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

                var response = await _httpClient.DeleteAsync("/songs/" + id);
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
                var response = await _httpClient.PutAsJsonAsync("/songs/" + id, song);
                response.EnsureSuccessStatusCode();
                StatusMessage = "Update Successful";
            }
            catch (Exception)
            {
                StatusMessage = "Failed to update data.";
            }
        }

        public async Task<AuthResponseModel> Login(LoginModel loginModel)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("/login", loginModel);
                response.EnsureSuccessStatusCode();
                StatusMessage = "Login Successful";

                return JsonConvert.DeserializeObject<AuthResponseModel>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                StatusMessage = "Failed to login successfully.";
                //AuthResponseModel()
                return default;
            }
        }

        public async Task SetAuthToken()
        {
            var token = await SecureStorage.GetAsync("Token");
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }

    }
}
