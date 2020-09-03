using System;
using SQLite;
using Xamarin.Forms;

namespace BookKeeping.Model
{
    [Table("Money")]
    public class ObjectClass
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Target0 { get; set; }

        public int Target1 { get; set; }

        public int Target2 { get; set; }

        public int Target3 { get; set; }

        public int Target4 { get; set; }

        public int Spend0 { get; set; }

        public int Spend1 { get; set; }

        public int Spend2 { get; set; }

        public int Spend3 { get; set; }

        public int Spend4 { get; set; }

        public int Spend5 { get; set; }
    }
}
