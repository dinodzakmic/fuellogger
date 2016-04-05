using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelLogger.Interfaces;
using FuelLogger.Model;
using SQLite.Net;
using Xamarin.Forms;

namespace FuelLogger.Helpers
{
    public class LogsDatabase
    {
        public static SQLiteConnection database;
        public LogsDatabase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Log>();
        }

        public IEnumerable<Log> GetItems()
        {
            return (from i in database.Table<Log>() select i).ToList();
        } 


    }
}
