using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelLogger.Helpers;
using FuelLogger.Model;
using SQLite.Net;
using Xamarin.Forms;

namespace FuelLogger
{
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var t = new LogsDatabase();
            var items = t.GetItems();
        }

        
        
    }
}
