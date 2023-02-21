using MauiApp1.Pages;
using MauiPopup.Views;

namespace MauiApp1.Calender;

public partial class Addcalender : BasePopupPage
{
    private DateTime start_Date;
    private DateTime end_Date;

    public Addcalender(DateTime selectedDate)
	{
        InitializeComponent();
        string[] theDate = Calendar.parseDate(selectedDate);

        // date selected displayed in the pop-up form
        startDate.Date = selectedDate;
        endDate.Date = selectedDate;
        start_Date = selectedDate;
    }

    private void startTimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {

    }

    private void endTimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {

    }

    private void save_button_Clicked(object sender, EventArgs e)
    {

    }

    private void cancel_button_Clicked(object sender, EventArgs e)
    {
        MauiPopup.PopupAction.ClosePopup(); 
    }
    //private void SelectionChanged(object sender, ValueChangedEventArgs<int> e)
    //{
    //    this.selectionItemLabel.Text = $"The new selected item index is {e.NewValue}.";
    //}
}