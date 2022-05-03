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
    public partial class MonumentHistoryListPage : ContentPage
    {

        private MonumentHistoryListViewModel _monumentHistoryListViewModel;

        public MonumentHistoryListPage()
        {
            InitializeComponent();
            BindingContext = _monumentHistoryListViewModel = new MonumentHistoryListViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _monumentHistoryListViewModel.OnAppearing();
        }

    }
}