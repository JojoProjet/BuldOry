using app_buldstory.Services;
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
            //this.BindingContext = new LoginViewModel();
            
            InitializeComponent();
            userData = new UserDB();
            NavigationPage.SetHasBackButton(this, false);
            userNameEntry.ReturnCommand = new Command(() => passwordEntry.Focus());
        }


        private async void LoginValidation_ButtonClicked(object sender, EventArgs e)
        {

            if (userNameEntry.Text != null && passwordEntry.Text != null)
            {
                var validData = userData.LoginValidate(userNameEntry.Text, passwordEntry.Text);
                if (validData)
                {
                    await Navigation.PushAsync(new LoginPage());
                }
                else
                {
                    await DisplayAlert("Login Failed", "Username or Password Incorrect", "OK");
                }
            }
            else
            {
                await DisplayAlert("He He", "Enter User Name and Password Please", "OK");
            }
        }
    }
}