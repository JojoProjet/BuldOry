using app_buldstory.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace app_buldstory.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}