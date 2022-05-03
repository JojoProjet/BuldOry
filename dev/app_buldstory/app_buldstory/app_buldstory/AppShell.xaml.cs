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
            Routing.RegisterRoute(nameof(MonumentHistoryDetailPage), typeof(MonumentHistoryDetailPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MainPage");
        }

    }
}
