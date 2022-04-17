using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace app_buldstory.Interfaces
{
    public interface ISQLite
    {
        SQLiteConnection GetSQLiteConnection();
    }
}
