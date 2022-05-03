using app_buldstory.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app_buldstory.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        HomeViewModel _homeViewModel;

        public HomePage()
        {
            InitializeComponent();
            BindingContext = _homeViewModel = new HomeViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _homeViewModel.OnAppearing();
        }

        public void ClickLogout(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//MainPage");
        }

    }
}