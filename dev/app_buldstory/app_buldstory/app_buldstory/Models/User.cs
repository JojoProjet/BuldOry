using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace app_buldstory.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string name { get; set; }
        public string password { get; set; }

        public User() { }

    }
}
