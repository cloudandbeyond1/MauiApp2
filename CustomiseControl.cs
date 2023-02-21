using Microsoft.Maui.Graphics.Text;
using MauiApp1.Pages;

namespace MauiApp1;

public class CustomiseControl : Label
{
    public static readonly BindableProperty urlproprty = BindableProperty.Create(null, typeof(string), typeof(CustomiseControl), null);
    public CustomiseControl()
    {
        TextDecorations = TextDecorations.Underline;
        TextColor = Colors.Red;
        GestureRecognizers.Add(new TapGestureRecognizer
        {
            Command = new Command(async () => await Navigation.PushAsync(new Register()))
        });

    }
}



