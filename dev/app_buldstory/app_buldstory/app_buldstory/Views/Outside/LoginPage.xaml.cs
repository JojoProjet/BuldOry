using app_buldstory.Services;
using app_buldstory.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app_buldstory.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        UserDB userData;

        public LoginPage()
        {
            InitializeComponent();
            userData = new UserDB();
            userNameEntry.ReturnCommand = new Command(() => passwordEntry.Focus());
        }

        private async void LoginValidation_ButtonClicked(object sender, EventArgs e)
        {
            string defaultText = "";
            if (userNameEntry.Text != null && passwordEntry.Text != null)
            {
                var validData = userData.LoginValidate(userNameEntry.Text, passwordEntry.Text);
                if(validData)
                {
                    userNameEntry.Text = defaultText;
                    passwordEntry.Text = defaultText;
                    Shell.Current.GoToAsync("////HomePage");
                } else
                {
                    DisplayAlert("Login Failed", "Username or Password Incorrect", "OK");
                }
            }
            else
                await DisplayAlert("He He", "Enter User Name and Password Please", "OK");
        }
    }
}