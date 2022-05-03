using app_buldstory.Services;
using app_buldstory.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app_buldstory
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            Shell.Current.GoToAsync("//MainPage");
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
