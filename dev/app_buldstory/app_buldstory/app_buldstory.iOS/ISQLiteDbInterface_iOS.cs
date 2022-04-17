using System;
using Xamarin.Forms;
using System.IO;
using app_buldstory.Interfaces;
using app_buldstory.iOS;
using SQLite;

[assembly: Dependency(typeof(ISQLiteDbInterface_iOS))]
namespace app_buldstory.iOS
{
    public class ISQLiteDbInterface_iOS : ISQLite
    {
        public SQLiteConnection GetSQLiteConnection()
        {
            var fileName = "buldstory.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);
            return new SQLiteConnection(path, false);

        }
    }
}