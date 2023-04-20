using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OneFoundationAppMaui.Models;
using OneFoundationAppMaui.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OneFoundationAppMaui.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        public LoginViewModel(SongApiService songApiService)
        {
            this.songApiService = songApiService;
        }
        [ObservableProperty]
        string username;

        [ObservableProperty]
        string password;
        private SongApiService songApiService;

        [RelayCommand]
        async Task Login()
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayLoginMessage("Invalid Login Attempt");
            }
            else
            {
                // Call API to attempt a login
                var loginModel = new LoginModel(username, password);

                var response = await songApiService.Login(loginModel);

                await DisplayLoginMessage(songApiService.StatusMessage);

                if (!string.IsNullOrEmpty(response.Token))
                {
                    // Store token in secure storage 
                    await SecureStorage.SetAsync("Token", response.Token);

                    // build a menu on the fly...based on the user role
                    var jsonToken = new JwtSecurityTokenHandler().ReadToken(response.Token) as JwtSecurityToken;

                    var role = jsonToken.Claims.FirstOrDefault(q => q.Type.Equals(ClaimTypes.Role))?.Value;

                    App.UserInfo = new UserInfo()
                    {
                        Username = Username,
                        Role = role
                    };


                    // navigate to app's main page
                    //MenuBuilder.BuildMenu();
                    await Shell.Current.GoToAsync($"{nameof(MainPage)}");

                }
                else
                {
                    await DisplayLoginMessage("Invalid Login Attempt");
                }
            }
        }
        async Task DisplayLoginMessage(string message)
        {
            await Shell.Current.DisplayAlert("Login Attempt Result", message, "OK");
            Password = string.Empty;
        }
    }
}
