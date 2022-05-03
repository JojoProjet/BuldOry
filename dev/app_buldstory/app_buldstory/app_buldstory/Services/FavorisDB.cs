using app_buldstory.Models;
using app_buldstory.Interfaces;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace app_buldstory.Services
{
    public class FavorisDB
    {
        private SQLiteConnection _SQLiteConnection;

        public FavorisDB()
        {
            _SQLiteConnection = DependencyService.Get<ISQLite>().GetSQLiteConnection();
            _SQLiteConnection.CreateTable<Favoris>();
        }
        public IEnumerable<Favoris> GetFavoris(int idUser)
        {
            return (from u in _SQLiteConnection.Table<Favoris>()
                    select u).Where(elm => elm.IdUser == idUser).ToList();
        }

        public string AddFavoris(Favoris favoris)
        {
            var data = _SQLiteConnection.Table<Favoris>();
            var d1 = data.Where(x => x.RecordId == favoris.RecordId).FirstOrDefault();
            if (d1 == null)
            {
                _SQLiteConnection.Insert(favoris);
                return "Sucessfully Added";
            }
            else
                return "Already Id Exist";

        }

        public void DeleteFavoris(int id)
        {
            _SQLiteConnection.Delete<Favoris>(id);
        }

    }
}
