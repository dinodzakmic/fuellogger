using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelLogger.Pages;
using Xamarin.Forms;

namespace FuelLogger
{
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            var detailPage = new NavigationPage(new Dashboard() { Title = "FuelLogger" });
            Detail = detailPage;
        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            Detail= new NavigationPage(new Calculator());
            IsPresented = false;
        }
    }
}
