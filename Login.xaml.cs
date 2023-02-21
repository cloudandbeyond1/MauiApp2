using Syncfusion.Maui.TabView;
using MauiApp1.Pages;
using MauiApp1.ForgotPassword;
using System.Text.RegularExpressions;

namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
    }
    private void OnCounterClicked(object sender, EventArgs e)
    {

        PasswordError.IsVisible = false;
        EmailError.IsVisible = false;

        bool validate = true;
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        string userName = "";
        if (!string.IsNullOrEmpty(EmailEntry.Text) && !string.IsNullOrWhiteSpace(EmailEntry.Text) && validate)
        {
            userName = EmailEntry.Text.Trim();
            if (!Regex.IsMatch(userName, pattern))
            {

                EmailError.IsVisible = true;
                validate = false;
            }
        }
        else
        {

            EmailError.IsVisible = true;
            validate = false;
        }
        if (validate)
        { 
            if (string.IsNullOrEmpty(PasswordEntry.Text) || string.IsNullOrWhiteSpace(PasswordEntry.Text))
            {
                PasswordError.IsVisible = true;
                validate = false; 
            } 
        }

        if (validate)
        {
            Application.Current.MainPage = new AppShell();
        }

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Register());
    }


    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ForgotPasswordPage());
    }


}