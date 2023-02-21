using MauiApp1.Pages;

namespace MauiApp1.ForgotPassword;

public partial class ForgotPasswordPage : ContentPage
{
	public ForgotPasswordPage()
	{
		InitializeComponent();
	}

    private void ForgotPassword(object sender, EventArgs e)
    {

    }

    private void sign_up_button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Register());
    }
}