using MauiApp1.ViewModels;

namespace MauiApp1.Pages;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
		BindingContext = new Registerviewmodel(Navigation);
	}
   
}