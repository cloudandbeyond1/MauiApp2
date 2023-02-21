

using Firebase.Auth;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    internal class Registerviewmodel
    {
        public string webApiKey = "AIzaSyAW7z-hB7VrwdcimRWzjjOfhdNF_6jIPz4";
        public Command RegisterUser { get; }

        private INavigation _navigation;


        public Registerviewmodel(INavigation navigation)
        {
            this._navigation = navigation;

            RegisterUser = new Command(RegisterUserTappedAsync);
        }
        private async void RegisterUserTappedAsync(object obj)
        {
            try
            {
                //FirebaseConfig firebaseConfig = new FirebaseAuthProvider(new FirebaseConfig(webApiKey));
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(webApiKey));
                var auth = await authProvider.createUserWithEmailAndPasswordAsync("Email", "Password");
            }
            catch (System.Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert",ex.Message,"ok");
                throw;
            }
        }
    }
}
