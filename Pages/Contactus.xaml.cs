namespace MauiApp1.Pages;

public partial class Contactus : ContentPage
{
    public Contactus()
    {
        InitializeComponent();
    }

    private void facebook_button_Clicked(object sender, EventArgs e)
    {


        facebook_button.IsEnabled = false;
        Uri uri = new Uri("fb://page/222530839180059");
        Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        // Device.OpenUri(new Uri("fb://page/222530839180059"));
        facebook_button.IsEnabled = true;
    }

    private void contact_button_Clicked(object sender, EventArgs e)
    {
        contact_button.IsEnabled = false;
        Uri uri = new Uri("mailto:" + contact_button.Text);
        Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        //Device.OpenUri(new Uri("mailto:" + contact_button.Text));
        contact_button.IsEnabled = true;
    }
}