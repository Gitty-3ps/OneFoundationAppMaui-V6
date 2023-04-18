using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OneFoundationAppMaui.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OneFoundationAppMaui.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        [ObservableProperty]
        string username;

        [ObservableProperty]
        string password;

        [RelayCommand]
        async Task Login()
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayLoginError();
            }
            else
            {
                // Call API to attempt a login
                var loginSuccessful = true;

                if (loginSuccessful)
                {
                    //display welcome message

                    //build...
                }

                await DisplayLoginError();
            }
        }
        async Task DisplayLoginError()
        {
            await Shell.Current.DisplayAlert("Invalid Attempt", "Invalid Username or Password","OK");
            Password = string.Empty;
        }
    }
}
