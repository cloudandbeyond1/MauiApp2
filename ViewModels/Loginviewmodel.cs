using Firebase.Auth;
using MauiApp1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    internal class Loginviewmodel
    {
        public string webapi = "AIzaSyAW7z-hB7VrwdcimRWzjjOfhdNF_6jIPz4";

        public Command RegisterBtn { get; }

        public Command LoginBtn { get; }


        private INavigation _navigation;

        public Loginviewmodel(INavigation navigation)
        {
            this._navigation = navigation;
            RegisterBtn = new Command(RegisterBtnTappedAsync);
            LoginBtn = new Command(LoginBtnTappedAsync);
        }

        private async void RegisterBtnTappedAsync(object obj)
        {
            await this._navigation.PushAsync(new Register());
        }
        private async void LoginBtnTappedAsync(object obj)
        {
            var authprovider = new FirebaseAuth(new FirebaseConfig(webapi));
            await this._navigation.PushAsync(new AppShell());
        }
    }
}
