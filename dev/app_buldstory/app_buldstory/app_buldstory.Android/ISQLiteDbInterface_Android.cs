using System.IO;
using app_buldstory.Droid.Dependancies;
using app_buldstory.Interfaces;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetSQLiteConnnection))]
namespace app_buldstory.Droid.Dependancies
{
    public class GetSQLiteConnnection : ISQLite
    {
        public GetSQLiteConnnection()
        {

        }
        public SQLiteConnection GetSQLiteConnection()
        {
            var fileName = "buldstory.db3";
            var documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, fileName);
            return new SQLiteConnection(path, false);
        }
    }
}