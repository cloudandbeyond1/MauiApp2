using MauiPopup.Views;

namespace MauiApp1.Pages;

public partial class EditAccount : BasePopupPage
{
	public EditAccount()
	{
		InitializeComponent();
	}

    private void save_profile_button_Clicked(object sender, EventArgs e)
    { 
        busyindicator.IsVisible = true;
        save_profile_button.IsEnabled = false; 
        bool validate = true; 
        ErrorName.IsVisible = false;
        ErrorInstite.IsVisible = false; 

        if (string.IsNullOrEmpty(userName.Text) || string.IsNullOrWhiteSpace(userName.Text))
        { 
            validate = false; 
            ErrorName.IsVisible = true; 
            busyindicator.IsVisible = false; 
        } 
        if (validate)
        { 
            if (string.IsNullOrWhiteSpace(userInstitute.Text) || string.IsNullOrEmpty(userInstitute.Text))
            { 
                validate = false;
                ErrorInstite.IsVisible = true;
                busyindicator.IsVisible = false;
            } 
        } 
        if (validate)
        { 
            bool connection = true;
            try 
            { 
               // var studentToEdit = await fireBaseHelperStudent.GetStudent(user.StudentID);
            } 
            catch (Exception) 
            { 
                connection = false;
            } 
            try 
            {
               // await fireBaseHelperStudent.UpdateAccount(user.StudentID, userName.Text, userInstitute.Text);
            }
            catch (Exception) 
            { 
                connection = false;
            }
            if (connection) 
            {
                busyindicator.IsVisible = false; 
                Navigation.PushAsync(new MyAccount(), false); 
                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1]);
                MauiPopup.PopupAction.ClosePopup();
            } 
            else 
            {
                busyindicator.IsVisible = false; 
                DisplayAlert("Something went wrong...", "Please check your interner connection", "OK"); 
            } 
        } 
        save_profile_button.IsEnabled = true; 
    }

    private void Cancel_Clicked(object sender, EventArgs e)
    {
        MauiPopup.PopupAction.ClosePopup();
    }
}