namespace MauiApp1.Pages;

public partial class Subject : ContentPage
{
	public Subject()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddSubject());
    }
}