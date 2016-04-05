using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FuelLogger.Droid;
using FuelLogger.Interfaces;
using SQLite.Net;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinAndroid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(SQLiteAndroid))]
namespace FuelLogger.Droid
{
    public class SQLiteAndroid : ISQLite
    {
        public SQLiteAndroid()
        {
            
        }

        #region ISQLite implementation

        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "LogsSQLite.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);

            //test
            Console.WriteLine(path);

            if (!File.Exists(path))
            {
                //var s = Forms.Context.Resources.OpenRawResource()

                FileStream writeStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);


            }

            var conn = new SQLiteConnection(new SQLitePlatformAndroid(), path);
            return conn;
        }
        #endregion
    }
}