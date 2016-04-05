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

        

        private void DashboardTapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Dashboard());
            IsPresented = false;
        }

        private void CalculatorTapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Calculator());
            IsPresented = false;
        }

        private void MenuItem3Tapped(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
