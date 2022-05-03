using app_buldstory.Models;
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
    public partial class MonumentHistoryDetailPage : ContentPage
    {
        public MonumentHistoryDetailPage(Fields item)
        {
            InitializeComponent();
            BindingContext = new MonumentHistoryDetailViewModel(item);
        }
    }
}