using app_buldstory.Models;
using app_buldstory.Services;
using app_buldstory.Views;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace app_buldstory.ViewModels
{
    public class MonumentHistoryListViewModel : BaseViewModel
    {

        private Fields _selectedItem;
        public ObservableCollection<Fields> Fields { get; }

        public Command LoadItemsCommand { get; }
        public Command<Fields> ItemTapped { get; }
        public Command<Fields> ButtonClicked { get; }


        string alert;
        public string Alert
        {
            get { return alert; }
            set { SetProperty(ref alert, value); }
        }

        string querry;
        public string Querry
        {
            get { return querry; }
            set { SetProperty(ref querry, value); }
        }

        string message;
        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }



        public MonumentHistoryListViewModel()
        {
            Fields = new ObservableCollection<Fields>();
            Alert = "";
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<Fields>(OnItemSelected);
            ButtonClicked = new Command<Fields>(OnCommandFavoris);
        }

        public async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Fields.Clear();
                var client = HttpService.GetInstance();
                var result = await client.GetAsync($"https://data.culture.gouv.fr/api/records/1.0/search/?dataset=liste-des-immeubles-proteges-au-titre-des-monuments-historiques&q=&rows=20&facet=region&facet=departement");
                var serializedResponse = await result.Content.ReadAsStringAsync();
                var monumentHistorys = JsonConvert.DeserializeObject<MonumentHistory>(serializedResponse);
                foreach (var a in monumentHistorys.Records)
                {
                    Fields.Add(new Fields(
                    a.Recordid,
                    a.Fields.Historique,
                    a.Fields.Commune,
                    a.Fields.AppellationCourante,
                    a.Fields.Coordonnees,
                    a.Fields.CodeDepartement,
                    a.Fields.Reference,
                    a.Fields.Departement,
                    a.Fields.Contact,
                    a.Fields.DateDeProtection,
                    (List<double>)a.Fields.CoordonneesFinales,
                        a.Fields.Insee,
                        a.Fields.Longitude,
                        a.Fields.CoordonneesBan,
                        a.Fields.AncienneRegion,
                        a.Fields.Latitude,
                        a.Fields.PrecisionSurLaProtection,
                        a.Fields.Commune1,
                        a.Fields.Dmaj,
                        a.Fields.Siecle,
                        a.Fields.Region,
                        a.Fields.Statut,
                        a.Fields.Adresse,
                        a.Fields.Adresse1,
                        a.Fields.Auteur));


                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public Fields SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        async void OnItemSelected(Fields item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            //await Shell.Current.GoToAsync($"{nameof(MonumentHistoryDetailPage)}?{nameof(MonumentHistoryDetailViewModel.ItemMonument)}={item}");
            await Application.Current.MainPage.Navigation.PushAsync(new MonumentHistoryDetailPage(item));
        }

        async void OnCommandFavoris(Fields item)
        {
            Favoris favoris = new Favoris();
            FavorisDB favorisDB = new FavorisDB();
            favoris.IdUser = 1;
            favoris.RecordId = item.Recordid;
            var retrunvalue = favorisDB.AddFavoris(favoris);
            if (retrunvalue == "Sucessfully Added")
            {
                Alert = "Item add to favoris !";
            }
            else
            {
                Alert = "Item not add to favoris same !";
            }
        }

    }
}
