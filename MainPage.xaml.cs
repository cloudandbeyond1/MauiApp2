
using MauiApp1.ViewModels;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new Loginviewmodel(Navigation);
	}

	
    
}

