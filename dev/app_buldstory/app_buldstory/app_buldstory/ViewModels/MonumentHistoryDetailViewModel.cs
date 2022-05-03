using app_buldstory.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace app_buldstory.ViewModels
{
    [QueryProperty(nameof(ItemMonument), nameof(ItemMonument))]
    public class MonumentHistoryDetailViewModel : BaseViewModel
    {
        public Fields ItemMonument { get; set; } 

        public MonumentHistoryDetailViewModel(Fields item)
        {
            ItemMonument = item;
        }

        public void LoadData()
        {

        }

    }
}
