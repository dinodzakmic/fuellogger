using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;


namespace FuelLogger.Model
{
    public class Log
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Price { get; set; }
        public string Date { get; set; }
    }
}
 