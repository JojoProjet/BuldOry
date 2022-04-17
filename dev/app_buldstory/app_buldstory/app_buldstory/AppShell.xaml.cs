using app_buldstory.ViewModels;
using app_buldstory.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace app_buldstory
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MainPage());

        }
    }
}
