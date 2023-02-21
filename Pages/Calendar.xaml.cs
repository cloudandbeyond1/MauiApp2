using MauiApp1.Calender;

namespace MauiApp1.Pages;

public partial class Calendar : ContentPage
{
	public Calendar()
	{
		InitializeComponent();
	}

    private void AddCalendar_Clicked(object sender, EventArgs e)
    {
        
        AddCalendar.IsEnabled = false;
        DateTime dateSelected = Convert.ToDateTime(string.IsNullOrEmpty(schedule.SelectedDate.ToString()) ? DateTime.Now.ToString() : schedule.SelectedDate.ToString());
        MauiPopup.PopupAction.DisplayPopup(new Addcalender(dateSelected));
        AddCalendar.IsEnabled = true;
    }


    public static string[] parseDate(DateTime date)
    {
        var day = date.Day.ToString();
        var month = date.Month.ToString();
        var year = date.Year.ToString();
        string[] parsedDate = { day, month, year };
        return parsedDate;
    }
}