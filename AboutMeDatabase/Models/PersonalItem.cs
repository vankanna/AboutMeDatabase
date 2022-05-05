using System;
using SQLite;

namespace AboutMeDatabase.Models
{
    public class PersonalItem
    {
        [PrimaryKey]
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        public string Image { get; set; }
    }
}
