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
    public partial class FavorisPage : ContentPage
    {
        private FavorisViewModel _favorisViewModel;

        public FavorisPage()
        {
            InitializeComponent();
            BindingContext = _favorisViewModel = new FavorisViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _favorisViewModel.OnAppearing();
        }
    }
}