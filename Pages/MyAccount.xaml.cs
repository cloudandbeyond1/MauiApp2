using Syncfusion.Maui.Core;

namespace MauiApp1.Pages;

public partial class MyAccount : ContentPage
{
    protected override bool OnBackButtonPressed() => false;
    bool allowPopup = true;
    public MyAccount()
    {
        InitializeComponent();
    }

    private void SignOut_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewPage1());
    }

    private void Delete_Clicked(object sender, EventArgs e)
    {
        var result =  DisplayAlert("Are you sure you want to delete your account?",
                "If you delete your account all your information will be permanently deleted.", "Yes", "No");
        if (!busyindicator.IsVisible && allowPopup)
        {
            allowPopup = false;
            //if (!App.loggedInNow && result)
            //{
            //     DisplayAlert("For security reasons", "Please log in again before deleting your account!", "OK");
            //   // App.UserUID = "";
            //   // App.Current.Properties.Remove("App.UserUID");
            //    // App.Current.SavePropertiesAsync();
            //    App.Current.MainPage = new NavigationPage(new NewPage1());
            //    OnBackButtonPressed();
            //}
            //if (result && App.loggedInNow) // if it's equal to Yes
            //{
            bool validate = true;
            try
            {
                //await authDeleteAccount.DeleteAccount();
            }
            catch (Exception)
            {
                validate = false;
            }
            if (validate)
            {
                try
                {
                    //  await fireBaseHelperStudent.DeleteStudent(App.UserUID);
                }
                catch (Exception)
                {
                    validate = false;
                }
            }
            if (result.IsCompleted)
            {
                //App.UserUID = "";
                App.Current.MainPage = new NavigationPage(new NewPage1());
                DisplayAlert("Account deleted", "To use the application again please sign up", "OK");
                //App.Current.Properties.Remove("App.UserUID");
                //await App.Current.SavePropertiesAsync();
                OnBackButtonPressed();
            }
            else
            {
                DisplayAlert("Something went wrong...", "Please check your interner connection", "OK");
            }
        }
        allowPopup = true;
        // }
    }

    private void EditAccount_Clicked(object sender, EventArgs e)
    {
        if (!busyindicator.IsVisible && allowPopup)
        {
            allowPopup = false;
            // Student student = new Student();
            bool connection = true;
            try
            {
                // student = await fireBaseHelperStudent.GetStudent(userID);
            }
            catch (Exception)
            {
                connection = false;
            }
            if (connection)
            {
                MauiPopup.PopupAction.DisplayPopup(new EditAccount());
            }
            else
            {
                DisplayAlert("Something went wrong...", "Please check your interner connection", "OK");
            }
            allowPopup = true;
        }
    }

    private void Contactus_Clicked(object sender, EventArgs e)
    {
        if (!busyindicator.IsVisible && allowPopup)
        {
            allowPopup = false;
            //Navigation.PushAsync(new Contactus());
            allowPopup = true;
        }
    }

    private void help_button_Clicked(object sender, EventArgs e)
    {
        if (helpMyAccount.IsVisible)
        {
            helpMyAccount.IsVisible = false;
        }
        else
        {
            helpMyAccount.IsVisible = true;
        }
    }
}