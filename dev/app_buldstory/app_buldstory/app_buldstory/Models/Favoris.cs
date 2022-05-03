using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace app_buldstory.Models
{
    public class Favoris
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string RecordId { get; set; }

        public int IdUser { get; set; }

        public Favoris() { }

    }

}